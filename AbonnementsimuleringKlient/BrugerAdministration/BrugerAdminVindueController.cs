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
        private IBrugerDAO _aktuelBruger;
        private IDTO _dto;
        public List<IBrugerDAO> MedarbejderListe { get; set; }

        public BrugerAdminVindueController(IBrugerAdminVindue brugerAdminVindue)
        {
            this._brugerAdminVindue = brugerAdminVindue;
            brugerAdminVindue.SetBrugerAdminVindueController(this);
            _dto = DTO.Instance;
        }

        private void putEventOnBrugerDAO()
        {
            foreach (IBrugerDAO bruger in this.MedarbejderListe)
            {
                bruger.Changed += _brugerAdminVindue.OpdaterMedarbejderListe;
            }
        }




   

        public void OpenVindue(IBrugerDAO bruger)
        {
            this._brugerAdminVindue.OpenVindue();
            this._aktuelBruger = bruger;
        }

        public void CloseVindue()
        {
            _brugerAdminVindue.CloseVindue();
        }

        internal bool GemBruger(bool ansvarlig, string email, string fornavn, string efternavn, int? medarbejderNummer, int index)
        {
            this.MedarbejderListe[index].OpdaterBrugerDAO(fornavn, efternavn, medarbejderNummer, ansvarlig, email);
            bool opdateringLykkedes = this._dto.RedigerMedarbejder(this.MedarbejderListe[index]);
            HentMedarbejderListe(); 
            return opdateringLykkedes;
            
        }

        internal async void HentMedarbejderListe()
        {
            List<BrugerDAO> tempListe = await _dto.HentMedarbejderList();;
            MedarbejderListe = tempListe.ConvertAll(o => (IBrugerDAO)o);//Den laver en foreachløkke som kopierer de enkelte objekter, og konverterer dem til den anden liste

            putEventOnBrugerDAO();
            _brugerAdminVindue.OpdaterMedarbejderListe(null, EventArgs.Empty);

        }

        internal bool OpretBruger(bool ansvarlig, string email, string fornavn, string efternavn, int? medarbejderNummer, string kodeord)
        {
            IBrugerDAO bruger = new BrugerDAO(fornavn, efternavn, medarbejderNummer, ansvarlig, email, kodeord);
            bool brugerOprettet;
            brugerOprettet = _dto.OpretMedarbejder(bruger);
            if (brugerOprettet)
            {
                bruger.Changed += _brugerAdminVindue.OpdaterMedarbejderListe;
                MedarbejderListe.Add(bruger);
            }
            HentMedarbejderListe();
            return brugerOprettet;
        }
        internal bool SletBruger(IBrugerDAO bruger)
        {
            bool success = this._dto.SletMedarbejder(bruger.Brugernavn);
            HentMedarbejderListe();

            return success;

        }
    }
}