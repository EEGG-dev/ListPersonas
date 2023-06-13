using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListPersonas
{
    public class Persona
    {
        public string Nombre { get; }
        public int Edad { get; }

        public Persona(String nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
