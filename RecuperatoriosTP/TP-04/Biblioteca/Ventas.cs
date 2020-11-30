using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Biblioteca
{
    public class Ventas
    {


        double precioTotal;
        int idVenta;


        public Ventas()
        {

        }
        public Ventas(double precioTotal, int idVenta)
        {
            this.precioTotal = precioTotal;
            this.idVenta = idVenta;
        }



        public double PrecioTotal
        {
            get
            {
                return this.precioTotal;
            }
            set
            {
                this.precioTotal = value;
            }
        }
        public int IdVenta
        {
            get
            {
                return this.idVenta;
            }
            set
            {
                this.idVenta = value;
            }
        }
        public static bool PrintTicket(List<Ventas> venta)
        {
            bool retorno = false;
            string path;
            string textoAGuardar = "";

            if (venta != null)
            {
                path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Ventas del dia");
                for (int i = 0; i < venta.Count; i++)
                {
                    textoAGuardar = String.Concat(textoAGuardar, venta[i].ToString());
                }
                Texto texto = new Texto();
                textoAGuardar = String.Concat(textoAGuardar, "Monto total del dia= ");
                textoAGuardar = String.Concat(textoAGuardar, Extensiones.MontoTotalVentas(venta).ToString());
                texto.Guardar(path, textoAGuardar);
                retorno = true;
            }

            return retorno;
        }

        public static bool GuardarXml(Ventas venta)
        {
            bool ret = false;
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Ticket");
            path = String.Concat(path, venta.IdVenta.ToString());
            path = String.Concat(path, ".xml");
            Xml<Ventas> auxVentas = new Archivos.Xml<Ventas>();
            auxVentas.Guardar(path, venta);
            ret = true;
            return ret;


        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NroVenta: {this.idVenta.ToString()}");
            sb.AppendLine($"Monto: {this.precioTotal.ToString()}");
            sb.AppendLine("");
            sb.AppendLine("----------------------------------------");
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}




