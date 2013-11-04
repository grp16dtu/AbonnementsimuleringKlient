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
        BrugerAdminVindueController brugerAdminVindueController;
        private List<IBrugerDAO> medarbejderListe;
        public BrugerAdminVindue()
        {
            InitializeComponent();
        }

        private void instillinger_Click(object sender, EventArgs e)
        {

        }

        private void opretBruger_Click(object sender, EventArgs e)
        {

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
            foreach(BrugerDAO bruger in medarbejderListe)
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
            medarbejderListe = brugerAdminVindueController.medarbejderListe;
            for(int i = 0; i < medarbejderListe.Count; i++)
            {
                this.medarbejdere.Rows[i].Cells[0].Value = medarbejderListe[i].ID;
                this.medarbejdere.Rows[i].Cells[1].Value = medarbejderListe[i].Fornavn + medarbejderListe[i].Efternavn;
            }
        }

        public void SetBrugerAdminVindueController(BrugerAdminVindueController controller)
        {
            this.brugerAdminVindueController = controller;
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
