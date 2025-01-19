using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraArea.Solucion
{
    public abstract class Shape
    {
        public double Anchura { get; set; }
        public double Altura { get; set; }


        public Shape(double anchura, double altura)
        {
            Anchura = altura;
            Altura = anchura;
        }
        public abstract double CalculateSurface();

        public abstract void MostrarPropiedades();
    }
}
