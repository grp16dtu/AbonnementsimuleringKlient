using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface IBrugsHistorikVindueController
    {
        List<BrugsHistorik> HentBrugsHistorik();

        void Id_klikket();

        void TidsStempel_klikket();

        void HistorikType_klikket();
    }
}
