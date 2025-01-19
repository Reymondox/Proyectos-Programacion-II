using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuelita
{
    public class Curso
    {
        public string? Codigo { get; set; }
        public string? NombreCurso { get; set; }
        public int RecuentoClases { get; set; }

        public int RecuentoEjercicios { get; set; }

        public Profesor? Profesor;

        public Curso(string? codigo, string? nombreCurso,
            int recuentoClases, int recuentoEjercicios)
        {
            Codigo = codigo;
            NombreCurso = nombreCurso;
            RecuentoClases = recuentoClases;
            RecuentoEjercicios = recuentoEjercicios;
        }

        public void Encargado(Profesor profesorACargo)
        {
            Profesor = profesorACargo;
            Console.WriteLine($"El profesor {Profesor.Nombre} {Profesor.Apellido} va a impartir el curso {NombreCurso}");
        }

        public int ContarClases()
        {
            Console.WriteLine($"Hay un total de {RecuentoClases} clases en el curso {NombreCurso}.");
            return RecuentoClases;
        }

        public int ContarEjercicios()
        {
            Console.WriteLine($"Hay un total de {RecuentoEjercicios} ejercicios en este curso {NombreCurso}.");
            return RecuentoEjercicios;
        }
    }
}
