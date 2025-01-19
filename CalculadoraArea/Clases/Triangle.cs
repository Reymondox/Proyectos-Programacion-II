using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraArea.Solucion
{
    public class Triangle : Shape
    {
            public Triangle(double Anchura,double Altura) : base(Altura,Anchura) { }

            public override double CalculateSurface()
            {
                return (Altura * Anchura) / 2;
            }

            public override void MostrarPropiedades()
            {
            Console.WriteLine($" Altura: {Altura}, Anchura {Anchura}");
            }
    }
}
