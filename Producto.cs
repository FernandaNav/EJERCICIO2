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
            Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine();
            Console.Write("Pulsa cualquier tecla para continuar...");
            Console.ResetColor(); Console.ReadKey(); Console.Clear();
        }

        public void MostrarDatos(string NombreProducto, double precioProducto, int cantidadProducto)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine();
            Console.WriteLine($"Nombre: {NombreProducto}");
            Console.WriteLine($"Precio: {precioProducto}");
            Console.WriteLine($"Cantidad en Stock: {cantidadProducto}");
        }

        public int VenderProducto(int cantidadProducto)
        {
            int cantidadDeVenta;
            bool validarCantidad = false;
            if (cantidadProducto == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No existen productos en stock.");
            }
            else
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ingresa la cantidad de productos que quieras vender: ");
                    try
                    {
                        cantidadDeVenta = Convert.ToInt32(Console.ReadLine());
                        if (cantidadDeVenta <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("La cantidad no puede ser menor o igual a 0.");
                            Console.WriteLine();
                        }
                        else if (cantidadDeVenta > cantidadProducto)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("No hay suficientes existencias.");
                            Console.WriteLine();
                        }
                        else
                        {
                            validarCantidad = true;
                            cantidadProducto = cantidadProducto - cantidadDeVenta;
                        }
                    }
                    catch (FormatException)
                    {
                        MensajeDeError();
                    }
                } while (validarCantidad == false);
            }
            return cantidadProducto;
        }
        public int ReabastecerProducto(int cantidadProducto)
        {
            int cantidadReabastacer;
            bool validarCantidad = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ingresa la cantidad de productos que quieras reabastecer: ");
                try
                {
                    cantidadReabastacer = Convert.ToInt32(Console.ReadLine());
                    if(cantidadReabastacer <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("La cantidad no puede ser menor o igual a 0.");
                        Console.WriteLine();
                    }
                    else
                    {
                        validarCantidad = true;
                        cantidadProducto = cantidadProducto + cantidadReabastacer;
                    }
                }
                catch(FormatException)
                {
                    MensajeDeError();
                }

            } while (validarCantidad == false);
            return cantidadProducto;
        }
    }
}
