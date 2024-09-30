using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClasesRentaUned;

namespace WindowsFormsApp1
{
    public partial class RegistrarSucursal : Form
    {
        public RegistrarSucursal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Excepciones:
                AccesoSQL Acceso = new AccesoSQL();
                List<Sucursal> Lista = new List<Sucursal>();
                Lista = Acceso.ObtenerSucursal();

                if (TextBoxID.Text == "") throw new ValorNoValido("Debe ingresar un ID.");

                for (int i = 0; i < Lista.Count; i++)
                {
                    String ID = Lista[i].ID.ToString();
                    if (TextBoxID.Text == ID) throw new ValorNoValido("La ID ya existe.");
                }

                if (TextBoxNom.Text == "") throw new ValorNoValido("Debe ingresar un nombre.");
                if (TextBoxDir.Text == "") throw new ValorNoValido("Debe ingresar una dirección.");
                if (ComboBoxEst.Text == "") throw new ValorNoValido("Debe ingresar un estado.");
                if (TextBoxTel.Text == "") throw new ValorNoValido("Debe ingresar un teléfono.");

                //Ingreso de datos al arreglo:
                Sucursal sucursal = new Sucursal();

                sucursal.ID = Int32.Parse(TextBoxID.Text);
                sucursal.Nombre = TextBoxNom.Text;
                sucursal.Direccion = TextBoxDir.Text;
                if (ComboBoxEst.Text == "Activo") sucursal.Estado = true;
                else sucursal.Estado = false;
                sucursal.Telefono = TextBoxTel.Text;

                Acceso.AgregarSucursal(sucursal);

                //Borrado de datos para seguir ingresando:
                Aviso.ForeColor = Color.White;
                Aviso.Text = "La sucursal ha sido ingresada.";
                TextBoxID.Text = "";
                TextBoxNom.Text = "";
                TextBoxDir.Text = "";
                ComboBoxEst.Text = "";
                TextBoxTel.Text = "";
            }
            catch (ValorNoValido ex)
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = (ex.Message);
            }
        }

        private void TextBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
