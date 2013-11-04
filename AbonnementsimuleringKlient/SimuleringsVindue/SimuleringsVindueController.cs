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
        private BrugsHistorikVindueController _brugsHisturikController; 
        private BrugerAdminVindueController _brugerAdminVindueController;

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

        public void SetControllers(BrugsHistorikVindueController brugsHisturikController, BrugerAdminVindueController brugerAdminVindueController)
        {
            this._brugsHisturikController = brugsHisturikController;
            this._brugerAdminVindueController = brugerAdminVindueController;
        }

        public void OpenBrugerHisturikVindue()
        {
            _brugsHisturikController.OpenVindue();
        }

        public void OpenBrugerAdminVindue()
        {
            _brugerAdminVindueController.OpenVindue();
        }
    }      
}
