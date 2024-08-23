using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaPolicia.Models
{
    public class Persona
    {
        public int DNI { get; private set; }
        public string Nombre { get; private set; }

        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public virtual string VerDatos()
        {
            string date = $@"DNI:{DNI}
                             Nombre:{Nombre}";
            return date;
        }
    }
}
