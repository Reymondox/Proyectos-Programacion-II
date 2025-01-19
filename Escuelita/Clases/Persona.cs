﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuelita
{
    public abstract class Persona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Sexo { get; set; }


        public Persona(string? nombre, string? apellido, string? sexo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
        }

        public abstract void Escribir();
        public abstract void Asistir();
    }
}
