using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo.Clases
{
    internal class ContratoAdministrativo : SueldoAsentado
    {
        

        public ContratoAdministrativo(int trabajosRealizados) 
            : base(trabajosRealizados)
        {
            SueldoTotal = 96000;
            BonoTotal = 9600;
            TrabajosSolicitados = 74;
        }
    }
}