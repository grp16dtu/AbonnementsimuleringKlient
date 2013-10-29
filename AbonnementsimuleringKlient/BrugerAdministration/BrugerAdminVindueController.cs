using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    class BrugerAdminVindueController : IBrugerAdminVindueController
    {
        private BrugerAdminVindue brugerAdminVindue;
        private IBrugerDAO iBrugerDAO;

        public List<IBrugerDAO> MedarbejderList { get; set; }


        public void HentIndstillingerVindue()
        {
            throw new NotImplementedException();
        }

        public void OpretBruger()
        {
            throw new NotImplementedException();
        }

        public void SletBruger()
        {
            throw new NotImplementedException();
        }

        public void GemBruger()
        {
            throw new NotImplementedException();
        }

        public void MedarbejderFraListe()
        {
            throw new NotImplementedException();
        }

        public void HentMedarbejderListe()
        {
            throw new NotImplementedException();
        }
    }
}
