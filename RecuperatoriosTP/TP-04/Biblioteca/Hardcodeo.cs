using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Hardcodeo
    {
        public static List<Producto> listaProductos = new List<Producto>();
        public static List<Ventas> listaVentas = new List<Ventas>();

        public static void Productos()
        {

            listaProductos.Add(new Producto("Leche", 1, 25, 10, Producto.ETipo.lacteos));
            listaProductos.Add(new Producto("Queso", 2, 30, 15, Producto.ETipo.lacteos));
            listaProductos.Add(new Producto("Yogurt", 3, 35, 5, Producto.ETipo.lacteos));
            listaProductos.Add(new Producto("Crema", 4, 50, 20, Producto.ETipo.lacteos));
            listaProductos.Add(new Producto("Queso untable", 5, 40, 10, Producto.ETipo.lacteos));
            listaProductos.Add(new Producto("Azucar", 6, 25, 10, Producto.ETipo.alimento));
            listaProductos.Add(new Producto("Yerba", 7, 30, 15, Producto.ETipo.alimento));
            listaProductos.Add(new Producto("Chocolate", 8, 35, 5, Producto.ETipo.alimento));
            listaProductos.Add(new Producto("Galletitas", 9, 50, 20, Producto.ETipo.alimento));
            listaProductos.Add(new Producto("Pan lactal", 10, 40, 10, Producto.ETipo.alimento));
            listaProductos.Add(new Producto("Miel", 11, 25, 10, Producto.ETipo.alimento));
            listaProductos.Add(new Producto("Cereales", 12, 30, 15, Producto.ETipo.alimento));
            listaProductos.Add(new Producto("Fideos", 13, 35, 5, Producto.ETipo.alimento));


        }

        public static void Ventas()
        {

            ManejadorSQL.InstertarVenta(new Ventas(100, 1));
            ManejadorSQL.InstertarVenta(new Ventas(100, 2));
            ManejadorSQL.InstertarVenta(new Ventas(150, 3));
            ManejadorSQL.InstertarVenta(new Ventas(50, 4));
            ManejadorSQL.InstertarVenta(new Ventas(150, 5));
            ManejadorSQL.InstertarVenta(new Ventas(100, 6));
            ManejadorSQL.InstertarVenta(new Ventas(150, 7));
            ManejadorSQL.InstertarVenta(new Ventas(100, 8));
            ManejadorSQL.InstertarVenta(new Ventas(50, 9));
            ManejadorSQL.InstertarVenta(new Ventas(50, 10));
            ManejadorSQL.InstertarVenta(new Ventas(150, 11));
            ManejadorSQL.InstertarVenta(new Ventas(50, 12));
            ManejadorSQL.InstertarVenta(new Ventas(150, 13));
            listaVentas = ManejadorSQL.ListarVentas();
        }


        public static bool ValidarCantidad(string nombre, int auxCantidad)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Nombre == nombre && listaProductos[i].Stock >= auxCantidad)
                {
                    return true;
                }
            }

            return false;
        }
        public static void Vendedor1()
        {

            List<Ventas> listaTestVentas1 = new List<Ventas>();
            listaTestVentas1.Add(new Biblioteca.Ventas(100, 1));
            Thread.Sleep(1000);
            listaTestVentas1.Add(new Biblioteca.Ventas(100, 2));
            Thread.Sleep(1000);
            listaTestVentas1.Add(new Biblioteca.Ventas(100, 3));
            Thread.Sleep(1000);
            listaTestVentas1.Add(new Biblioteca.Ventas(100, 4));
            Thread.Sleep(1000);
            listaTestVentas1.Add(new Biblioteca.Ventas(100, 5));
            Thread.Sleep(1000);


        }


    }
}
