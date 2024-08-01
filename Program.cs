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
            Console.WriteLine("-------------------------");
            Console.WriteLine("        TIENDA"); 
            Console.WriteLine("-------------------------"); Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("Opción 1: Agregar producto.");
            Console.WriteLine("Opción 2: Mostrar datos.");
            Console.WriteLine("Opción 3: Vender producto.");
            Console.WriteLine("Opción 4. Reabastecer producto.");
            Console.WriteLine("Opción 5: Actualizar precio.");
            Console.WriteLine("Opción 6: Resumen del producto.");
            Console.WriteLine("Opción 7: Nuevo producto.");
            Console.WriteLine("Opción 8: Salir.");
            Console.WriteLine(); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Elija la opción que desea: ");
            try
            {
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("  AGREGAR PRODUCTO");
                        Console.WriteLine("--------------------");
                        nombreProducto = producto.NombredDelProducto();
                        precioProducto = producto.PrecioDelProducto();
                        cantidadEnStock = producto.CantidadStock();
                        producto.MensajeParaContinuar();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("  DATOS DEL PRODUCTO");
                        Console.WriteLine("-----------------------");
                        producto.MostrarDatos(nombreProducto, precioProducto, cantidadEnStock);
                        producto.MensajeParaContinuar();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("--------------------");
                        Console.WriteLine("  VENDER PRODUCTO");
                        Console.WriteLine("--------------------");
                        cantidadEnStock = producto.VenderProducto(cantidadEnStock);
                        producto.MensajeParaContinuar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("  REABASTECER PRODUCTO");
                        Console.WriteLine("-------------------------");
                        cantidadEnStock = producto.ReabastecerProducto(cantidadEnStock);
                        producto.MensajeParaContinuar();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("    ACTUALIZAR PRECIO");
                        Console.WriteLine("-------------------------");
                        precioProducto = producto.ActualizarPrecio(precioProducto);
                        producto.MensajeParaContinuar();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("   RESUMEN DEL PRODUCTO");
                        Console.WriteLine("---------------------------");
                        producto.ResumenProducto(nombreProducto, precioProducto, cantidadEnStock);
                        producto.MensajeParaContinuar();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("      NUEVO PRODUCTO");
                        Console.WriteLine("---------------------------");
                        nombreProducto = producto.NombredDelProducto();
                        precioProducto = producto.PrecioDelProducto();
                        cantidadEnStock = producto.CantidadStock();
                        producto.MensajeParaContinuar();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine("   Adiós. Ten un buen día."); Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("------------------------------");
                        break;
                    default:
                        Console.ForegroundColor= ConsoleColor.DarkRed;
                        Console.WriteLine("Esta opción no existe");
                        producto.MensajeParaContinuar();
                        break;
                }

            }catch(FormatException)
            {
                producto.MensajeDeError();
                producto.MensajeParaContinuar();
            }
            Console.ResetColor();
        } while (opcion != 8);
    }
}
