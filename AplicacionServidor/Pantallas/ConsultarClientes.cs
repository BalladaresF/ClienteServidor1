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
    public partial class ConsultarClientes : Form
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();

            List<Cliente> Lista = new List<Cliente>();

            Lista = Acceso.ObtenerCliente();

            ListaClientes.DataSource = Lista;
        }
    }
}
