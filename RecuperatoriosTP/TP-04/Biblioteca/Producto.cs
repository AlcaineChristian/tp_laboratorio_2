using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public class Producto
    {
        ETipo tipo;
        int idProducto;
        double precio;
        int stock;
        string nombre;
        public enum ETipo
        {
            alimento,
            limpieza,
            lacteos,
            higienePersonal,
            bebidas
        }
        Producto()
        {
            this.idProducto = -1;
            this.precio = -1;
            this.stock = -1;
            this.nombre = "";
        }
        public Producto(string nombre, int idProducto, double precio, int stock, ETipo tipo) : this()
        {
            this.idProducto = idProducto;
            this.precio = precio;
            this.stock = stock;
            this.tipo = tipo;
            this.nombre = nombre;
        }
        public ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int IdProducto
        {
            get
            {
                return this.idProducto;
            }
            set
            {
                this.idProducto = value;
            }
        }
        public double Precio
        {
            set
            {
                this.precio = value;
            }
            get
            {
                return this.precio;
            }
        }
        public int Stock
        {
            set
            {
                this.stock = value;
            }
            get
            {
                return this.stock;
            }

        }
        public static bool operator ==(List<Producto> listaProductos, Producto auxProducto)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].idProducto == auxProducto.idProducto)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(List<Producto> listaProductos, Producto auxProducto)
        {
            return !(listaProductos == auxProducto);
        }

        public static bool operator +(List<Producto> listaProductos, Producto auxProducto)
        {
            bool retorno = false;

            if (listaProductos != auxProducto)
            {
                listaProductos.Add(auxProducto);
                retorno = true;

            }
            else
            {
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    if (listaProductos[i].idProducto == auxProducto.idProducto)
                    {
                        MessageBox.Show("Id ya cargado");
                        if (listaProductos[i].Nombre == auxProducto.Nombre)
                        {
                            if (listaProductos[i].Stock != auxProducto.Stock)
                            {
                                listaProductos[i].Stock = auxProducto.Stock;
                                MessageBox.Show("Stock actualizado");
                            }
                            if (listaProductos[i].Precio != auxProducto.Precio)
                            {
                                listaProductos[i].precio = auxProducto.Precio;
                                MessageBox.Show("Precio actualizado");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Producto no coincide con el id ya cargado. Revise y vuelva a intentar");
                        }
                    }
                }
            }

            return retorno;
        }


    }
}
