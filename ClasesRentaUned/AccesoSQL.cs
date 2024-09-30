//En AccesoSQL, se maneja el envío de datos de AplicacionServidor a la base de datos SQL.

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRentaUned
{
    public class AccesoSQL
    {
        private string CadenaConexion;

        public AccesoSQL()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["ScriptSQL"].ConnectionString;
        }

        public String GetCadenaConexion()
        {
            return CadenaConexion;
        }

        public void AgregarSucursal(Sucursal sucursal)
        {
            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sql;

            Conexion = new SqlConnection(CadenaConexion);
            Sql = "INSERT INTO SUCURSAL(idSucursal, Nombre, Direccion, Estado, Telefono)" +
                " VALUES (@idSucursal, @Nombre, @Direccion, @Estado, @Telefono)";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            cmd.Connection= Conexion;
            cmd.Parameters.AddWithValue("@idSucursal", sucursal.ID);
            cmd.Parameters.AddWithValue("@Nombre", sucursal.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", sucursal.Direccion);
            cmd.Parameters.AddWithValue("@Estado", sucursal.Estado);
            cmd.Parameters.AddWithValue("@Telefono", sucursal.Telefono);

            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void AgregarCliente(Cliente cliente)
        {
            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sql;

            Conexion = new SqlConnection(CadenaConexion);
            Sql = "INSERT INTO CLIENTE(idCliente, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero)" +
                " VALUES (@idCliente, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Genero)";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            cmd.Connection = Conexion;
            cmd.Parameters.AddWithValue("@idCliente", cliente.ID);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@PrimerApellido", cliente.ApellidoUno);
            cmd.Parameters.AddWithValue("@SegundoApellido", cliente.ApellidoDos);
            cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Genero", cliente.Genero);

            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void AgregarTipoVehiculo(TipoVehiculo tipoVehiculo)
        {
            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sql;

            Conexion = new SqlConnection(CadenaConexion);
            Sql = "INSERT INTO TIPOVEHICULO(idTipo, Descripcion, Estado)" +
                " VALUES (@idTipo, @Descripcion, @Estado)";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            cmd.Connection = Conexion;
            cmd.Parameters.AddWithValue("@idTipo", tipoVehiculo.ID);
            cmd.Parameters.AddWithValue("@Descripcion", tipoVehiculo.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", tipoVehiculo.Estado);

            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sql;

            Conexion = new SqlConnection(CadenaConexion);
            Sql = "INSERT INTO VEHICULO(idPlaca, Marca, Modelo, IdTipoVehiculo, CostoAlquilerDia, Kilometraje)" +
                " VALUES (@idPlaca, @Marca, @Modelo, @IdTipoVehiculo, @CostoAlquilerDia, @Kilometraje)";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            cmd.Connection = Conexion;
            cmd.Parameters.AddWithValue("@idPlaca", vehiculo.Placa);
            cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
            cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
            cmd.Parameters.AddWithValue("@IdTipoVehiculo", vehiculo.IDTipo);
            cmd.Parameters.AddWithValue("@CostoAlquilerDia", vehiculo.CostoAlquilerDia);
            cmd.Parameters.AddWithValue("@Kilometraje", vehiculo.Kilometraje);

            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void AgregarVehiculoSucursal(VehiculoSucursal vehiculoSucursal)
        {
            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sql;

            Conexion = new SqlConnection(CadenaConexion);
            Sql = "INSERT INTO VEHICULOSUCURSAL(IdAsignacion, IdSucursal, IdPlaca, FechaAsignacion)" +
                " VALUES (@IdAsignacion, @IdSucursal, @IdPlaca, @FechaAsignacion)";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            cmd.Connection = Conexion;
            cmd.Parameters.AddWithValue("@IdAsignacion", vehiculoSucursal.IDAsignacion);
            cmd.Parameters.AddWithValue("@IdSucursal", vehiculoSucursal.sucursal);
            cmd.Parameters.AddWithValue("@IdPlaca", vehiculoSucursal.PlacaVehiculo);
            cmd.Parameters.AddWithValue("@FechaAsignacion", vehiculoSucursal.Fecha);

            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void AgregarCobertura(Cobertura cobertura)
        {
            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sql;

            Conexion = new SqlConnection(CadenaConexion);
            Sql = "INSERT INTO COBERTURASEGURO(IdCobertura, Descripcion, IdTipoVehiculo, Estado, Monto)" +
                " VALUES (@IdCobertura, @Descripcion, @IdTipoVehiculo, @Estado, @Monto)";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            cmd.Connection = Conexion;
            cmd.Parameters.AddWithValue("@IdCobertura", cobertura.ID);
            cmd.Parameters.AddWithValue("@Descripcion", cobertura.Descripcion);
            cmd.Parameters.AddWithValue("@IdTipoVehiculo", cobertura.Tipo);
            cmd.Parameters.AddWithValue("@Estado", cobertura.Estado);
            cmd.Parameters.AddWithValue("@Monto", cobertura.Monto);

            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public List<Sucursal> ObtenerSucursal()
        {
            List<Sucursal> Lista = new List<Sucursal>();

            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sentencia;
            SqlDataReader Lector;

            Conexion = new SqlConnection(GetCadenaConexion());

            Sentencia = "SELECT IdSucursal as ID, Nombre, Direccion as Dirección, Estado, Telefono as Teléfono FROM SUCURSAL";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sentencia;
            cmd.Connection = Conexion;

            Conexion.Open();

            Lector = cmd.ExecuteReader();

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Lista.Add(new Sucursal
                    {
                        ID = Lector.GetInt32(0),
                        Nombre = Lector.GetString(1),
                        Direccion = Lector.GetString(2),
                        Estado = Lector.GetBoolean(3),
                        Telefono = Lector.GetString(4)
                    });
                }
            }

            Conexion.Close();

            return Lista;
        }

        public List<Sucursal> ObtenerSucursalesActivas()
        {
            List<Sucursal> Lista = new List<Sucursal>();

            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sentencia;
            SqlDataReader Lector;

            // Establecer la conexión a la base de datos
            Conexion = new SqlConnection(GetCadenaConexion());

            // Modificar la consulta SQL para obtener solo sucursales activas
            Sentencia = "SELECT IdSucursal as ID, Nombre, Direccion as Dirección, Estado, Telefono as Teléfono FROM SUCURSAL WHERE Estado = 1";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sentencia;
            cmd.Connection = Conexion;

            // Abrir la conexión
            Conexion.Open();

            // Ejecutar la consulta
            Lector = cmd.ExecuteReader();

            // Leer los resultados
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Lista.Add(new Sucursal
                    {
                        ID = Lector.GetInt32(0),
                        Nombre = Lector.GetString(1),
                        Direccion = Lector.GetString(2),
                        Estado = Lector.GetBoolean(3),
                        Telefono = Lector.GetString(4)
                    });
                }
            }

            // Cerrar la conexión
            Conexion.Close();

            return Lista;
        }

        public List<Cliente> ObtenerCliente()
        {
            List<Cliente> Lista = new List<Cliente>();

            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sentencia;
            SqlDataReader Lector;

            Conexion = new SqlConnection(GetCadenaConexion());

            Sentencia = "SELECT IdCliente as ID, Nombre, PrimerApellido as ApellidoUno, SegundoApellido as ApellidoDos, FechaNacimiento, Genero from Cliente";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sentencia;
            cmd.Connection = Conexion;

            Conexion.Open();

            Lector = cmd.ExecuteReader();

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Lista.Add(new Cliente
                    {
                        ID = Lector.GetString(0),
                        Nombre = Lector.GetString(1),
                        ApellidoUno = Lector.GetString(2),
                        ApellidoDos = Lector.GetString(3),
                        FechaNacimiento = Lector.GetDateTime(4),
                        Genero = char.Parse(Lector.GetString(5))
                    });
                }
            }

            Conexion.Close();

            return Lista;
        }

        public List<TipoVehiculo> ObtenerTipoVehiculo()
        {
            List<TipoVehiculo> Lista = new List<TipoVehiculo>();

            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sentencia;
            SqlDataReader Lector;

            Conexion = new SqlConnection(GetCadenaConexion());

            Sentencia = "SELECT idTipo AS ID, Descripcion as Descripción, Estado FROM TIPOVEHICULO";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sentencia;
            cmd.Connection = Conexion;

            Conexion.Open();

            Lector = cmd.ExecuteReader();

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Lista.Add(new TipoVehiculo
                    {
                        ID = Lector.GetInt32(0).ToString(),
                        Descripcion = Lector.GetString(1),
                        Estado = Lector.GetBoolean(2)
                    });
                }
            }

            Conexion.Close();

            return Lista;
        }

        public List<Vehiculo> ObtenerVehiculo()
        {
            List<Vehiculo> Lista = new List<Vehiculo>();

            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sentencia;
            SqlDataReader Lector;

            Conexion = new SqlConnection(GetCadenaConexion());

            Sentencia = "SELECT IdPlaca as Placa, Marca, Modelo, IdTipoVehiculo as IDTipo, CostoAlquilerDia, Kilometraje FROM VEHICULO";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sentencia;
            cmd.Connection = Conexion;

            Conexion.Open();

            Lector = cmd.ExecuteReader();

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Lista.Add(new Vehiculo
                    {
                        Placa = Lector.GetString(0),
                        Marca = Lector.GetString(1),
                        Modelo = Lector.GetString(2),
                        IDTipo = Lector.GetInt32(3),
                        CostoAlquilerDia = Lector.GetInt32(4),
                        Kilometraje = Lector.GetInt32(5)
                    });
                }
            }

            Conexion.Close();

            return Lista;
        }

        public List<VehiculoSucursalDatosTotales> ObtenerVehiculoSucursal()
        {
            List<VehiculoSucursalDatosTotales> Lista = new List<VehiculoSucursalDatosTotales>();

            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sentencia;
            SqlDataReader Lector;

            Conexion = new SqlConnection(GetCadenaConexion());

            Sentencia = "select A.IdAsignacion, A.FechaAsignacion, B.IdSucursal, B.Nombre, B.Direccion, C.IdPlaca, C.Marca, C.Modelo from VehiculoSucursal A join Sucursal B on A.IdSucursal = B.IdSucursal join Vehiculo C on A.IdPlaca = C.IdPlaca";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sentencia;
            cmd.Connection = Conexion;

            Conexion.Open();

            Lector = cmd.ExecuteReader();

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Lista.Add(new VehiculoSucursalDatosTotales
                    {
                        IDAsignacion = Lector.GetInt32(0),
                        Fecha = Lector.GetDateTime(1),
                        IDSucursal = Lector.GetInt32(2),
                        NombreSucursal = Lector.GetString(3),
                        DireccionSucursal = Lector.GetString(4),
                        PlacaVehiculo = Lector.GetString(5),
                        MarcaVehiculo = Lector.GetString(6),
                        ModeloVehiculo = Lector.GetString(7),
                    });
                }
            }

            Conexion.Close();

            return Lista;
        }

        public List<VehiculoSucursal> ObtenerVehiculosPorSucursal(int sucursalID)
        {
            List<VehiculoSucursal> Lista = new List<VehiculoSucursal>();

            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sentencia;
            SqlDataReader Lector;

            Conexion = new SqlConnection(GetCadenaConexion());

            Sentencia = "SELECT IdAsignacion as ID, IdPlaca as Placa, FechaAsignacion FROM VehiculoSucursal WHERE IdSucursal = @sucursalID";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sentencia;
            cmd.Connection = Conexion;
            cmd.Parameters.AddWithValue("@sucursalID", sucursalID);

            Conexion.Open();
            Lector = cmd.ExecuteReader();

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Lista.Add(new VehiculoSucursal
                    {
                        IDAsignacion = Lector.GetInt32(0),
                        sucursal = Lector.GetInt32(1),
                        PlacaVehiculo = Lector.GetString(2),
                        Fecha = Lector.GetDateTime(3),
                    });
                }
            }

            Conexion.Close();

            return Lista;
        }

        public List<Cobertura> ObtenerCobertura()
        {
            List<Cobertura> Lista = new List<Cobertura>();

            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sentencia;
            SqlDataReader Lector;

            Conexion = new SqlConnection(GetCadenaConexion());

            Sentencia = "SELECT IdCobertura as ID, Descripcion, IdTipoVehiculo as IDTipo, Estado, Monto FROM COBERTURASEGURO";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sentencia;
            cmd.Connection = Conexion;

            Conexion.Open();

            Lector = cmd.ExecuteReader();

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    Lista.Add(new Cobertura
                    {
                        ID = Lector.GetInt32(0).ToString(),
                        Descripcion = Lector.GetString(1),
                        Tipo = Lector.GetInt32(2),
                        Estado = Lector.GetBoolean(3),
                        Monto = Lector.GetInt32(4)
                    });
                }
            }

            Conexion.Close();

            return Lista;
        }

        public bool ClienteExiste(string Identificacion)
        {
            bool Confirm = false;
            List<Cliente> Lista = new List<Cliente>();
            Lista = ObtenerCliente();

            foreach (Cliente cliente in Lista)
            {
                if (cliente.ID == Identificacion)
                {
                    Confirm = true;
                }
            }
            return Confirm;
        }

        public void BorrarTodo()
        {
            SqlConnection Conexion;
            SqlCommand cmd = new SqlCommand();
            String Sql;

            Conexion = new SqlConnection(CadenaConexion);
            Sql = "delete from VehiculoSucursal; delete from Vehiculo; delete from CoberturaSeguro; delete from Sucursal; delete from Cliente; delete from TipoVehiculo; delete from VehiculoSucursal;";

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql;
            cmd.Connection = Conexion;

            Conexion.Open();
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}