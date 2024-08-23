using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaPolicia.Models
{
    public class Guardia
    {
        public int HoraDesde{ get; private set; }
        public int HoraHasta //Uso la forma larga cuando el valor de la propiedad es dinamico.
        { 
            get 
            {
                int total = HoraDesde * 60 + MinutoDesde + CantidadMinutos;
                return total % 60;//para sacar las horas.
            } 
        }
        public int MinutoHasta
        {
            get
            {
                int total = HoraDesde * 60 + MinutoDesde + CantidadMinutos;
                return total / 60;//para sacar los minutos.
            }
        }
        public int MinutoDesde { get; private set; }
        public int CantidadMinutos { get; private set; }
        public Policia OficialAsignado{ get; private set; }

        #region Metodo
        public void AsignarPolicia(Policia agente,int h,int m, int CantM)
        {
            OficialAsignado = agente;
            HoraDesde = h;
            MinutoDesde = m;
            CantidadMinutos = CantM;
        }

        #endregion
    }
}
