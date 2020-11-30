using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Compras
    {
        
        string nombre;
        int idProducto;
        double precio;
        public int cantidad;
        
        Compras()
        {
            this.precio = -1;
            this.nombre = "";
            this.idProducto = -1;

        }
        public Compras(string nombre,int idProducto,double precio,int cantidad):this()
        {
            this.precio = precio;
            this.nombre = nombre;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public int IdProducto
        {
            get
            {
                return this.idProducto;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
        }
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }
        
      

    }
}
