using ClasesRentaUned;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConsultarTipoVehiculos : Form
    {
        public ConsultarTipoVehiculos()
        {
            InitializeComponent();
        }

        private void ConsultarTipoVehiculos_Load(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();

            List<TipoVehiculo> Lista = new List<TipoVehiculo>();

            Lista = Acceso.ObtenerTipoVehiculo();

            ListaTipoVehiculos.DataSource = Lista;
        }
    }
}
