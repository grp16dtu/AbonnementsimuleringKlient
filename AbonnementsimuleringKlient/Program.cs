using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonnementsimuleringKlient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpretKontoVindue opretKontoVindue = new OpretKontoVindue();
            OpretKontoVindueController opretKontoVindueController = new OpretKontoVindueController(opretKontoVindue);

            LoginVindue loginVindue = new LoginVindue();
            LoginVindueController loginVindueController = new LoginVindueController(loginVindue);

            SimuleringsDTO simuleringsDTO = new SimuleringsDTO();
            SimuleringsVindue simuleringsVindue = new SimuleringsVindue();
            SimuleringsVindueController simuleringsVindueController = new SimuleringsVindueController(simuleringsVindue, simuleringsDTO);

            BrugerAdminVindue brugerAdminVindue = new BrugerAdminVindue();
            BrugerAdminVindueController brugerAdminVindueController = new BrugerAdminVindueController(brugerAdminVindue);

            loginVindueController.SetControllers(simuleringsVindueController,opretKontoVindueController);
            simuleringsVindueController.SetControllers(brugerAdminVindueController);
            
            Application.Run(loginVindue);

        }
    }
}
