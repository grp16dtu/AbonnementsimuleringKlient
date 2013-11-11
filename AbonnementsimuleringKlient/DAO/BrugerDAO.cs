using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public BrugerDAO(string fornavn, string efternavn, int id, bool ansvarlig)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.MedarbejderNummer = id;
            this.Ansvarlig = ansvarlig;
        }

        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
            {
                Changed(this, e);
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
