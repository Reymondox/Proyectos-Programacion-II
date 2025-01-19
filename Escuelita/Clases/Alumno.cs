using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuelita
{
    public class Alumno : Persona
    {
        public string? Matricula { get; set; }
        public Alumno(string? nombre, string? apellido, string? sexo, string? matricula) : base(nombre, apellido, sexo)
        {
            Matricula = matricula;
        }

        public override void Asistir()
        {
            Console.WriteLine($"El estudiante {Nombre} {Apellido} ha asistido a la clase");
        }

        public override void Escribir()
        {
            Console.WriteLine($"El estudiante {Nombre} {Apellido} ha escrito en su cuaderno.");
        }

        public void Participar()
        {
            Console.WriteLine($"El estudiante {Nombre} {Apellido} ha participado");
        }
    }
}