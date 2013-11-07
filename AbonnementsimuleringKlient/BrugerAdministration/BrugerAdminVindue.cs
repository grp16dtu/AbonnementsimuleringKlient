using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonnementsimuleringKlient
{
    public partial class BrugerAdminVindue : Form, IBrugerAdminVindue
    {
        private BrugerAdminVindueController _controller;
        private IndstillingerVindueController _indstillingerVindueController;
        private List<IBrugerDAO> _medarbejderListe;
        public BrugerAdminVindue()
        {
            InitializeComponent();
        }

        public void SetBrugerAdminVindueController(BrugerAdminVindueController controller)
        {
            this._controller = controller;
        }

        private void instillinger_Click(object sender, EventArgs e)
        {
            _controller.OpenIndstilleringVindue();
        }

        private void opretBruger_Click(object sender, EventArgs e)
        {
            if (email.Text.Contains(":"))
            {
                this.colonWar.BackColor = Color.Red;
                this.colonWar.Text = "Der må ikke være kolon i Email adressen";
            }
            else
            {
                this.colonWar.Text = "";
                //TODO: Skal laves færdig 
            }
                
   
        }

        private void sletBruger_Click(object sender, EventArgs e)
        {

        }

        private void gemBruger_Click(object sender, EventArgs e)
        {

        }

        private void OnLoad(object sender, EventArgs e)
        {
            OpdaterMedarbejderListe(sender, e);
         
        }

        private void OpdaterMedarbejderListe(Object sender, EventArgs e)
        {
            HentMedarbejderListe();
            foreach(BrugerDAO bruger in _medarbejderListe)
            {
                bruger.Changed += new EventHandler(OpdaterMedarbejderListe);
            }
        }

        public void HentIndstillingerVindue()
        {
            throw new NotImplementedException();
        }

        public void OpretBruger()
        {
            throw new NotImplementedException();
        }

        public void SletBruger()
        {
            throw new NotImplementedException();
        }

        public void GemBruger()
        {
            throw new NotImplementedException();
        }

        public void MedarbejderFraListe()
        {
            throw new NotImplementedException();
        }

        public void HentMedarbejderListe()
        {
            _medarbejderListe = _controller.medarbejderListe;
            for(int i = 0; i < _medarbejderListe.Count; i++)
            {
                this.medarbejdere.Rows[i].Cells[0].Value = _medarbejderListe[i].MedarbejderNummer;
                this.medarbejdere.Rows[i].Cells[1].Value = _medarbejderListe[i].Fornavn + _medarbejderListe[i].Efternavn;
            }
        }

        public void OpenVindue()
        {
            this.Show();
        }

        public void CloseVindue()
        {
            this.Hide();
        }
    }
}
