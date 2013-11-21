using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class LoginVindueController
    {
        private LoginVindue _loginVindue;
        private SimuleringsVindueController _simuleringsVindueController;
        private OpretKontoVindueController _opretKontoVindueController;
        private IDAO _iDAO;
        private IBrugerDTO _aktuelBruger;

        public LoginVindueController(LoginVindue loginVindue)
        {
            this._loginVindue = loginVindue;
            this._iDAO = DAO.Instance;
            

            loginVindue.SetLoginVindueController(this);
        }

        public void SetControllers(SimuleringsVindueController simuleringsVindueController, OpretKontoVindueController opretKontoVindueController)
        {
            this._opretKontoVindueController = opretKontoVindueController;
            this._simuleringsVindueController = simuleringsVindueController;
        }

        public void OpenSimuleringsVindue()
        {
            _simuleringsVindueController.OpenVindue(_aktuelBruger);
        }

        public void OpenOpretKontoVindue()
        {
            _opretKontoVindueController.OpenVindue();
        }

        public bool LoginVerificering(string brugernavn, string kodeord)
        {
            _aktuelBruger =_iDAO.LoginVerificering(brugernavn, kodeord);
            return (_aktuelBruger != null);
        }
    
        public void OpenVindue()
        {
            _loginVindue.OpenVindue();
        }

        public void CloseVindue()
        {
            _loginVindue.CloseVindue();
        }     
    }
}
