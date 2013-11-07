using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface ISimuleringsDAO
    {
        List<string> HentXakse();
        List<double> HentYakse();
        void GenererNySimulering();
        List<string> HentSimuleringsListe();
        List<string> Xakse { get;}
        List<double> Yakse { get;}
      //  void HentSimulering(SimuleringsVindue.xAkseKey xKey, SimuleringsVindue.yAkseKey yKey, DateTime tidsStempel);
    }
}
