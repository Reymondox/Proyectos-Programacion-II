using KISSPrinciple.Clases;
using System;
using System.Linq;

namespace PrincipiosArquitectonicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Factura del restaurante----");

            var factura1 = new FacturaRestaurante();
            
            Console.WriteLine("\nDigite los precios de los platos comprados (separados por coma)");
            decimal[] totalAPagar = Console.ReadLine()!.Split(',').Select(decimal.Parse).ToArray();

            Console.WriteLine("¿Desea agregar un porcentaje de propina personalizada? si no, se agregara una propina del 10% (s/n): ");
            String Decision = Console.ReadLine()!;
            
            if(Decision == "s" || Decision == "S")
            {
                Console.WriteLine("Digite el porcentaje de propina: ");
                decimal PropinaPersonalizada = decimal.Parse(Console.ReadLine()!);

                Console.WriteLine($"Total a pagar (con propina personalizada): " 
                    + factura1.CalcularFactura(totalAPagar, PropinaPersonalizada));
            }
            else
            {
                Console.WriteLine($"Total a pagar (con propina del 10%): " + factura1.CalcularFactura(totalAPagar, null));
            }
        }
    }
}
