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
        private BrugsHistorikVindueController _brugsHistorikController; 
        private BrugerAdminVindueController _brugerAdminVindueController;

        public SimuleringsVindueController(ISimuleringsVindue simuleringsVindue, ISimuleringsDAO simuleringsDAO)
        {
            this.SimuleringsVindue = simuleringsVindue;
            this.SimuleringsDAO = simuleringsDAO;

            SimuleringsVindue.SetSimuleringsVindueController(this);
        }

        public void OpenVindue() 
        {
            SimuleringsVindue.OpenVindue();
        }

        public void CloseVindue()
        {
            SimuleringsVindue.CloseVindue();
        }

        public void SetControllers(BrugsHistorikVindueController brugsHisturikController, BrugerAdminVindueController brugerAdminVindueController)
        {
            this._brugsHistorikController = brugsHisturikController;
            this._brugerAdminVindueController = brugerAdminVindueController;
        }
        /*
        internal void OpdaterVindue(AbonnementsimuleringKlient.SimuleringsVindue.xAkseKey xKey, AbonnementsimuleringKlient.SimuleringsVindue.yAkseKey yKey, DateTime tidsstempel)
        {
            SimuleringsDAO.HentSimulering(xKey, yKey, tidsstempel);
        }
         */
        public void OpenBrugerHisturikVindue()
        {
            _brugsHistorikController.OpenVindue();
        }

        public void OpenBrugerAdminVindue()
        {
            _brugerAdminVindueController.OpenVindue();
        }
    }      
}
