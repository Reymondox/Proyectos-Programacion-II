using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo.Clases
{
    internal abstract class SueldoAsentado : Sueldo
    {
        public int TrabajosSolicitados { get; set; }
        public int TrabajosRealizados { get; set; }

        public double BonoTotal { get; set; }

        


        public SueldoAsentado(int trabajosRealizados)
        {
            TrabajosRealizados = trabajosRealizados;

        }

        public override double CalcularSueldo()
        {
            if (TrabajosRealizados < TrabajosSolicitados)
            {
                return SueldoTotal / 2;
            }
            else
            {
                return SueldoTotal + BonoTotal;
            }
        }
    }
}
