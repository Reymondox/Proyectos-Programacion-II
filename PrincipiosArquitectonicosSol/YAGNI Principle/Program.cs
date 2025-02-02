namespace YAGNI_Principle;
using System;
using YAGNI_Principle.Class;

internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("---Guardar productos---");

        var lista1 = new GuardarProductos();

        while (true) {
        Console.WriteLine("\nOperaciones posibles:\n");

            Console.WriteLine("1 - Guardar un producto");
            Console.WriteLine("2 - Eliminar un producto");
            Console.WriteLine("3 - Salir");

       Console.WriteLine("\nDigite el numero de la operacion a realizar: ");
            int decision = int.Parse(Console.ReadLine()!);

       if(decision == 1)
            {
                Console.WriteLine("\nDigite el nombre del producto a guardar: ");
                String nombre = Console.ReadLine()!;

                Console.WriteLine($"Digite el precio del producto '{nombre}': ");
                decimal precio = decimal.Parse(Console.ReadLine()!);

                lista1.AddProduct(nombre, precio);
            }
       else if (decision == 2) 
            {
                Console.WriteLine("\nDigite el numero del elemento a borrar: ");
                int idProducto = int.Parse(Console.ReadLine()!);

                lista1.DeleteProduct(idProducto);

            }
       else if (decision == 3)
            {
                Console.WriteLine("\nHa decidido salir.");
                break;
            }
            else
            {
                Console.WriteLine("\nHa seleccionado la operacion incorrecta. Vuelva a intentarlo");
            }

        }
    }
}
