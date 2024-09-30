using System;
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
    public partial class RegistrarCobertura : Form
    {
        public RegistrarCobertura()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoSQL Acceso = new AccesoSQL();
                //Excepciones:
                List<Cobertura> Lista = new List<Cobertura>();
                Lista = Acceso.ObtenerCobertura();

                if (TextBoxID.Text == "") throw new ValorNoValido("Debe ingresar un ID.");

                for (int i = 0; i < Lista.Count; i++)
                {
                    string ID = Lista[i].ID;
                    if (TextBoxID.Text == ID) throw new ValorNoValido("La ID ya existe.");
                }

                if (TextBoxDesc.Text == "") throw new ValorNoValido("Debe ingresar una descripción.");
                if (ComboBoxIDTipo.Text == "") throw new ValorNoValido("Debe ingresar un ID del tipo.");
                if (ComboBoxEst.Text == "") throw new ValorNoValido("Debe ingresar un estado.");
                if (TextBoxMon.Text == "") throw new ValorNoValido("Debe ingresar un monto.");

                //Ingreso de datos al arreglo:
                Cobertura cobertura = new Cobertura();
                cobertura.ID = TextBoxID.Text;
                cobertura.Descripcion = TextBoxDesc.Text;
                cobertura.Tipo = Int32.Parse(ComboBoxIDTipo.Text);
                
                if (ComboBoxEst.Text == "Activo") cobertura.Estado = true;
                else cobertura.Estado = false;
                cobertura.Monto = Int32.Parse(TextBoxMon.Text);

                Acceso.AgregarCobertura(cobertura);

                //Borrado de datos para seguir ingresando:
                Aviso.ForeColor = Color.White;
                Aviso.Text = "La cobertura ha sido ingresada.";
                TextBoxID.Text = "";
                TextBoxDesc.Text = "";
                ComboBoxIDTipo.Text = "";
                ComboBoxEst.Text = "";
                TextBoxMon.Text = "";
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

        private void TextBoxIDTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TextBoxMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void RegistrarCobertura_Load(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();
            List<TipoVehiculo> Items = new List<TipoVehiculo>();
            Items = Acceso.ObtenerTipoVehiculo();

            List<String> Valores = new List<String>();

            for (int i = 0; i < Items.Count; i++)
            {
                Valores.Add(Items[i].ID);
            }
            ComboBoxIDTipo.DataSource = Valores;
        }
    }
}
