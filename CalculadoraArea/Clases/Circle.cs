using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraArea.Solucion
{
    public class Circle : Shape
    {
        public double Radio { get; set; }
        public Circle(double radio) : base(radio, radio) {
            Radio = radio;
        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(Anchura, 2);
        }

        public override void MostrarPropiedades()
        {
         Console.WriteLine($"Radio: {Radio}");
        }
    }
}
