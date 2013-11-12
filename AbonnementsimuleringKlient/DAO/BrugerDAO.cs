using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbonnementsimuleringKlient
{
    public class BrugerDAO:IBrugerDAO,IObservable<IBrugerDAO>
    {
        public event EventHandler Changed;
        //public delegate void DataChanged(BrugerDAO bruger, EventArgs e);

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
        protected virtual void OnChanged(EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("hander maybe null");
            EventHandler handler = Changed;
            if (handler != null)
            {
                System.Windows.Forms.MessageBox.Show("hander not null");
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

        public IDisposable Subscribe(IObserver<IBrugerDAO> observer)
        {
            throw new NotImplementedException();
        }
    }
}
