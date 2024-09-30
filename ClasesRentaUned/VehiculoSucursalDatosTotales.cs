using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRentaUned
{
    //Esta clase se ha creado para retornar todos los datos de VehiculoSucursal, de la base de datos SQL.
    public class VehiculoSucursalDatosTotales
    {
        //Datos del registro de vehículo por sucursal:
        public int IDAsignacion { get; set; }
        public DateTime? Fecha { get; set; }

        //Datos de la sucursal:
        public int IDSucursal { get; set; }
        public String NombreSucursal { get; set; }
        public String DireccionSucursal { get; set; }

        //Datos del vehículo:
        public String PlacaVehiculo { get; set; }
        public String MarcaVehiculo { get; set; }
        public String ModeloVehiculo { get; set; }
    }
}
