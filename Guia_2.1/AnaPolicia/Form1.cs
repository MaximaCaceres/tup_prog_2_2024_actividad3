using AnaPolicia.Models;
using System;
using System.Windows.Forms;


namespace AnaPolicia.Guia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Comisaria destacamento = new Comisaria();
        private void btnCrearComisaria_Click(object sender, EventArgs e)
        {
            
            Policia Ana = new Policia(45755453,"Ana",11);
            Policia Juan = new Policia(46555432,"Juan",17);

            destacamento = new Comisaria();

            destacamento.AsignarPolicia(Juan);
            destacamento.AsignarPolicia(Ana);
            cbxNumPlaca.Items.Clear();
            cbxNumPlaca.Items.Add(Juan.NumeroPlaca);
            cbxNumPlaca.Items.Add(Ana.NumeroPlaca);
            btnListarIncidente.Enabled = true;
            groupBox4.Enabled = true;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnAsignacionGuardias_Click(object sender, EventArgs e)
        {
            
            int nump = Convert.ToInt32(nupdNumGuardia.Value);
            int h = Convert.ToInt32(nupdHoraDesde.Value);
            int m = Convert.ToInt32(nupdMinutoDesde.Value);
            int cantm = Convert.ToInt32(nupdDuracionM.Value);

            Policia agente = destacamento.VerAgente(nump);//tengo que crear un agente y ir al destacamento para ver quien es por su num de placa.

            destacamento.AsignarGuardia(nump, h, m, cantm, agente);//porque sino no puedo pasarle agente aca.
        }
        
        private void btnListarIncidente_Click(object sender, EventArgs e)
        {
            Resultados resul = new Resultados();
            for(int idx = 0; idx < destacamento.CantidadIncidentes; idx++)
            {
                resul.tbxResult.Text += $"\r\n----------{idx}----------\r\n";//indica numero de incidente.
                Incidente inci = destacamento.VerIncidente(idx);//creo un nuevo obj de incidente para entrar al destacamento guardar el indicente que esta en idx indicado.
                if(inci is Denuncia)
                {
                    resul.tbxResult.Text = $"{inci.VerDescripcion()}";
                }
                if(inci is Arresto)
                {
                    resul.tbxResult.Text = $"{inci.VerDescripcion()}";
                }
                
            }
            resul.tbxResult.Text += $"\r\n------------------------";
            resul.ShowDialog();
        }

        private void btnRegistrarInci_Click(object sender, EventArgs e)
        {
            if(cbxNumPlaca.SelectedItem != null && cbxTipoIncidente.SelectedItem != null)
            {//si hay un policia y sabemos el tipo de incidente (no nulo), entonces...

                string nump = cbxNumPlaca.SelectedItem.ToString();//necesito el numero de placa.
                int numP = Convert.ToInt32(nump);//lo guardamos ya pasado a int.

                string moti = tbxMotivo.Text;
                string nom = tbxSujeto.Text;//este dato junto con el de abajo
                int dni = Convert.ToInt32(tbxDniSujeto.Text);//se lo pasamos al constructor de persona.
                int h = Convert.ToInt32(nupdHora.Value);
                int m = Convert.ToInt32(nupdMinuto.Value);
                int tInc = cbxTipoIncidente.SelectedIndex;//va a ser 0 o 1 dependiendo el indice.

                Policia agente = destacamento.VerAgente(numP);//necesitaba la placa para pasarle aqui asi veo el agente.

                Persona sujeto = new Persona(dni, nom);//creo al sujeto.
                //ahora llamo al destacamento para registrar el incidente con el metodo que corresponde.
                destacamento.RegistrarIncidente(agente, sujeto, moti, h, m, tInc);//listo, registramos el incidente.
            }
            else
            {
                MessageBox.Show("Verifique que haya una placa registrada y tipo incidente");
            }
        }
    }


}
