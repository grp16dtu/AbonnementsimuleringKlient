using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbonnementsimuleringKlient
{
    public class BrugerDAO:IBrugerDAO
    {
        public event EventHandler Changed;

<<<<<<< ours
        private string _fornavn;
        private string _efternavn;
        private int _medarbejderNummer;
        private bool _ansvarlig;
        private string _brugernavn;
        private string _kodeord;


=======
        private IDTO DTO;
        private string _fornavn;
        private string _efternavn;
        private int _medarbejderNummer;
        private bool _ansvarlig;
        private string _brugernavn;
        private string _kodeord;


>>>>>>> theirs
        public string Fornavn
        {
            get
            {
<<<<<<< ours
                return _fornavn;
=======
                return _fornavn;
>>>>>>> theirs
            }
            set
            {
<<<<<<< ours
                _fornavn = value;
=======
                _fornavn = value;
>>>>>>> theirs
                OnChanged(EventArgs.Empty);
            }
        }

        public string Efternavn
        {
            get
            {
<<<<<<< ours
                return _efternavn;
=======
                return _efternavn;
>>>>>>> theirs
            }
            set
            {
<<<<<<< ours
                _efternavn = value;
=======
                _efternavn = value;
>>>>>>> theirs
                OnChanged(EventArgs.Empty);
            }
        }
        public int MedarbejderNummer 
        { 
            get
            {
<<<<<<< ours
                return _medarbejderNummer;
=======
                return _medarbejderNummer;
>>>>>>> theirs
            }
            set
            {
<<<<<<< ours
                _medarbejderNummer = value;
=======
                _medarbejderNummer = value;
>>>>>>> theirs
                OnChanged(EventArgs.Empty);
            }
        }

<<<<<<< ours
        public bool Ansvarlig 
=======
        public bool Ansvarlig 
>>>>>>> theirs
        { 
            get
            {
<<<<<<< ours
                return _ansvarlig;
=======
                return _ansvarlig;
>>>>>>> theirs
            }
            set
            {
<<<<<<< ours
                _ansvarlig = value;
=======
                _ansvarlig = value;
>>>>>>> theirs
                OnChanged(EventArgs.Empty);
            }
        }

        public BrugerDAO(string fornavn, string efternavn, int id, bool ansvarlig)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.MedarbejderNummer = id;
<<<<<<< ours
            this.Ansvarlig = ansvarlig;
=======
            this.Ansvarlig = ansvarlig;
>>>>>>> theirs
        }

        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
            {
                Changed(this, e);
            }
        }
<<<<<<< ours


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
=======


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
>>>>>>> theirs
    }
}
