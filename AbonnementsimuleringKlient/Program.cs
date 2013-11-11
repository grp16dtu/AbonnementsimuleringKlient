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
        /// lsieudzjfhdfs,djfskuc
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            EConomicCredentialsDAO eConomicCredentialsDAO = new EConomicCredentialsDAO();

            OpretKontoVindue opretKontoVindue = new OpretKontoVindue();
            OpretKontoVindueController opretKontoVindueController = new OpretKontoVindueController(opretKontoVindue);

            LoginVindue loginVindue = new LoginVindue();
            LoginVindueController loginVindueController = new LoginVindueController(loginVindue);

            SimuleringsDAO simuleringsDAO = new SimuleringsDAO();
            SimuleringsVindue simuleringsVindue = new SimuleringsVindue();
            SimuleringsVindueController simuleringsVindueController = new SimuleringsVindueController(simuleringsVindue, simuleringsDAO);

            //BrugerDAO brugerDAO = new BrugerDAO();           den skal nok laves lidt anderledes

            BrugerAdminVindue brugerAdminVindue = new BrugerAdminVindue();
            BrugerAdminVindueController brugerAdminVindueController = new BrugerAdminVindueController(brugerAdminVindue);

            IndstillingerVindue indStillingerVindue = new IndstillingerVindue();
            IndstillingerVindueController indstillingerVindueController = new IndstillingerVindueController(indStillingerVindue, eConomicCredentialsDAO);

            BrugsHistorik brugsHistorik = new BrugsHistorik();
            BrugsHistorikVindue brugsHistorikVindue = new BrugsHistorikVindue();
            BrugsHistorikVindueController brugsHistorikVindueController = new BrugsHistorikVindueController(brugsHistorikVindue, brugsHistorik);

            loginVindueController.SetControllers(simuleringsVindueController,opretKontoVindueController);
            simuleringsVindueController.SetControllers(brugsHistorikVindueController, brugerAdminVindueController);
            brugerAdminVindueController.SetControllers(indstillingerVindueController);
            
            Application.Run(loginVindue);

        }
    }
}
