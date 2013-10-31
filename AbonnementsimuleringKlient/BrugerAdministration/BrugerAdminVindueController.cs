using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    class BrugerAdminVindueController
    {
        private IBrugerAdminVindue brugerAdminVindue;
        private IBrugerDAO brugerDAO;

        public List<IBrugerDAO> medarbejderListe { get; set; }

        public BrugerAdminVindueController(IBrugerAdminVindue brugerAdminVindue, IBrugerDAO brugerDAO)
        {
            this.brugerAdminVindue = brugerAdminVindue;
            this.brugerDAO = brugerDAO;

            brugerAdminVindue.SetBrugerAdminVindueController(this);
        }

        public void OpenVindue()
        {
            brugerAdminVindue.OpenVindue();
        }

        public void CloseVindue()
        {
            brugerAdminVindue.CloseVindue();
        }
    }
}
