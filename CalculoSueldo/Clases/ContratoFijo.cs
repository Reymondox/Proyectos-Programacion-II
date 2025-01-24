using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo.Clases
{
    internal class ContratoFijo : SueldoAsentado
    {
        public ContratoFijo(int trabajosRealizados) : base(trabajosRealizados)
        {
            SueldoTotal = 108000;
            BonoTotal = 10800;
            TrabajosSolicitados = 45;
        }
    }
}
