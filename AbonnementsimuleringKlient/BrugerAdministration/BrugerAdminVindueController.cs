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
        private IndstillingerVindueController _indstillingerVindueController;
        private IDTO _dto;
        public List<IBrugerDAO> MedarbejderListe { get; set; }

        public BrugerAdminVindueController(IBrugerAdminVindue brugerAdminVindue)
        {
            this._brugerAdminVindue = brugerAdminVindue;
            brugerAdminVindue.SetBrugerAdminVindueController(this);
            _dto = DTO.Instance;
        }
        public List<IBrugerDAO> getTempListTEST()
        {
            List<IBrugerDAO> tempList = new List<IBrugerDAO>();

            IBrugerDAO first = new BrugerDAO("Mads", "Slotsbo", 1, true, "hallo", "");
            IBrugerDAO second = new BrugerDAO("Bjørn", "Andersen", 2, false, "hallo", "");
            IBrugerDAO third = new BrugerDAO("Lasse", "Redlaz", 3, false, "hallo", "");
            IBrugerDAO fourth = new BrugerDAO("Jesper", "Baltzersen", null, false, "hallo", "");
            tempList.Add(first);
            tempList.Add(second);
            tempList.Add(third);
            tempList.Add(fourth);
          
            return tempList;
        }

        private void putEventOnBrugerDAO()
        {
            foreach (IBrugerDAO bruger in this.MedarbejderListe)
            {
                bruger.Changed += _brugerAdminVindue.OpdaterMedarbejderListe;
            }
        }


        public void SetControllers(IndstillingerVindueController indstillingerVindueController)
        {
            this._indstillingerVindueController = indstillingerVindueController;
        }

        public void OpenIndstilleringVindue()
        {
            _indstillingerVindueController.OpenVindue();
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

        internal void GemBruger(bool ansvarlig, string email, string fornavn, string efternavn, int? medarbejderNummer, int index)
        {
            this.MedarbejderListe[index].OpdaterBrugerDAO(fornavn, efternavn, medarbejderNummer, ansvarlig, email);
            //this._dto.GemBruger(fornavn, efternavn, medarbejderNummer, ansvarlig, email);
        }

        internal void HentMedarbejderListe()
        {
            MedarbejderListe = getTempListTEST(); //TODO TEST WARNING
            putEventOnBrugerDAO();
        }
    }
}