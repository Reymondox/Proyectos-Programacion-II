using System;
using System.Collections.Generic;

namespace YAGNI_Principle.Class
{
    internal class GuardarProductos
    {
        List<String> ListaNombre = new List<String>();
        List<Decimal> ListaPrecio = new List<Decimal>();

        public void AddProduct(String nombre, decimal precio)
        {
            ListaNombre.Add(nombre);
            ListaPrecio.Add(precio);
            Console.WriteLine($"\nEl producto '{nombre}' ha sido añadido con el precio {precio}");
        }


        public void DeleteProduct(int idProducto)
        {
            ListaNombre.RemoveAt(idProducto-1);
            ListaPrecio.RemoveAt(idProducto-1);
            Console.WriteLine($"\nEl producto numero {idProducto} ha sido borrado con éxito.");
        }
    }
}
