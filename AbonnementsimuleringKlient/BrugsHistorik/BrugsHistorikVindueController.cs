using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    class BrugsHistorikVindueController
    {
        private IBrugsHistorikVindue brugsHistorikVindue;
        private IBrugsHistorik brugsHistorik;

        public BrugsHistorikVindueController(IBrugsHistorikVindue brugsHistorikVindue, IBrugsHistorik brugsHistorik)
        {
            this.brugsHistorikVindue = brugsHistorikVindue;
            this.brugsHistorik = brugsHistorik;
        }

        public List<BrugsHistorik> HentBrugsHistorik()
        {
            throw new NotImplementedException();
        }

        public void Id_klikket()
        {
            throw new NotImplementedException();
        }

        public void TidsStempel_klikket()
        {
            throw new NotImplementedException();
        }

        public void HistorikType_klikket()
        {
            throw new NotImplementedException();
        }

        public void OpenVindue()
        {
            brugsHistorikVindue.OpenVindue();
        }

        public void CloseVindue()
        {
            brugsHistorikVindue.CloseVindue();
        }
    }
}
