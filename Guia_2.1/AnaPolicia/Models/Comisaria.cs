using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AnaPolicia.Models
{
    public class Comisaria //♥
    {
        ArrayList incidentes = new ArrayList();
        ArrayList agentes = new ArrayList();
        Guardia[] guardias = new Guardia[2];
        public int CantidadIncidentes
        {
            get
            {
                return incidentes.Count;
            }
        }


        #region Metodos:
        public Comisaria()
        {
            for(int n = 0; n < guardias.Length; n++)
            {
                Guardia guardia = new Guardia();
                guardias[n] = guardia;
            }
            
        }
        public bool AsignarPolicia(Policia agente)//cumple con la relacion de agregacion porque le pasamos el objeto ya creado.
        {
            bool completo = false;
            if(agentes.Count < 2)//verifico que en el ArrayList haya menos de dos agentes.
            {
                agentes.Add(agente);//cumple con "Multiplicidad" ya que respetamos que solo puede haber hasta 2 policias.
                completo = true;
            }
            return completo;
        }
        public Policia VerAgente(int numP)//metodo de busqueda por placa del agente//arraylist
        {
            Policia buscado = null;
            int idx = 0;
            while(buscado == null && idx < agentes.Count)//el indice sea menor a la cantidad de agentes.
            {
                Policia poli = agentes[idx] as Policia;//creamos una variable que recibe el valor guardado dentro de un arraylist(casteo)
                if (poli.NumeroPlaca == numP)         //la similitud con el vector es por el [idx] = representa la posicion del array.
                {
                    buscado = poli;
                }
                idx++;//movemos el indice, no es un for.
            }                                          
            return buscado;
        }
        public void RegistrarIncidente(Policia agente,Persona sujeto,string motivo,int hora,int minuto,int TipoIncidente)
        {
            if(TipoIncidente == 0)
            {
                Denuncia denuncia = new Denuncia(agente,sujeto);
                denuncia.Motivo = motivo;
                denuncia.Hora = hora;
                denuncia.Minuto = minuto;
                incidentes.Add(denuncia);
            }
            else
            {
                Arresto arresto = new Arresto(agente, sujeto);
                arresto.Motivo = motivo;
                arresto.Hora = hora;
                arresto.Minuto = minuto;
                incidentes.Add(arresto);
            }
            
        }
        public void AsignarGuardia(int numP, int horaD, int minutoD, int cantM,Policia agente)
        {
            for(int n = 0; n < guardias.Length; n++)
            {
                Guardia guard = guardias[n];
                guard.AsignarPolicia(agente,horaD,minutoD,cantM);//a la guaria le asigno un policia.
            }
        }
        public Incidente VerIncidente(int idx)
        {
            Incidente inc = null;//respetamos la relacion.
            if(idx < incidentes.Count)
            {
                inc = incidentes[idx] as Incidente;//casteo
                return inc;
            }
            return inc;
        }

        #endregion

    }
}
