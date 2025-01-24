using CalculoSueldo.Clases;
using System.Runtime.InteropServices;
namespace CalculoSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sueldo[] sueldo = new Sueldo[] {
                new SueldoHora(168),
                new SueldoHora(121),
                new SueldoHora(160),

                new ContratoFijo(38),
                new ContratoFijo(45),

                new ContratoAdministrativo(74),
                new ContratoAdministrativo(61)
            };

            double[] calcSueldo = new double[sueldo.Length];

            for (int i = 0; i < sueldo.Length; i++)
            {
                calcSueldo[i] = sueldo[i].CalcularSueldo();
            }

            Console.WriteLine("Calculo de sueldo:");
            for (int i = 0;i < sueldo.Length; i++) {
                Console.WriteLine($"Sueldo bruto {i + 1}: RD$ {calcSueldo[i]}");
        }
    }
}
}