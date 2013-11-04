using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface IBrugsHistorikVindue
    {
        List<BrugsHistorik> HentBrugsHistorik();

        void SetBrugsHistorikVindueController(BrugsHistorikVindueController controller);

        void OpenVindue();
        void CloseVindue();
    }
}
