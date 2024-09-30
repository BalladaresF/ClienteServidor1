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
    public partial class ConsultarCoberturas : Form
    {
        public ConsultarCoberturas()
        {
            InitializeComponent();
        }

        private void ConsultarCoberturas_Load(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();

            List<Cobertura> Lista = new List<Cobertura>();

            Lista = Acceso.ObtenerCobertura();

            ListaCoberturas.DataSource = Lista;
        }
    }
}
