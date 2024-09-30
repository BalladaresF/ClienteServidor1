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
    public partial class RegistrarTipoVehiculo : Form
    {
        public RegistrarTipoVehiculo()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                AccesoSQL Acceso = new AccesoSQL();

                //Excepciones:
                List<TipoVehiculo> Lista = new List<TipoVehiculo>();
                Lista = Acceso.ObtenerTipoVehiculo();

                if (TextBoxID.Text == "") throw new ValorNoValido("Debe ingresar un ID.");

                for (int i = 0; i < Lista.Count; i++)
                {
                    String ID = Lista[i].ID.ToString();
                    if (TextBoxID.Text == ID) throw new ValorNoValido("La ID ya existe.");
                }

                if (TextBoxDesc.Text == "") throw new ValorNoValido("Debe ingresar una descripción.");
                if (ComboBoxEst.Text == "") throw new ValorNoValido("Debe ingresar un estado.");

                //ingreso de datos al arreglo:
                TipoVehiculo tipoVehiculo = new TipoVehiculo();

                tipoVehiculo.ID = TextBoxID.Text;
                tipoVehiculo.Descripcion=TextBoxDesc.Text;
                if (ComboBoxEst.Text == "Activo") tipoVehiculo.Estado = true;
                else tipoVehiculo.Estado = false;

                Acceso.AgregarTipoVehiculo(tipoVehiculo);

                //Borrado de datos para seguir ingresando:
                Aviso.ForeColor = Color.White;
                Aviso.Text = "El tipo de vehículo ha sido ingresado.";
                TextBoxID.Text = "";
                TextBoxDesc.Text = "";
                ComboBoxEst.Text = "";

            }
            catch (ValorNoValido ex)
            {
                Aviso.ForeColor = Color.Red;
                Aviso.Text = (ex.Message);
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
