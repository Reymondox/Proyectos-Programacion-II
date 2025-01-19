using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuelita
{
    public class Clase : Escuela
    {
        public Alumno? Alumno { get; set; }
        public Profesor? Profesor { get; set; }

        public string? Codigo { get; set; }
        public Clase(string? nombre, string? ubicacion, string? codigo) : base(nombre, ubicacion)
        {
            Codigo = codigo;
        }

        public void ProfesorPerteneceAClase(Profesor profesorPerteneceAClase)
        {
            Profesor = profesorPerteneceAClase;
            Console.WriteLine($"El profesor {Profesor.Nombre} {Profesor.Apellido}, id {Profesor.IdProfesor}, es parte de la clase " + Nombre);
        }

        public void AlumnoPerteneceAClase(Alumno alumnoPerteneceAClase)
        {
            Alumno = alumnoPerteneceAClase;

                Console.WriteLine($"El alumno {Alumno.Nombre} {Alumno.Apellido}, matricula {Alumno.Matricula}, es parte de la clase " + Nombre);
        }
    }
}
