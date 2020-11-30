using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Biblioteca;


namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Alcaine.Tomas.2D";
            Producto p1 = new Producto("Cacao", 150, 10.50, 10, Producto.ETipo.alimento);
            Producto p2 = new Producto("Nesquik", 151, 10.50, 10, Producto.ETipo.alimento);
            Producto p3 = new Producto("Zucoa", 152, 10.50, 10, Producto.ETipo.alimento);
            Ventas venta = new Ventas();
            Thread hilo1 = new Thread(Hardcodeo.Vendedor1);
            List<Producto> listaTestProducto = new List<Producto>();

            Console.WriteLine("\nSe cargar productos");
            Console.WriteLine();

            if (listaTestProducto + p1)
                Console.WriteLine("Cargado con exito");
            if (listaTestProducto + p2)
                Console.WriteLine("Cargado con exito");
            if (listaTestProducto + p3)
                Console.WriteLine("Cargado con exito");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nSe generan ventas desde el hilo");
            Console.WriteLine();
            hilo1.Start();


            Console.WriteLine("\nSe genera el ticket de las ventas ");
            Console.WriteLine();
            if (Ventas.GuardarXml(new Ventas(200, 5)))
                Console.WriteLine("Ticket guardado");





        }
    }
}

