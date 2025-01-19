using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraArea.Solucion
{
    public class Rectangle : Shape
    {
        public Rectangle(double Anchura, double Altura) : base(Anchura, Altura) { }

        public override double CalculateSurface()
        {
            return Altura * Anchura;
        }

        public override void MostrarPropiedades()
        {
            Console.WriteLine($" Altura: {Altura}, Anchura {Anchura}");
        }
    }
}
