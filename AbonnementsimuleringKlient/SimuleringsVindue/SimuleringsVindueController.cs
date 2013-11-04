using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class SimuleringsVindueController
    {
        ISimuleringsVindue SimuleringsVindue { get; set; }
        ISimuleringsDAO SimuleringsDAO { get; set; }

        public SimuleringsVindueController(ISimuleringsVindue simuleringsVindue, ISimuleringsDAO simuleringsDAO)
        {
            this.SimuleringsVindue = simuleringsVindue;
            this.SimuleringsDAO = simuleringsDAO;
        }

        public void OpenVindue() 
        {
            SimuleringsVindue.OpenVindue();
        }

        public void CloseVindue()
        {
            SimuleringsVindue.CloseVindue();
        }

        internal void OpdaterVindue(AbonnementsimuleringKlient.SimuleringsVindue.xAkseKey xKey, AbonnementsimuleringKlient.SimuleringsVindue.yAkseKey yKey, DateTime tidsstempel)
        {
            SimuleringsDAO.HentSimulering(xKey, yKey, tidsstempel);
        }
    }      
}
