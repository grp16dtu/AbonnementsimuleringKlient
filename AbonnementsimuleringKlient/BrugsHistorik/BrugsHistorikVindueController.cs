using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class BrugsHistorikVindueController
    {
        private IBrugsHistorikVindue _brugsHistorikVindue;
        private IBrugsHistorik _brugsHistorik;
        private IBrugerDAO _aktuelBruger;

        public BrugsHistorikVindueController(IBrugsHistorikVindue brugsHistorikVindue, IBrugsHistorik brugsHistorik)
        {
            this._brugsHistorikVindue = brugsHistorikVindue;
            this._brugsHistorik = brugsHistorik;
            _brugsHistorikVindue.SetBrugsHistorikVindueController(this);
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

        public void OpenVindue(IBrugerDAO bruger)
        {
            this._brugsHistorikVindue.OpenVindue();
            this._aktuelBruger = bruger;
        }

        public void CloseVindue()
        {
            _brugsHistorikVindue.CloseVindue();
        }
    }
}
