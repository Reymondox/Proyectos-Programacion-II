using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo.Clases
{
    public abstract class Sueldo
    {
        public double SueldoTotal {  get; set; }
        public Sueldo() { 
        }
        public abstract double CalcularSueldo();
    }
}
