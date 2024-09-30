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
    public partial class ConsultarVehiculosSucursal : Form
    {
        public ConsultarVehiculosSucursal()
        {
            InitializeComponent();
        }

        private void ConsultarVehiculosSucursal_Load(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();

            List<VehiculoSucursalDatosTotales> Lista = new List<VehiculoSucursalDatosTotales>();

            Lista = Acceso.ObtenerVehiculoSucursal();

            ListaVehiculosSucursal.DataSource = Lista;
        }

    }
}
