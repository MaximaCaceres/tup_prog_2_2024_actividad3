using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaPolicia.Models
{
    public abstract class Incidente
    {
        public string Motivo { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }
        public Persona Sujeto { get; private set; }
        public Policia OficialAcargo { get; private set; }
        public int CantidadIndicentes = 0;

        #region Metodos:

        public Incidente(Policia oficial,Persona sujeto)
        {
            OficialAcargo = oficial;
            Sujeto = sujeto;
            
        }
        public abstract string VerDescripcion();
        #endregion
    }
}
