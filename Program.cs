using INVENTARIODETIENDA;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        string nombreProducto ="";
        double precioProducto=0;
        int cantidadEnStock=0;
        Producto producto = new Producto(nombreProducto, precioProducto, cantidadEnStock);
        do
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        TIENDA"); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("Opción 1: Agregar producto.");
            Console.WriteLine("Opción 2: Mostrar datos.");
            Console.WriteLine("Opción 3: Vender producto.");
            Console.WriteLine("Opción 4. Reabastecer producto.");
            Console.WriteLine("Opción 5: Actualizar precio.");
            Console.WriteLine("Opción 6: Agregar nuevo producto.");
            Console.WriteLine("Opción 7: Salir.");
            Console.WriteLine(); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Elija la opción que desea: ");
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }

            }catch(FormatException)
            {
                producto.MensajeDeError();
            }
            Console.ResetColor();
        } while (opcion != 7);
    }
}
