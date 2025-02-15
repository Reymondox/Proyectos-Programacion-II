
namespace CalculoSueldo.Clases
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroSeguridadSocial { get; set; }

        public Empleado(string Nombre, string Apellido, string NumeroSeguridadSocial) {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.NumeroSeguridadSocial = NumeroSeguridadSocial;
        }

        public abstract double CalcularSalario();

    }
}
