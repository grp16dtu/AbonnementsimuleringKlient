using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class BrugerAdminVindueController
    {
        private IBrugerAdminVindue _brugerAdminVindue;
        private IBrugerDAO _brugerDAO;
        private IndstillingerVindueController _indstillingerVindueController;


        public List<IBrugerDAO> medarbejderListe { get; set; }

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

        public void OpenVindue()
        {
            _brugerAdminVindue.OpenVindue();
        }

        public void CloseVindue()
        {
            _brugerAdminVindue.CloseVindue();
        }
    }
}
