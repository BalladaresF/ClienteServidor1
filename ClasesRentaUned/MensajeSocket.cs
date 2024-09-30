using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRentaUned
{
    [Serializable]
    public class MensajeSocket<T>
    {
        public String Metodo { get; set; }
        public T Entidad { get; set; }
    }
}
