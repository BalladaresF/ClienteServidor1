using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesRentaUned;

namespace WindowsFormsApp1
{
    public partial class RegistrarVehiculoSucursal : Form
    {
        public RegistrarVehiculoSucursal()
        {
            InitializeComponent();
        }

        private void RegistrarVehiculoSucursal_Load(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();
            List<Sucursal> Items = new List<Sucursal>();
            Items = Acceso.ObtenerSucursal();

            List<String> Valores = new List<String>();

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Estado == true)
                {
                    Valores.Add(Items[i].ID.ToString() + ", " + Items[i].Nombre + ", " + Items[i].Direccion);
                }
            }
            ComboBoxSucur.DataSource = Valores;

            List<Vehiculo> Vehiculos = new List<Vehiculo>();
            Vehiculos = Acceso.ObtenerVehiculo();

            ListaVehiculos.AllowUserToAddRows = false;
            for (int i = 0; i < Vehiculos.Count; i++)
            {
                int n = ListaVehiculos.Rows.Add();
                ListaVehiculos.Rows[n].Cells[0].Value = false;
                ListaVehiculos.Rows[n].Cells[1].Value = Vehiculos[i].Placa;
                ListaVehiculos.Rows[n].Cells[2].Value = Vehiculos[i].Marca;
                ListaVehiculos.Rows[n].Cells[3].Value = Vehiculos[i].Modelo;
            }
            VehiculosAgregados.AllowUserToAddRows = false;
        }

        private void ListaVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaVehiculos.CurrentRow.Selected = true;
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoSQL Acceso = new AccesoSQL();
                List<VehiculoSucursalDatosTotales> Lista = new List<VehiculoSucursalDatosTotales>();
                Lista = Acceso.ObtenerVehiculoSucursal();
                //Excepciones:

                if (TextBoxID.Text == "") throw new ValorNoValido("Debe ingresar un ID.");

                for (int i = 0; i < Lista.Count; i++)
                {
                    String ID = Lista[i].IDAsignacion.ToString();
                    if (TextBoxID.Text == ID) throw new ValorNoValido("El ID ya existe.");
                }

                //for (int i = 0; i < MetodoMain.ContadorVehiculoSucursal; i++)
                //{
                //    string ID = MetodoMain.ArregloVehiculoSucursal[i].IDAsignacion.ToString();
                //    if (TextBoxID.Text == ID) throw new ValorNoValido("El ID ya existe.");
                //}
                if (ComboBoxSucur.Text == "") throw new ValorNoValido("Debe ingresar una sucursal.");

                bool Confirmador = false;
                foreach (DataGridViewRow item in ListaVehiculos.Rows)
                {
                    if ((bool)item.Cells[0].Value == true)
                    {
                        Confirmador = true;
                    }
                }
                if (Confirmador == false) throw new ValorNoValido("Debe seleccionar un vehículo");

                //Ingreso de datos al arreglo:
                VehiculoSucursal vehiculoSucursal = new VehiculoSucursal();

                vehiculoSucursal.IDAsignacion = Int32.Parse(TextBoxID.Text);
                DateTime Fecha = DateTime.Now;
                vehiculoSucursal.Fecha = Fecha;

                List<Sucursal> Items = new List<Sucursal>();
                Items = Acceso.ObtenerSucursal();
                for (int i = 0; i < Items.Count; i++)
                {
                    String SucursalElegida = Items[i].ID + ", " +
                            Items[i].Nombre + ", " + Items[i].Direccion;
                    if (ComboBoxSucur.Text == SucursalElegida)
                    {
                        vehiculoSucursal.sucursal = Items[i].ID;
                        break;
                    }
                }

                //ingreso de los vehículos al DataGridView de vehículos agregados:
                VehiculosAgregados.Rows.Clear();
                foreach (DataGridViewRow item in ListaVehiculos.Rows)
                {
                    if ((bool)item.Cells[0].Value == true)
                    {
                        int n = VehiculosAgregados.Rows.Add();
                        VehiculosAgregados.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                        VehiculosAgregados.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                        VehiculosAgregados.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                        vehiculoSucursal.PlacaVehiculo = item.Cells[1].Value.ToString();
                    }
                }

                Acceso.AgregarVehiculoSucursal(vehiculoSucursal);

                Aviso.ForeColor = Color.White;
                Aviso.Text = "El agregado se ha realizado.";
            }
            catch (ValorNoValido ex)
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = (ex.Message);
                VehiculosAgregados.Rows.Clear();
            }
            catch (Exception)
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = ("No se puede ingresar más de un vehículo.");
            }
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Para que no sea necesario presionar el RadioButton, sino que toda la línea se pueda seleccionar.
        private void ListaVehiculos_MouseClick(object sender, MouseEventArgs e)
        {
            if ((bool)ListaVehiculos.SelectedRows[0].Cells[0].Value==false)
            {
                ListaVehiculos.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                ListaVehiculos.SelectedRows[0].Cells[0].Value = false;
            }
        }
    }
}
