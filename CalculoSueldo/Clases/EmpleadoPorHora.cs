

namespace CalculoSueldo.Clases
{
    public class EmpleadoPorHora : Empleado
    {
        public double TarifaPorHora { get; set; } = 800;
        public double HorasTrabajadas { get; set; }
        public EmpleadoPorHora(string Nombre, string Apellido, string NumeroSeguridadSocial,
            double HorasTrabajadas) : base(Nombre, Apellido, NumeroSeguridadSocial)
        {
            this.HorasTrabajadas = HorasTrabajadas;
        }

        public override double CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }
}
