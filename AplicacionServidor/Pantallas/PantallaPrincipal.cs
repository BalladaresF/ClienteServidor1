using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using ClasesRentaUned;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class PantallaPrincipal : Form
    {
        AccesoSQL Acceso;
        TcpListener Listener;
        Thread EscuchaClientes;
        EscribirTextBoxDelegado ModificarTextoBitacora;
        ModificarlistBoxDelegado ModificarTextoClientes;

        private delegate void EscribirTextBoxDelegado(String texto);
        private delegate void ModificarlistBoxDelegado(String Texto, bool Agregar);

        private void EscribirTextBox(String Texto)
        {
            TextoBitacora.AppendText(DateTime.Now.ToString() + " - " + Texto);
            TextoBitacora.AppendText(Environment.NewLine);
        }

        private void ModificarListBox(String Texto, bool Agregar)
        {
            if (Agregar)
            {
                ListaUsuarios.Items.Add(Texto);
            }
            else
            {
                ListaUsuarios.Items.Remove(Texto);
            }
        }

        bool ServidorIniciado = false;

        public PantallaPrincipal()
        {
            InitializeComponent();
            TextoBitacora.ReadOnly = true;

            Acceso = new AccesoSQL();
            ModificarTextoBitacora = new EscribirTextBoxDelegado(EscribirTextBox);
            ModificarTextoClientes = new ModificarlistBoxDelegado(ModificarListBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccesoSQL Acceso = new AccesoSQL();

            //Parte 1: Realizar los registros.
            if (radioButton1.Checked == true)
            {
                Form Formulario= new RegistrarSucursal();
                Formulario.Show();
            }
            
            if (radioButton2.Checked == true)
            {
                Form Formulario = new RegistrarCliente();
                Formulario.Show();
            }

            if (radioButton3.Checked == true)
            {
                Form Formulario = new RegistrarTipoVehiculo();
                Formulario.Show();
            }

            if (radioButton4.Checked == true && Acceso.ObtenerTipoVehiculo().Count == 0)
            {
                MostrarAviso("Se debe registrar tipos de vehículos para usar esta función.");
            }
            else if (radioButton4.Checked == true)
            {
                Form Formulario = new RegistrarVehiculo();
                Formulario.Show();
            }

            if (radioButton5.Checked == true)
            {
                if (Acceso.ObtenerSucursal().Count == 0 || Acceso.ObtenerVehiculo().Count == 0)
                    MostrarAviso("Se debe registrar sucursales y vehículos para usar esta función.");
                else
                {
                    Form Formulario = new RegistrarVehiculoSucursal();
                    Formulario.Show();
                }
            }

            if (radioButton6.Checked == true && Acceso.ObtenerTipoVehiculo().Count==0)
            {
                MostrarAviso("Se debe registrar tipos de vehículos para usar esta función.");
            }
            else if (radioButton6.Checked == true)
            {
                Form Formulario = new RegistrarCobertura();
                Formulario.Show();
            }

            //Parte 2: mostrar los registros.
            if (radioButton7.Checked == true)
            {
                Form Formulario = new ConsultarSucursales();
                Formulario.Show();
            }

            if (radioButton8.Checked == true)
            {
                Form Formulario = new ConsultarClientes();
                Formulario.Show();
            }

            if (radioButton9.Checked == true)
            {
                Form Formulario = new ConsultarTipoVehiculos();
                Formulario.Show();
            }

            if (radioButton10.Checked == true)
            {
                Form Formulario = new ConsultarVehiculos();
                Formulario.Show();
            }

            if (radioButton11.Checked == true)
            {
                Form Formulario = new ConsultarVehiculosSucursal();
                Formulario.Show();
            }

            if (radioButton12.Checked == true)
            {
                Form Formulario = new ConsultarCoberturas();
                Formulario.Show();
            }

            if (radioButton13.Checked == true)
            {
                Acceso.BorrarTodo();

                MostrarAviso("Los datos han sido borrados exitosamente.");
            }
        }

        private void MostrarAviso(String Mensaje)
        {
            MessageBox.Show(Mensaje, "Aviso");
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            Listener = new TcpListener(local, 14100);
            ServidorIniciado = true;

            EscuchaClientes = new Thread(new ThreadStart(Escuchar));
            EscuchaClientes.Start();

            TextoBitacora.Text = "Servidor iniciado.";
            TextoBitacora.AppendText(Environment.NewLine);
        }

        //Inicialización del servidor, donde el cliente empieza a ser escuchado.
        private void Escuchar()
        {
            Listener.Start();
            while (ServidorIniciado)
            {
                TcpClient Cliente = Listener.AcceptTcpClient();

                Thread ClientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente));
                ClientThread.Start(Cliente);
            }
        }
        private void ComunicacionCliente(object Cliente)
        {
            TcpClient TcCliente = (TcpClient)Cliente;
            StreamReader Reader = new StreamReader(TcCliente.GetStream());
            StreamWriter Writer = new StreamWriter(TcCliente.GetStream());

            bool clienteConectado = true; // bandera para indicar si el cliente está conectado

            try
            {
                while (clienteConectado  && ServidorIniciado)
                {
                    try
                    {
                        var Mensaje = Reader.ReadLine();
                        if (Mensaje == null) break; // Si no hay mensaje, desconectar

                        MensajeSocket<object> MensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(Mensaje);
                        SeleccionarMetodo(MensajeRecibido.Metodo, Mensaje, ref Writer);
                    }
                    catch (IOException ex)
                    {
                        // Manejo de excepción por desconexión del cliente
                        Console.WriteLine("El cliente se ha desconectado inesperadamente: " + ex.Message);
                        clienteConectado = false;
                        break; // Salir del bucle para terminar el hilo del cliente
                    }
                    catch (Exception ex)
                    {
                        // Otras excepciones
                        Console.WriteLine("Error: " + ex.Message);
                        break;
                    }
                }
            }
            finally
            {
                // Asegurarse de que la conexión se cierra correctamente cuando se termina el hilo
                Reader.Close();
                Writer.Close();
                TcCliente.Close();
            }
        }

        public void SeleccionarMetodo(String pMetodo, String pMensaje, ref StreamWriter ServidorStreamWriter)
        {
            switch (pMetodo)
            {
                case "Conectar":
                    MensajeSocket<String> MensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<String>>(pMensaje);
                    Conectar(MensajeConectar.Entidad, ref ServidorStreamWriter);
                    break;
                case "Desconectar":
                    MensajeSocket<String> MensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<String>>(pMensaje);
                    Desconectar(MensajeDesconectar.Entidad, ref ServidorStreamWriter);
                    break;
                case "ObtenerSucursalesActivas": 
                    ObtenerSucursalesActivas(ref ServidorStreamWriter);
                    break;
                case "ObtenerVehiculosPorSucursal": 
                    MensajeSocket<int> MensajeVehiculos = JsonConvert.DeserializeObject<MensajeSocket<int>>(pMensaje);
                    ObtenerVehiculosPorSucursal(MensajeVehiculos.Entidad, ref ServidorStreamWriter);
                    break;
                default:
                    break;
            }
        }

        //private void Conectar(String pIdentificacion)
        //{
        //    TextoBitacora.Invoke(ModificarTextoBitacora, new object[] { pIdentificacion + " Se ha conectado."});
        //    ListaUsuarios.Invoke(ModificarTextoClientes, new object[] { pIdentificacion, true});
        //}

        private void Conectar(String pIdentificacion, ref StreamWriter ServidorStreamWriter)
        {
            // Verificar si el cliente existe en la base de datos
            if (Acceso.ClienteExiste(pIdentificacion))
            {
                // Cliente existe, continuar con la conexión
                TextoBitacora.Invoke(ModificarTextoBitacora, new object[] { pIdentificacion + " Se ha conectado." });
                ListaUsuarios.Invoke(ModificarTextoClientes, new object[] { pIdentificacion, true });

                // Enviar confirmación al cliente
                ServidorStreamWriter.WriteLine("Conectado");
                ServidorStreamWriter.Flush();
            }
            else
            {
                // Cliente no existe, denegar la conexión
                ServidorStreamWriter.WriteLine("ClienteNoExiste");
                ServidorStreamWriter.Flush();
            }
        }

        private void Desconectar(String pIdentificacion, ref StreamWriter ServidorStreamWriter)
        {
            // Verificar si el cliente existe en la base de datos
            if (Acceso.ClienteExiste(pIdentificacion))
            {
                // Cliente existe, continuar con la conexión
                TextoBitacora.Invoke(ModificarTextoBitacora, new object[] { pIdentificacion + " Se ha desconectado." });
                ListaUsuarios.Invoke(ModificarTextoClientes, new object[] { pIdentificacion, false });

                // Enviar confirmación al cliente
                ServidorStreamWriter.WriteLine("Conectado");
                ServidorStreamWriter.Flush();
            }
            else
            {
                // Cliente no existe, denegar la conexión
                ServidorStreamWriter.WriteLine("ClienteNoExiste");
                ServidorStreamWriter.Flush();
            }

        }

        private void ObtenerSucursalesActivas(ref StreamWriter ServidorStreamWriter)
        {
            // Usar AccesoSQL para obtener las sucursales activas
            List<Sucursal> sucursalesActivas = Acceso.ObtenerSucursalesActivas();

            // Enviar la lista al cliente
            ServidorStreamWriter.WriteLine(JsonConvert.SerializeObject(sucursalesActivas));
            ServidorStreamWriter.Flush();

            TextoBitacora.Invoke(ModificarTextoBitacora, new object[] { "Se enviaron las sucursales activas al cliente." });
        }

        private void ObtenerVehiculosPorSucursal(int sucursalID, ref StreamWriter ServidorStreamWriter)
        {
            // Usar AccesoSQL para obtener los vehículos de la sucursal
            List<VehiculoSucursal> vehiculos = Acceso.ObtenerVehiculosPorSucursal(sucursalID);

            // Enviar la lista al cliente
            ServidorStreamWriter.WriteLine(JsonConvert.SerializeObject(vehiculos));
            ServidorStreamWriter.Flush();

            TextoBitacora.Invoke(ModificarTextoBitacora, new object[] { "Se enviaron los vehículos de la sucursal al cliente." });
        }

        private void DetenerServidor()
        {
            if (ServidorIniciado)
            {
                // Deja de aceptar nuevos clientes
                ServidorIniciado = false;

                // Detén el listener
                if (Listener != null)
                {
                    Listener.Stop();
                }

                // Asegúrate de que el hilo de escucha termine
                if (EscuchaClientes != null && EscuchaClientes.IsAlive)
                {
                    EscuchaClientes.Join();  // Espera a que el hilo termine
                }
            }
        }

        private void FormClosing(object sender, FormClosingEventArgs e)
        {
            DetenerServidor();  // Asegura que se detiene el servidor y todos los hilos
            Application.Exit(); // Cierra la aplicación de forma forzada
        }
    }
}
