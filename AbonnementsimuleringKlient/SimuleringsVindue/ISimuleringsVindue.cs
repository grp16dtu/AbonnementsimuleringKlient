using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface ISimuleringsVindue
    {
        public List<string> VisSimuleringsListe();
        public SimuleringsDAO VisValgteSimulering(string tidsstempel);
        public void GenererNySimulering(int index);
        public void BrugerAdministration();
        public void XAkse();
        public void YAkse();

        void OpenVindue();

        void CloseVindue();
    }
}
