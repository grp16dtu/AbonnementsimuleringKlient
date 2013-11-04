using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface ISimuleringsVindue
    {
        List<string> VisSimuleringsListe();
        SimuleringsDAO VisValgteSimulering(string tidsstempel);
        void GenererNySimulering(int index);
        void BrugerAdministration();
        void XAkse();
        void YAkse();

        void OpenVindue();

        void CloseVindue();
        void SetSimuleringsVindueController(SimuleringsVindueController controller);
    }
}
