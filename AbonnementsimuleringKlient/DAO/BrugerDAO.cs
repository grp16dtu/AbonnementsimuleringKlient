using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbonnementsimuleringKlient
{
    public class BrugerDAO:IBrugerDAO
    {
        public event EventHandler Changed;

        private IDTO DTO;
        public string Fornavn
        {
            get
            {
                return Fornavn;
            }
            set
            {
                Fornavn = value;
                OnChanged(EventArgs.Empty);
            }
        }

        public string Efternavn
        {
            get
            {
                return Efternavn;
            }
            set
            {
                Efternavn = value;
                OnChanged(EventArgs.Empty);
            }
        }
        public int MedarbejderNummer 
        { 
            get
            {
                return MedarbejderNummer;
            }
            set
            {
                MedarbejderNummer = value;
                OnChanged(EventArgs.Empty);
            }
        }

        public bool ansvarlig 
        { 
            get
            {
                return ansvarlig;
            }
            set
            {
                ansvarlig = value;
                OnChanged(EventArgs.Empty);
            }
        }

        public BrugerDAO(string fornavn, string efternavn, int id, bool ansvarlig)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.MedarbejderNummer = id;
            this.ansvarlig = ansvarlig;
        }

        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
            {
                Changed(this, e);
            }
        }
    }
}
