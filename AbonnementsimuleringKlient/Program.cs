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
            EConomicCredentialsDAO eConomicCredentialsDAO = new EConomicCredentialsDAO();
            LoginVindue loginVindue;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(loginVindue = new LoginVindue());

            LoginVindueController loginVindueController = new LoginVindueController(

            SimuleringsDAO simuleringsDAO = new SimuleringsDAO();
            SimuleringsVindue simuleringsVindue = new SimuleringsVindue();
            SimuleringsVindueController simuleringsVindueController = new SimuleringsVindueController(simuleringsVindue, simuleringsDAO);
        }
    }
}
