using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Conventas
{
    class Program
    {
        //Rudeyli Lorenzo 15-MISN-1-016
        //Dary Peralta 13-EIST-1-139

        public static void Main(string[] args)
        {
            //declarar las variables
            decimal precio = 0, itbis = 18;
            string descripcion;
            double Codigo;
            int item = 0;
            decimal total = 0, subtotal = 0, Totalimp = 0;
            //Las aplicaciones son interesantes Rudeyli Lorenzo 15-misn-1-016 seccion: 09808
            //El proyecto ayudo a conocer codigos Dary Peralta 13-eist-1-139
            Console.WriteLine("CANTIDAD DE ARTICULOS A FACTURAR");
            item = int.Parse(Console.ReadLine());

            for (int I = 0; I <= item; I++)
            {
                Console.WriteLine("Ingresar Codigo Mercancia?");
                Codigo = double.Parse(Console.ReadLine());
                
                if (Codigo == 0001)
                {
                    descripcion = "ZAPATOS ALTO P/DAMA PASARELA";
                    precio = 1500;

                }
                else if (Codigo == 0002)
                {
                    descripcion = "TENIS NIKE PEGASUS P/HOMBRE";
                }
                else
                {
                    Console.WriteLine("Ingrese un Codigo De Producto");
                    Codigo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la Descripcion Del Producto");
                    descripcion = Console.ReadLine();
                    Console.WriteLine("Ingrese un Precio De Producto");
                    precio = decimal.Parse(Console.ReadLine());
                }
                Console.WriteLine("Codigo Articulo" + " " + Codigo);
                Console.WriteLine("Descripcion Articulo" + " " + descripcion);
                Console.WriteLine("Precio Articulo" + " " + precio);
                subtotal = subtotal + precio;
            }

            Totalimp = (subtotal * itbis) / 100;
            subtotal = Totalimp + precio;
            total = subtotal + total;
          
            Console.WriteLine("Total Impuesto es" + " " + Totalimp);
            Console.WriteLine("Total Impuesto es" + " " + Totalimp);
            Console.WriteLine("SubTotal es" + " " + subtotal);
            Console.WriteLine("Total A Pagar es" + " " + total);
            Console.WriteLine("Rudeyli Lorenzo 15-MISN-1-016");
            Console.WriteLine("Dary Peralta 13-EIST-1-139");

            Console.ReadKey();

        }
    }
}
