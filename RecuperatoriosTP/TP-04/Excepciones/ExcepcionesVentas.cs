using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionesVentas : Exception
    {
        public ExcepcionesVentas(string message) : base(message)
        {

        }
    }
}
