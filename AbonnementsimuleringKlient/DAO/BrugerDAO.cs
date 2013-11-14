using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbonnementsimuleringKlient
{
    public class BrugerDAO:IBrugerDAO
    {
        public event EventHandler Changed;

        private string _fornavn;
        private string _efternavn;
        private int? _medarbejderNummer;
        private bool _ansvarlig;
        private string _brugernavn;
        private string _kodeord;


        public BrugerDAO(string fornavn, string efternavn, int? medarbejderNummer, bool ansvarlig, string brugernavn)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.MedarbejderNummer = medarbejderNummer;
            this.Ansvarlig = ansvarlig;
            this.Brugernavn = brugernavn;
        }

        public void OpdaterBrugerDAO(string fornavn, string efternavn, int? medarbejderNummer, bool ansvarlig, string brugernavn)
        {
            _fornavn = fornavn;
            _efternavn = efternavn;
            _medarbejderNummer = medarbejderNummer;
            _ansvarlig = ansvarlig;
            _brugernavn = brugernavn;
            OnChanged(EventArgs.Empty);
        }
        protected virtual void OnChanged(EventArgs e)
        {
            EventHandler handler = Changed;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public string Fornavn
        {
            get
            {
                return _fornavn;
            }
            set
            {
                _fornavn = value;
                OnChanged(EventArgs.Empty);
            }
        }

        public string Efternavn
        {
            get
            {
                return _efternavn;
            }
            set
            {
                _efternavn = value;
                OnChanged(EventArgs.Empty);
            }
        }
        public int? MedarbejderNummer 
        { 
            get
            {
                return _medarbejderNummer;
            }
            set
            {
                _medarbejderNummer = value;
                OnChanged(EventArgs.Empty);
            }
        }

        public bool Ansvarlig 
        { 
            get
            {
                return _ansvarlig;
            }
            set
            {
                _ansvarlig = value;
                OnChanged(EventArgs.Empty);
            }
        }

        public string Brugernavn
        {
            get
            {
                return _brugernavn;
            }
            set
            {
                _brugernavn = value;
                OnChanged(EventArgs.Empty);
            }
        }

        public string Kodeord
        {
            get
            {
                return _kodeord;
            }
            set
            {
                _kodeord = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }
}
