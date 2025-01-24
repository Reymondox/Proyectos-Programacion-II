using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo.Clases
{
    internal class SueldoHora : Sueldo
    {
        public double HorasTrabajadas {  get; set; }

        public SueldoHora(double horasTrabajadas) {
            HorasTrabajadas = horasTrabajadas;
        }

        public override double CalcularSueldo()
        {
            SueldoTotal = HorasTrabajadas * 800;
            return SueldoTotal;
        }
    }
}
