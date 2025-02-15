namespace CalculoSueldo.Clases
{
    public class Nomina
    {
        private List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public void RealizarNomina()
        {
            Console.WriteLine("---- Sistema de Nómina ----");
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Empleado: {empleado.Nombre} {empleado.Apellido} - NSS: {empleado.NumeroSeguridadSocial} - Salario total: ${empleado.CalcularSalario():F2}");
            }
        }
    }
}
