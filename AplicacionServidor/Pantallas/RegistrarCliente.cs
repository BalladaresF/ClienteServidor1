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
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoSQL Acceso = new AccesoSQL();
                //Excepciones:
                List<Cliente> Lista = new List<Cliente>();
                Lista = Acceso.ObtenerCliente();

                if (TextBoxID.Text == "") throw new ValorNoValido("Debe ingresar un ID.");

                for (int i = 0; i < Lista.Count; i++)
                {
                    String ID = Lista[i].ID.ToString();
                    if (TextBoxID.Text == ID) throw new ValorNoValido("La ID ya existe.");
                }

                if (TextBoxNom.Text == "") throw new ValorNoValido("Debe ingresar un nombre.");
                if (TextBoxApUno.Text == "") throw new ValorNoValido("Debe ingresar un apellido.");
                if (TextBoxApDos.Text == "") throw new ValorNoValido("Debe ingresar un apellido.");
                if (ComboBoxGen.Text == "") throw new ValorNoValido("Debe ingresar un género.");

                //Ingreso de datos al arreglo:
                Cliente cliente = new Cliente();

                cliente.ID = TextBoxID.Text;
                cliente.Nombre=TextBoxNom.Text;
                cliente.ApellidoUno=TextBoxApUno.Text;
                cliente.ApellidoDos=TextBoxApDos.Text;
                DateTime Fecha = DateTimeNacim.Value;
                cliente.FechaNacimiento = Fecha;
                if (ComboBoxGen.Text == "Masculino") cliente.Genero = 'M';
                else if (ComboBoxGen.Text == "Femenino") cliente.Genero = 'F';
                else cliente.Genero = 'O';

                Acceso.AgregarCliente(cliente);

                //Borrado de datos para seguir ingresando:
                Aviso.ForeColor = Color.White;
                Aviso.Text = "El cliente ha sido ingresado.";
                TextBoxID.Text = "";
                TextBoxNom.Text = "";
                TextBoxApUno.Text = "";
                TextBoxApDos.Text = "";
                ComboBoxGen.Text = "";
            }
            catch (ValorNoValido ex)
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = (ex.Message);
            }
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
