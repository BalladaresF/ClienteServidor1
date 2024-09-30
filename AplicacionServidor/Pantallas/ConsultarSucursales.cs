using ClasesRentaUned;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConsultarSucursales : Form
    {
        public ConsultarSucursales()
        {
            InitializeComponent();
        }

        private void ConsultarSucursales_Load(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();

            List<Sucursal> Lista = new List<Sucursal>();

            Lista = Acceso.ObtenerSucursal();

            ListaSucursales.DataSource = Lista;
        }
    }
}
  