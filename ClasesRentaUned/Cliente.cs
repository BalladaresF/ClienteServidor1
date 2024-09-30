using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRentaUned
{
    public class Cliente
    {
        public String ID { get; set; }
        public String Nombre { get; set; }
        public String ApellidoUno { get; set; }
        public String ApellidoDos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char Genero { get; set; }
    }
}
