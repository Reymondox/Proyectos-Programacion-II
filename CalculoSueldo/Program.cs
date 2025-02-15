using CalculoSueldo.Clases;
namespace CalculoSueldo
{
    public class Program
    {
        static void Main()
        {
            Nomina nomina = new Nomina();

            nomina.AgregarEmpleado(new EmpleadoPorHora("Carlos","Pérez", "123-45-6789", 124));
            nomina.AgregarEmpleado(new EmpleadoFijo("Ana","Gómez", "987-65-4321", 72000, 35, 31, 0));
            nomina.AgregarEmpleado(new EmpleadoFijo("Juan", "Rodríguez", "654-32-1987", 72000, 35, 35, 10));
            nomina.AgregarEmpleado(new EmpleadoPorHora("Luis", "Martínez", "456-78-9012", 130));
            nomina.AgregarEmpleado(new EmpleadoFijo("Maria", "Cespedes", "884-01-9471", 91000, 35, 35, 10));
            nomina.AgregarEmpleado(new EmpleadoAdministrativo("Antonio", "Guzman", "904-01-4932", 85000, 34, 35, 10));
            nomina.AgregarEmpleado(new EmpleadoAdministrativo("Martin", "Gutierrez", "905-53-3014", 81000, 35, 35, 10));

            nomina.RealizarNomina();
        }
    }
}
