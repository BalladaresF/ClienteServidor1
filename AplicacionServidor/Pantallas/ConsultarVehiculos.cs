using ClasesRentaUned;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConsultarVehiculos : Form
    {
        public ConsultarVehiculos()
        {
            InitializeComponent();
        }

        private void ConsultarVehiculos_Load(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();

            List<Vehiculo> Lista = new List<Vehiculo>();

            Lista = Acceso.ObtenerVehiculo();

            ListaVehiculos.DataSource = Lista;
        }
    }
}
