using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface ISimuleringsDAO
    {
        List<string> HentXakse();
        List<double> HentYakse();
        void GenererNySimulering();
        List<string> HentSimuleringsListe();
        List<string> Xakse { get; private set; }
        List<double> Yakse { get; private set; }
        void HentSimulering(SimuleringsVindue.xAkseKey xKey, SimuleringsVindue.yAkseKey yKey, string tidsStempel);
    }
}
