using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRentaUned
{
    public class AccesoTCP
    {
        private static IPAddress IPServidor;
        private static TcpClient Cliente;
        private static IPEndPoint ServerEndPoint;
        private static StreamWriter ClienteStreamWriter;
        private static StreamReader ClienteStreamReader;

        public static bool Conectar(String Identificacion)
        {
            try
            {
                if (Cliente == null || !Cliente.Connected)
                {
                    IPServidor = IPAddress.Parse("127.0.0.1");
                    Cliente = new TcpClient();
                    ServerEndPoint = new IPEndPoint(IPServidor, 14100);
                    Cliente.Connect(ServerEndPoint);
                    ClienteStreamWriter = new StreamWriter(Cliente.GetStream());
                    ClienteStreamReader = new StreamReader(Cliente.GetStream());
                }

                // Enviar mensaje de conexión con la identificación
                MensajeSocket<String> MensajeConectar = new MensajeSocket<string> { Metodo = "Conectar", Entidad = Identificacion };
                ClienteStreamWriter.WriteLine(JsonConvert.SerializeObject(MensajeConectar));
                ClienteStreamWriter.Flush();

                // Leer la respuesta del servidor
                string respuesta = ClienteStreamReader.ReadLine();

                // Si la identificación no existe, denegar la conexión
                if (respuesta == "ClienteNoExiste")
                {
                    throw new ValorNoValido("El cliente no existe.");
                }
                else if (respuesta == "Conectado")
                {
                    return true;  // Conexión exitosa
                }
                else
                {
                    return false;  // Ocurrió un error no esperado
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar: {ex.Message}");
                return false;
            }
        }

        public static bool Desconectar(String Identificacion)
        {
            try
            {
                if (Cliente == null || !Cliente.Connected)
                {
                    throw new InvalidOperationException("El cliente no está conectado.");
                }

                // Mensaje de desconexión
                MensajeSocket<String> MensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Entidad = Identificacion };

                // Enviar el mensaje al servidor
                ClienteStreamWriter.WriteLine(JsonConvert.SerializeObject(MensajeDesconectar));
                ClienteStreamWriter.Flush();

                // Esperar respuesta del servidor
                string respuesta = ClienteStreamReader.ReadLine();
                if (respuesta == "Desconectado")
                {
                    ClienteStreamWriter.Close();
                    ClienteStreamReader.Close();
                    Cliente.Close(); // Cerrar el cliente TCP
                    Cliente = null;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al desconectar: {ex.Message}");
                return false;
            }
        }

        public static List<Sucursal> ObtenerSucursalesActivas()
        {
            try
            {
                IPServidor = IPAddress.Parse("127.0.0.1");
                Cliente = new TcpClient();
                ServerEndPoint = new IPEndPoint(IPServidor, 14100);
                Cliente.Connect(ServerEndPoint);

                // Crear mensaje de solicitud
                MensajeSocket<String> MensajeSucursales = new MensajeSocket<string>
                {
                    Metodo = "ObtenerSucursalesActivas",
                    Entidad = null
                };

                // Enviar la solicitud al servidor
                ClienteStreamWriter = new StreamWriter(Cliente.GetStream());
                ClienteStreamReader = new StreamReader(Cliente.GetStream());
                ClienteStreamWriter.WriteLine(JsonConvert.SerializeObject(MensajeSucursales));
                ClienteStreamWriter.Flush();

                // Recibir respuesta del servidor
                var respuestaServidor = ClienteStreamReader.ReadLine();
                List<Sucursal> sucursalesActivas = JsonConvert.DeserializeObject<List<Sucursal>>(respuestaServidor);

                return sucursalesActivas;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener sucursales activas: " + ex.Message);
                return new List<Sucursal>();
            }
        }

        public static List<VehiculoSucursal> ObtenerVehiculosPorSucursal(int sucursalID)
        {
            try
            {
                IPServidor = IPAddress.Parse("127.0.0.1");
                Cliente = new TcpClient();
                ServerEndPoint = new IPEndPoint(IPServidor, 14100);
                Cliente.Connect(ServerEndPoint);

                // Crear mensaje de solicitud
                MensajeSocket<int> MensajeVehiculos = new MensajeSocket<int>
                {
                    Metodo = "ObtenerVehiculosPorSucursal",
                    Entidad = sucursalID
                };

                // Enviar la solicitud al servidor
                ClienteStreamWriter = new StreamWriter(Cliente.GetStream());
                ClienteStreamReader = new StreamReader(Cliente.GetStream());
                ClienteStreamWriter.WriteLine(JsonConvert.SerializeObject(MensajeVehiculos));
                ClienteStreamWriter.Flush();

                // Recibir respuesta del servidor
                var respuestaServidor = ClienteStreamReader.ReadLine();
                List<VehiculoSucursal> vehiculos = JsonConvert.DeserializeObject<List<VehiculoSucursal>>(respuestaServidor);

                return vehiculos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener vehículos: " + ex.Message);
                return new List<VehiculoSucursal>();
            }
        }
    }
}
