namespace Escuelita
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Escuela escuela = new Escuela("Instituto Tecnologico Otto Martinez Baez",
             "Av. Pte. Nayib Bukele, C/ Primera, mirador del ozama");

            Clase clase1 = new Clase("Laboratorio de Software", "4-2B", "ITOMB42B");
            Clase clase2 = new Clase("Laboratorio de electronica", "1-1F", "ITOMB11F");

            Alumno alumno1 = new Alumno("Oscar", "Martinez", "Masculino", "2025-0924");
            Alumno alumno2 = new Alumno("Maria Teresa", "Rodriguez", "Femenino", "2025-1429");
            Alumno alumno3 = new Alumno("Cesaria", "Rodriguez", "Femenino", "2025-1131");
            Alumno alumno4 = new Alumno("Reynaldo", "Gomera", "Masculino", "2025-0091");

            Profesor profesor1 = new Profesor("Antonio Miguel", "de Jesus", "Masculino", "0031");
            Profesor profesor2 = new Profesor("Migela", "Jimenez", "Femenino", "0032");

            Curso curso1 = new Curso("TDS-042", "Programacion I", 3, 48);
            Curso curso2 = new Curso("CFG-042", "Electronica", 2, 61);

            clase1.AlumnoPerteneceAClase(alumno1);
            clase1.AlumnoPerteneceAClase(alumno2);
            clase2.AlumnoPerteneceAClase(alumno3);
            clase2.AlumnoPerteneceAClase(alumno4);

            clase1.ProfesorPerteneceAClase(profesor1);
            clase2.ProfesorPerteneceAClase(profesor2);

            curso1.Encargado(profesor1);
            curso2.Encargado(profesor2);

            curso1.ContarClases();
            curso1.ContarEjercicios();

            alumno1.Asistir();
            alumno2.Participar();

            profesor1.PasarAsistencia();
            profesor2.Escribir();
        }
    }
}
