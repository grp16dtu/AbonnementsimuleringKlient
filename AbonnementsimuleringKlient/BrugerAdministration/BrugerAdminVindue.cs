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
        private bool _igangMedBrugerOprettelse;
        public BrugerAdminVindue()
        {
            InitializeComponent();
            this.medarbejdere.SelectionChanged += medarbejdere_SelectionChanged;
            _igangMedBrugerOprettelse = false;
        }

    void medarbejdere_SelectionChanged(object sender, EventArgs e)
    {
        int index = medarbejdere.CurrentCellAddress.Y;

        if (index > -1)
        {
            fillInfoInWindow(this._controller.MedarbejderListe[index]);
        }
    }

        private void fillInfoInWindow(IBrugerDAO brugerDAO)
        {
            this.email.Text = brugerDAO.Brugernavn;
            this.efternavn.Text = brugerDAO.Efternavn;
            this.fornavn.Text = brugerDAO.Fornavn;
            this.ansvarlig.Checked = brugerDAO.Ansvarlig;
            this.medarbejdernummer.Text = brugerDAO.MedarbejderNummer.ToString();
        }

        public void SetBrugerAdminVindueController(BrugerAdminVindueController controller)
        {
            this._controller = controller;
            this.FormClosing += new FormClosingEventHandler(Closing_From);            
        }

        private void Closing_From(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    //sørger for at object ikke destrueres når vindue lukkes
            this.Hide();
        }

        private void instillinger_Click(object sender, EventArgs e)
        {
            _controller.OpenIndstilleringVindue();
        }

        private void opretBruger_Click(object sender, EventArgs e)
        {
            _igangMedBrugerOprettelse = true;

            ClearInfoWindow();
        }

        private void ClearInfoWindow()
        {
            this.email.Text = "";
            this.efternavn.Text = "";
            this.fornavn.Text = "";
            this.ansvarlig.Checked = false;
            this.medarbejdernummer.Text = null;
            this.kodeord.Text = "";
            this.kodeord.ReadOnly = false;
        }

        
        private void sletBruger_Click(object sender, EventArgs e)
        {
            //TODO: slet bruger metode
        }

        private void gemBruger_Click(object sender, EventArgs e)
        { 
            //Check email
            if (email.Text.Contains(":"))
            {
                this.colonWar.BackColor = Color.Red;
                this.colonWar.Text = "Der må ikke være kolon i Email adressen";
            }
            else
            {
                this.colonWar.Text = "";
                //TODO: opretbruger Skal laves færdig 
                //_controller.OpretBruger();
            }

            int? tempMedarbejdernummer = null;
            
            if (this.medarbejdernummer.Text != "")
                tempMedarbejdernummer = Convert.ToInt32(this.medarbejdernummer.Text);
            
            if (!_igangMedBrugerOprettelse)
            {
                int index = medarbejdere.CurrentCellAddress.Y;

                

                this._controller.GemBruger(this.ansvarlig.Checked, this.email.Text, this.fornavn.Text, this.efternavn.Text, tempMedarbejdernummer, index);
            }
            else
            {
                if (this._controller.OpretBruger(this.ansvarlig.Checked, this.email.Text, this.fornavn.Text, this.efternavn.Text, tempMedarbejdernummer, this.kodeord.Text))
                {
                    OpdaterMedarbejderListe(null, EventArgs.Empty);
                    this.colonWar.Text = "Bruger oprettet succesfuldt.";     
                }
                else
                {
                    this.colonWar.Text = "FEJL i oprettelse af bruger";
                }
                _igangMedBrugerOprettelse = false;
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this._controller.HentMedarbejderListe();
            BindingSource bs = new BindingSource();
            bs.DataSource = this._controller.MedarbejderListe;
            medarbejdere.DataSource = bs;
            OpdaterMedarbejderListe(sender, e);
        }

        public void OpdaterMedarbejderListe(object sender, EventArgs e)
        {
            //medarbejdere.DataSource = this._controller.MedarbejderListe;
            MessageBox.Show(this._controller.MedarbejderListe.ToString());
            medarbejdere.Update(); //det virker ik??
            
            medarbejdere.Columns[3].ReadOnly = true;
            medarbejdere.Columns[4].Visible = false;
            medarbejdere.Columns[5].Visible = false;
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
