using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesRentaUned;

namespace AplicacionCliente
{
    public partial class RegistroUsuario : Form
    {
        //Si se utilizan las líneas de Enabled de los botones, no se puede utilizar a más de un usuario al mismo tiempo.

        bool ClienteConectado = false;
        public RegistroUsuario()
        {
            InitializeComponent();
            lblEstado.ForeColor = Color.Red;
            //Registrar.Enabled = true;
            //Cerrar.Enabled = false;
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Intentar conectar al servidor con la identificación ingresada
                if (AccesoTCP.Conectar(TextBoxID.Text))
                {
                    lblEstado.ForeColor = Color.Green;
                    lblEstado.Text = "Estado: Conectado";

                    Form Formulario = new MenuPrincipal();
                    Formulario.Show();
                }
                else
                {
                    lblEstado.Text = "El cliente ingresado no existe.";
                }
            }
            catch (ValorNoValido ex)  // Capturar si el cliente no existe
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = (ex.Message);  // Mostrar el mensaje de error en la UI
            }
            catch (Exception ex)  // Cualquier otra excepción
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = $"Error: {ex.Message}";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool desconectado = await Task.Run(() => AccesoTCP.Desconectar(TextBoxID.Text));

                if (desconectado)
                {
                    lblEstado.ForeColor = Color.Red;
                    lblEstado.Text = "Estado: Desconectado";
                    //Registrar.Enabled = true; ;
                    //Cerrar.Enabled = false;
                }
                else
                {
                    lblEstado.Text = "Verifique la conexión. . .";
                }
            }
            catch (ValorNoValido ex)
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = (ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = (ex.Message);
            }
            catch (Exception ex) // Captura cualquier otra excepción
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = $"Error: {ex.Message}";
            }

        }
    }
}

