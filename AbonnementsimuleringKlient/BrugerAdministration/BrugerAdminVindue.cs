﻿using System;
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

        private RegexUtilities _util;

        public BrugerAdminVindue()
        {
            InitializeComponent();
            this.medarbejdere.SelectionChanged += medarbejdere_SelectionChanged;
            _igangMedBrugerOprettelse = false;
        }

    void medarbejdere_SelectionChanged(object sender, EventArgs e)
    {
        this.email.ReadOnly = true;
        int index = medarbejdere.CurrentCellAddress.Y;

        if (index > -1 && index < this._controller.MedarbejderListe.Count)
        {
            fillInfoInWindow(this._controller.MedarbejderListe[index]);
            _igangMedBrugerOprettelse = false;
        }
    }

        private void fillInfoInWindow(IBrugerDTO brugerDTO)
        {
            this.email.Text = brugerDTO.Brugernavn;
            this.efternavn.Text = brugerDTO.Efternavn;
            this.fornavn.Text = brugerDTO.Fornavn;
            this.ansvarlig.Checked = brugerDTO.Ansvarlig;
            this.medarbejdernummer.Text = brugerDTO.MedarbejderNummer.ToString();
            this.kodeord.Text = brugerDTO.Kodeord;
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



        private void opretBruger_Click(object sender, EventArgs e)
        {
            medarbejdere.ClearSelection();
            ClearInfoWindow();
            _igangMedBrugerOprettelse = true;
        }

        private void ClearInfoWindow()
        {
            this.email.Text = "";
            this.efternavn.Text = "";
            this.fornavn.Text = "";
            this.ansvarlig.Checked = false;
            this.medarbejdernummer.Text = null;
            this.kodeord.Text = "";
            this.email.ReadOnly = false;
        }

        
        private void sletBruger_Click(object sender, EventArgs e)
        {
            int index = medarbejdere.CurrentCellAddress.Y;


            if (_controller.AktuelBruger.Brugernavn != _controller.MedarbejderListe[index].Brugernavn)
            {

                bool succes = this._controller.SletBruger(this._controller.MedarbejderListe[index]);
                if (succes)
                {
                    this.colonWar.ForeColor = Color.Green;
                    this.colonWar.Text = "Sletning succesfuld.";
                }
                else
                {
                    this.colonWar.ForeColor = Color.Red;
                    this.colonWar.Text = "Sletning mislykket.";

                }
            }
            else
            {
                this.colonWar.ForeColor = Color.Red;
                this.colonWar.Text = "Du kan ikke slette dig selv.";
            }
        }

        private void gemBruger_Click(object sender, EventArgs e)
        { 
            _util = new RegexUtilities();
            //Check name in email
            if (email.Text.Contains(":"))
            {
                this.colonWar.ForeColor = Color.Red;
                this.colonWar.Text = "Der må ikke være kolon i Email adressen";
                return;
            }
            else
            {
                this.colonWar.Text = "";
            }
            //Tjekker om email er gyldig
            if (!_util.IsValidEmail(email.Text))
            {
                this.colonWar.ForeColor = Color.Red;
                this.colonWar.Text = "Den intastede email er ikke gyldig";
                return;
            }
            else
            {
                this.colonWar.Text = "";
            }

            int valgt = medarbejdere.CurrentCellAddress.Y;
            int? tempMedarbejdernummer = null;

            //gets medarbejdernummer safely
            if (valgt != -1)
            {
                tempMedarbejdernummer = this._controller.MedarbejderListe[valgt].MedarbejderNummer;
            }

            if (this.medarbejdernummer.Text != "")
            {
                try
                {
                    tempMedarbejdernummer = Convert.ToInt32(this.medarbejdernummer.Text);
                }
                catch(Exception)
                {
                    this.colonWar.ForeColor = Color.Red;
                    this.colonWar.Text = "Medarbejdernummer skal være tomt eller et heltal.";
                    //MessageBox.Show("FEJL!!!!");
                    return;
                }
            }

            //Gem opdatering else opret
            if (_igangMedBrugerOprettelse == false)
            {
                int index = medarbejdere.CurrentCellAddress.Y;
                bool succes = this._controller.GemBruger(this.ansvarlig.Checked, this.email.Text, this.fornavn.Text, this.efternavn.Text, tempMedarbejdernummer, index, this.kodeord.Text);
                if (succes)
                {
                    this.colonWar.ForeColor = Color.Green;
                    this.colonWar.Text = "Opdatering succesfuld.";
                }
                else
                {
                    this.colonWar.ForeColor = Color.Red;
                    this.colonWar.Text = "Opdatering mislykket.";
                }
            }
            //opret
            else
            {
                if (this._controller.OpretBruger(this.ansvarlig.Checked, this.email.Text, this.fornavn.Text, this.efternavn.Text, tempMedarbejdernummer, this.kodeord.Text))
                {
                    OpdaterMedarbejderListe(null, EventArgs.Empty);
                    this.colonWar.ForeColor = Color.Green;
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
            OpdaterMedarbejderListe(sender, e);
        }

        public void OpdaterMedarbejderListe(object sender, EventArgs e)
        {
            medarbejdere.DataSource = null;
            medarbejdere.DataSource = this._controller.MedarbejderListe;
            
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
