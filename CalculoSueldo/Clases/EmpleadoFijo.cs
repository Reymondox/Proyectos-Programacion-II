using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSueldo.Clases
{
    public class EmpleadoFijo : Empleado
    {
        public double SalarioMensual {  get; set; }
      
        public int MetasCumplidas { get; set; }
        public int MetasSolicitadas { get; set; }
        public double Bonificaciones { get; set; }
                public double SalarioTotal {  get; set; }

        public EmpleadoFijo(string Nombre, string Apellido, string NumeroSeguridadSocial,
            double SalarioMensual, int MetasSolicitadas, int MetasCumplidas, double Bonificaciones) 
            : base(Nombre, Apellido, NumeroSeguridadSocial)
        {
            this.SalarioMensual = SalarioMensual;
            this.MetasCumplidas = MetasCumplidas;
            this.MetasSolicitadas = MetasSolicitadas;
            this.Bonificaciones = Bonificaciones;
        }

        public override double CalcularSalario()
        {
            if (MetasCumplidas < MetasSolicitadas) {
                SalarioTotal = (SalarioMensual / 2);
            }
            else {
                SalarioTotal = SalarioMensual + ((SalarioMensual * Bonificaciones)/100);
            }
            return SalarioTotal;
        }
    }
}
