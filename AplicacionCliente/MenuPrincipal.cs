using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using ClasesRentaUned;

namespace AplicacionCliente
{
    public partial class MenuPrincipal : Form
    {
        bool ServidorIniciado = false;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(local, 14100);


            if (radioButton1.Checked == true)
            {
                Form Formulario = new ReservaVehiculos();
                Formulario.Show();
            }

            if (radioButton2.Checked == true)
            {
                Form Formulario = new ConsultaVehiculos();
                Formulario.Show();
            }
        }
    }
}
