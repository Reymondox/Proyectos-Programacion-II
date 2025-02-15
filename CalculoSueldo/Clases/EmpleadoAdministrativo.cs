
namespace CalculoSueldo.Clases
{
    public class EmpleadoAdministrativo : EmpleadoFijo
    {
        public double BonoFijo { get; set; } = 500;
        public EmpleadoAdministrativo(string Nombre, string Apellido, string NumeroSeguridadSocial, double SalarioMensual, int MetasSolicitadas, int MetasCumplidas, double Bonificaciones) : base(Nombre, Apellido, NumeroSeguridadSocial, SalarioMensual, MetasSolicitadas, MetasCumplidas, Bonificaciones)
        {
        }

        public override double CalcularSalario()
        {
            SalarioMensual = BonoFijo + base.CalcularSalario();

            return SalarioMensual;
        }
    }
}
