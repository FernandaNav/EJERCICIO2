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
            string nombre;
            Console.Write("Ingresa el nombre del primer producto: ");
            nombre = Console.ReadLine();
            return nombre;
        }
        public void MensajeDeError()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error de formato");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Pulsa cualquier tecla para continuar...");
            Console.ResetColor(); Console.ReadKey(); Console.Clear();
        }
    }
}
