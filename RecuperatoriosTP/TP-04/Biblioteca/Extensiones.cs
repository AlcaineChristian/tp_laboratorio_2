using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public static class Extensiones
    {
        public static double MontoTotalVentas(List<Ventas> listaVentas)
        {
            double montoTotal = 0;

            for(int i=0;i<listaVentas.Count();i++)
            {
                montoTotal = montoTotal + listaVentas[i].PrecioTotal;
            }

            return montoTotal;
        }
    }
}
