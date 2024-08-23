using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaPolicia.Models
{
    public class Denuncia:Incidente
    {
        public Denuncia(Policia oficialAcargo, Persona sujeto):base(oficialAcargo,sujeto)
        {

        }
        public override string VerDescripcion()
        {
            string date = $"{Sujeto.VerDatos()}\r\n{OficialAcargo.VerDatos()}\r\n{Motivo}\r\n Hora:{Hora}:{Minuto}";
            return date;
        }
    }
}
