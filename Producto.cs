using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVENTARIODETIENDA
{
    public class Producto
    {
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }
        public int CantidadEnStock { get; set; }

        public Producto(string nombreProducto, double precioProducto, int cantidadEnStock)
        {
            NombreProducto = nombreProducto;
            PrecioProducto = precioProducto;
            CantidadEnStock = cantidadEnStock;
        }

        public string NombredDelProducto()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string nombre;
            Console.Write("Ingresa el nombre del producto: ");
            nombre = Console.ReadLine();
            return nombre;
        }

        public double PrecioDelProducto()
        {
            bool validarPrecio=false;
            double precio=0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ingresa el el precio del producto: Q");
                try
                {
                    precio = Convert.ToDouble(Console.ReadLine());
                    if (precio <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("El precio no puede ser menor o igual a Q0.00");
                        Console.WriteLine();
                    }
                    else
                    {
                        validarPrecio=true;
                    }
                }
                catch (FormatException)
                {
                    MensajeDeError();
                }
            } while (validarPrecio == false);
            return precio;
        }
        public int CantidadStock()
        {
            int cantidadProductos = 0;
            bool validarStock = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ingrese la cantidad de existencias: ");
                try
                {
                    cantidadProductos = Convert.ToInt32(Console.ReadLine());
                    if (cantidadProductos <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("La cantidad no puede ser menor o igual a 0.");
                        Console.WriteLine();
                    }
                    else
                    {
                        validarStock = true;
                    }
                }
                catch (FormatException)
                {
                    MensajeDeError();
                }
            } while (validarStock == false);
            
            return cantidadProductos;
        }
        public void MensajeDeError()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error de formato");
            Console.WriteLine(); Console.ResetColor();
        }
        public void MensajeParaContinuar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Pulsa cualquier tecla para continuar...");
            Console.ResetColor(); Console.ReadKey(); Console.Clear();
        }


    }
}
