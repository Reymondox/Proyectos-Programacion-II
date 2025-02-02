namespace DRY_Principle;

using DRY_Principle.Clases;
using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----Calculadora de salario----");

        var salario1 = new CalculoDeSalario();

        Console.WriteLine("\nDigite 1 para calcular empleado a tiempo completo, 2 para calcular empleado a medio tiempo: ");
        int seleccion = int.Parse(Console.ReadLine()!);

        if (seleccion == 1) 
        {
            Console.WriteLine("Ingrese el salario base: ");
            decimal salarioBase = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine($"El sueldo neto es de: {salario1.CalcularSalarioFijo(salarioBase)}");
        }

        else if(seleccion == 2)
        {
            Console.WriteLine("Ingrese el salario por hora: ");
            decimal salarioPorHora = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese el total de horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"El sueldo neto es de: {salario1.CalcularSalarioPorHora(salarioPorHora,horasTrabajadas)}");
        }

        else
        {
            Console.WriteLine("Ha seleccionado la operación de forma incorrecta.");
        }
    }
}

