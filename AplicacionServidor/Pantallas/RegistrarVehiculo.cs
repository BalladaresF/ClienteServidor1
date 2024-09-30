using System;
using System.Collections;
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
    public partial class RegistrarVehiculo : Form
    {
        public RegistrarVehiculo()
        {
            InitializeComponent();
        }

        private void TextBoxIDTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBoxCos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBoxKil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Excepciones:
                AccesoSQL Acceso = new AccesoSQL();
                List<Vehiculo> Lista = new List<Vehiculo>();
                Lista = Acceso.ObtenerVehiculo();

                if (TextBoxID.Text == "") throw new ValorNoValido("Debe ingresar una placa.");

                for (int i = 0; i < Lista.Count; i++)
                {
                    string ID = Lista[i].Placa;
                    if (TextBoxID.Text == ID) throw new ValorNoValido("La placa ya existe.");
                }

                if (TextBoxMar.Text == "") throw new ValorNoValido("Debe ingresar una marca.");
                if (TextBoxMar.Text == "") throw new ValorNoValido("Debe ingresar un modelo.");
                if (ComboBoxIDTipo.Text == "") throw new ValorNoValido("Debe ingresar un ID del tipo.");
                if (TextBoxCos.Text == "") throw new ValorNoValido("Debe ingresar un costo.");
                if (TextBoxKil.Text == "") throw new ValorNoValido("Debe ingresar un kilometraje.");

                //Ingreso de datos al arreglo:
                Vehiculo vehiculo = new Vehiculo();

                vehiculo.Placa = TextBoxID.Text;
                vehiculo.Marca = TextBoxMar.Text;
                vehiculo.Modelo = TextBoxMod.Text;
                vehiculo.IDTipo = Int32.Parse(ComboBoxIDTipo.Text);
                vehiculo.CostoAlquilerDia = Int32.Parse(TextBoxCos.Text);
                vehiculo.Kilometraje = Int32.Parse(TextBoxKil.Text);

                Acceso.AgregarVehiculo(vehiculo);

                //Borrado de datos para seguir ingresando:
                Aviso.ForeColor = Color.White;
                Aviso.Text = "El vehículo ha sido ingresado.";
                TextBoxID.Text="";
                TextBoxMar.Text = "";
                TextBoxMod.Text = "";
                ComboBoxIDTipo.Text = "";
                TextBoxCos.Text = "";
                TextBoxKil.Text = "";  
            }
            catch (ValorNoValido ex)
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = (ex.Message);
            }
        }

        private void RegistrarVehiculo_Load(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();
            List<TipoVehiculo> Items = new List<TipoVehiculo>();
            Items = Acceso.ObtenerTipoVehiculo();

            List<String> Valores = new List<String>();

            for (int i = 0; i < Items.Count; i++)
            {
                Valores.Add(Items[i].ID);
            }
            ComboBoxIDTipo.DataSource = Valores;
        }
    }
}
