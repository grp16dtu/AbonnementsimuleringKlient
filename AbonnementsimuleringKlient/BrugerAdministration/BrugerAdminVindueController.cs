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
        public List<IBrugerDAO> medarbejderListe { get; set; }

        public List<IBrugerDAO> getTempListTEST(EventHandler handler)
        {
            List<IBrugerDAO> tempList = new List<IBrugerDAO>();

            IBrugerDAO first = new BrugerDAO("Mads", "Slotsbo", 1, true, "hallo");
            IBrugerDAO second = new BrugerDAO("Bjørn", "Andersen", 2, false, "hallo");
            IBrugerDAO third = new BrugerDAO("Lasse", "Redlaz", 3, false, "hallo");
            IBrugerDAO fourth = new BrugerDAO("Jesper", "Baltzersen", null, false, "hallo");
            tempList.Add(first);
            tempList.Add(second);
            tempList.Add(third);
            tempList.Add(fourth);
            return tempList;
        }

        public BrugerAdminVindueController(IBrugerAdminVindue brugerAdminVindue)
        {
            this._brugerAdminVindue = brugerAdminVindue;
            brugerAdminVindue.SetBrugerAdminVindueController(this);
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
    }
}