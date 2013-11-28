using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonnementsimuleringKlient
{
    public class BrugerAdminVindueController
    {
        private IBrugerAdminVindue _brugerAdminVindue;
        public IBrugerDTO AktuelBruger{get; private set;}
        private IDAO _iDAO;
        public List<IBrugerDTO> MedarbejderListe { get; set; }

        public BrugerAdminVindueController(IBrugerAdminVindue brugerAdminVindue)
        {
            this._brugerAdminVindue = brugerAdminVindue;
            brugerAdminVindue.SetBrugerAdminVindueController(this);
            _iDAO = DAO.Instance;
        }

        private void putEventOnBrugerDAO()
        {
            foreach (IBrugerDTO bruger in this.MedarbejderListe)
            {
                bruger.Changed += _brugerAdminVindue.OpdaterMedarbejderListe;
            }
        }




   

        public void OpenVindue(IBrugerDTO bruger)
        {
            this._brugerAdminVindue.OpenVindue();
            this.AktuelBruger = bruger;
        }

        public void CloseVindue()
        {
            _brugerAdminVindue.CloseVindue();
        }

        public bool GemBruger(bool ansvarlig, string email, string fornavn, string efternavn, int? medarbejderNummer, int index, string kodeord)
        {
            this.MedarbejderListe[index].OpdaterBrugerDAO(fornavn, efternavn, medarbejderNummer, ansvarlig, email, kodeord);
            bool opdateringLykkedes = this._iDAO.RedigerMedarbejder(this.MedarbejderListe[index]);
            _brugerAdminVindue.OpdaterMedarbejderListe(null, EventArgs.Empty);
            return opdateringLykkedes;
            
        }

        public async void HentMedarbejderListe()
        {
            List<BrugerDTO> tempListe = await _iDAO.HentMedarbejderList();
            MedarbejderListe = tempListe.ConvertAll(o => (IBrugerDTO)o);//Den laver en foreachløkke som kopierer de enkelte objekter, og konverterer dem til den anden liste

            putEventOnBrugerDAO();

        }

        public bool OpretBruger(bool ansvarlig, string email, string fornavn, string efternavn, int? medarbejderNummer, string kodeord)
        {
            IBrugerDTO bruger = new BrugerDTO(fornavn, efternavn, medarbejderNummer, ansvarlig, email, kodeord);
            bool brugerOprettet;
            brugerOprettet = _iDAO.OpretMedarbejder(bruger);
            if (brugerOprettet)
            {
                bruger.Changed += _brugerAdminVindue.OpdaterMedarbejderListe;
                MedarbejderListe.Add(bruger);
            }
            HentMedarbejderListe();
            return brugerOprettet;
        }

        public bool SletBruger(IBrugerDTO bruger)
        {
            bool success = this._iDAO.SletMedarbejder(bruger.Brugernavn);
            HentMedarbejderListe();
            _brugerAdminVindue.OpdaterMedarbejderListe(null, EventArgs.Empty);

            return success;
        }
    }
}