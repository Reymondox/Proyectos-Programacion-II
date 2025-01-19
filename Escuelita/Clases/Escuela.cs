using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuelita
{
    public class Escuela
    {
        public string? Nombre { get; set; }
        public string? Ubicacion { get; set; }

        public Escuela(string? nombre, string? ubicacion)
        {
            Nombre = nombre;
            Ubicacion = ubicacion;
        }
    }
}
