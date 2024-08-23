using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaPolicia.Models
{
    public class Policia:Persona
    {
        public int NumeroPlaca { get; private set; }

        public Policia(int dni,string nombre,int numPlaca):base(dni, nombre)
        {

            NumeroPlaca = numPlaca;
        }

        public override string VerDatos()
        {
            string date = $@"DNI:{DNI}
                             Policia:{Nombre}
                             Nro Placa:{NumeroPlaca}";
            return date;
        }
    }
}
