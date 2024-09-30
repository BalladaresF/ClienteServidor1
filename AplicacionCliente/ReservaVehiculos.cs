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

namespace AplicacionCliente
{
    public partial class ReservaVehiculos : Form
    {
        public ReservaVehiculos()
        {
            InitializeComponent();
        }

        private void ReservaVehiculos_Load(object sender, EventArgs e)
        {
            
            // Obtener las sucursales activas mediante TCP
            List<Sucursal> sucursalesActivas = AccesoTCP.ObtenerSucursalesActivas();

            // Poblar el ComboBox con las sucursales activas
            foreach (Sucursal sucursal in sucursalesActivas)
            {
                ComboBoxEst.Items.Add(sucursal.ID);
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            int sucursalSeleccionada = Int32.Parse(ComboBoxEst.SelectedItem.ToString());

            // Obtener los vehículos de la sucursal seleccionada
            List<VehiculoSucursal> vehiculos = AccesoTCP.ObtenerVehiculosPorSucursal(sucursalSeleccionada);

            // Limpiar el DataGridView
            dataGridView1.Rows.Clear();

            if (vehiculos != null && vehiculos.Count > 0)
            {
                Console.WriteLine("Se encontraron " + vehiculos.Count + " vehículos.");
            }
            else
            {
                Console.WriteLine("No se encontraron vehículos o la lista es nula.");
            }

            // Poblar el DataGridView con los vehículos obtenidos
            foreach (VehiculoSucursal vehiculo in vehiculos)
            {
                Console.WriteLine("Vehículo: " + vehiculo);
                dataGridView1.Rows.Add(vehiculo.IDAsignacion, vehiculo.PlacaVehiculo, vehiculo.Fecha);
            }
        }

        //Para seleccionar la línea del cuadro:
        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    dataGridView1.CurrentRow.Selected = true;
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxEst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
