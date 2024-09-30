using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRentaUned
{
    public class ValorNoValido : Exception
    {
        public ValorNoValido(String mensaje) : base("Error: " + mensaje)
        {
        }
    }
}
