using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaPolicia.Models
{
    public class Arresto:Incidente
    {
        public Arresto(Policia oficialAcargo,Persona sujeto):base(oficialAcargo,sujeto)
        {

        }

        public override string VerDescripcion()
        {
            string date = $"{OficialAcargo.VerDatos()}\r\n{Sujeto.VerDatos()}\r\n{Motivo}\r\n Hora:{Hora}:{Minuto}";
            return date;
        }
    }
}
