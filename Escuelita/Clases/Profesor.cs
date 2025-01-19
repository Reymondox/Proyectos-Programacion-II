using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuelita
{
    public class Profesor : Persona
    {

        public string? IdProfesor { get; set; }
        public Profesor(string? nombre, string? apellido, string? sexo, string? idProfesor)
            : base(nombre, apellido, sexo)
        {
            IdProfesor = idProfesor;
        }

        public override void Asistir()
        {
            Console.WriteLine($"El profesor {Nombre} {Apellido} ha asistido a su clase.");
        }

        public override void Escribir()
        {
            Console.WriteLine($"El profesor {Nombre} {Apellido} ha escrito en la pizarra.");
        }

        public void PasarAsistencia()
        {
            Console.WriteLine($"El profesor {Nombre} {Apellido} ha pasado la asistencia.");
        }
    }
}
