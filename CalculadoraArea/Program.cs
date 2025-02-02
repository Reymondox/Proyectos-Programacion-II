﻿using CalculadoraArea.Solucion;

namespace CalculadoraArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia en arreglo de la clase padre y de las clases hijas
            Shape[] forma1 = new Shape[]
            {
            new Circle(15),
            new Circle(9),
            new Circle(10),
            new Triangle(12, 4),
            new Triangle(7, 18),
            new Triangle(8, 13),
            new Rectangle(5, 8),
            new Rectangle(11, 7),
            new Rectangle(15, 10),
           };

            //Creamos un arreglo calcArea con el tamaño de la cantidad de objetos creados
            double[] calcArea = new double[forma1.Length];


            //Obtenemos el calculo con el metodo propio y guardamos los resultados en el arreglo calcArea
            for (int i = 0; i < forma1.Length; i++)
            {
                calcArea[i] = forma1[i].CalculateSurface();
            }

            Console.WriteLine("Las figuras a calcular son:");
            for (int i = 0; i < forma1.Length; i++)
            {
                Console.Write($"Forma numero {i + 1}:");
                forma1[i].MostrarPropiedades(); 
            }

            Console.WriteLine("\nEl resultado de calcular las áreas son:");
            for (int i = 0; i < calcArea.Length; i++)
            {
                Console.WriteLine($"Forma numero {i + 1}: {calcArea[i]}");
            }
        }
    }
}
