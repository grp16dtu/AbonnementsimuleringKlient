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
    public partial class BrugerAdminVindue : Form, IBrugerAdminVindue,IObserver<IBrugerDAO>
    {
        private BrugerAdminVindueController _controller;
        private IndstillingerVindueController _indstillingerVindueController;
        private List<IBrugerDAO> _medarbejderListe;
        private IDisposable _fjernetBruger;
        public BrugerAdminVindue()
        {
            InitializeComponent();
            this.medarbejdere.SelectionChanged += medarbejdere_SelectionChanged;
        }

    void medarbejdere_SelectionChanged(object sender, EventArgs e)
    {
        int index = medarbejdere.CurrentCellAddress.Y;

        if (index > -1)
        {
            fillInfoInWindow(_medarbejderListe[index]);
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
            this._medarbejderListe = new List<IBrugerDAO>();
            
        }

        private void Closing_From(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
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
            //_medarbejderListe[]
            int index = medarbejdere.CurrentCellAddress.Y;
            _medarbejderListe[index].Ansvarlig = this.ansvarlig.Checked;
            _medarbejderListe[index].Brugernavn = this.email.Text;
            _medarbejderListe[index].Fornavn = this.fornavn.Text;
            _medarbejderListe[index].Efternavn = this.efternavn.Text;
            MessageBox.Show(_medarbejderListe[index].Fornavn);
            if(_medarbejderListe[index].MedarbejderNummer != null)
                _medarbejderListe[index].MedarbejderNummer = Convert.ToInt32(this.medarbejdernummer.Text);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            OpdaterMedarbejderListe(sender, e);
         
        }

        private void OpdaterMedarbejderListe(object sender, EventArgs e)
        {
            MessageBox.Show("opdatermedarbejderlistemetode");
            HentMedarbejderListe();
            putEventOnBrugerDAO(sender, e);
            //bygMedArbDataTable();
            medarbejdere.DataSource = _medarbejderListe;
            medarbejdere.Update();
            
            medarbejdere.Columns[3].ReadOnly = true;
            medarbejdere.Columns[4].Visible = false;
            medarbejdere.Columns[5].Visible = false;
        }

        private void putEventOnBrugerDAO(object sender, EventArgs e)
        {
            foreach (BrugerDAO bruger in _medarbejderListe)
            {
                MessageBox.Show("putting events");
                bruger.Changed += this.OpdaterMedarbejderListe;
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
        }

        public void MedarbejderFraListe()
        {
            throw new NotImplementedException();
        }

        public void HentMedarbejderListe()
        {
            this._medarbejderListe = this._controller.getTempListTEST(); //ONLY FOR TESTING, OVERWRITES _MEDARBEJDERLISTE
        }

        //private void bygMedArbDataTable()
        //{
        //    this.medarbejdere.DataSource = null;
        //    this._medarbejderTable = new DataTable();

        //        _medarbejderTable.Columns.Add("Nr.");
        //        _medarbejderTable.Columns.Add("Fornavn");
        //        _medarbejderTable.Columns.Add("Efternavn");
        //        _medarbejderTable.Columns.Add("Ansvarlig");

        //    foreach(BrugerDAO bruger in _medarbejderListe)
        //    {
        //        _medarbejderTable.Rows.Add(bruger.MedarbejderNummer, bruger.Fornavn, bruger.Efternavn, bruger.Ansvarlig);
        //    }
        //    this.medarbejdere.DataSource = _medarbejderTable;
            
        //}



        public void OpenVindue()
        {
            this.Show();
            this.HentMedarbejderListe();
        }

        public void CloseVindue()
        {
            this.Hide();
        }


        public virtual void Subscribe()
        {
            _fjernetBruger = _controller.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _fjernetBruger.Dispose();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(IBrugerDAO bruger)
        {
            //OpdaterMedarbejderListe();
        }
    }
    
}
