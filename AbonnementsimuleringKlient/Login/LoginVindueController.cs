using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class LoginVindueController
    {
        private IEConomicCredentialsDAO eConomicCredentialsDAO;
        private LoginVindue _loginVindue;
        private SimuleringsVindueController _simuleringsVindueController;

        public LoginVindueController(LoginVindue loginVindue, IEConomicCredentialsDAO eConomicCredentialsDAO)
        {
            this.eConomicCredentialsDAO = eConomicCredentialsDAO;
            this._loginVindue = loginVindue;

            loginVindue.SetLoginVindueController(this);
        }

        public void SetControllers(SimuleringsVindueController simuleringsVindueController)
        {
            this._simuleringsVindueController = simuleringsVindueController;
        }

        public void OpenSimuleringsVindue()
        {
            _simuleringsVindueController.OpenVindue();
        }

        public bool LoginVerificering(string brugernavn, string kodeord)
        {
            eConomicCredentialsDAO.Brugernavn = brugernavn;
            eConomicCredentialsDAO.Kodeord = kodeord;
            return eConomicCredentialsDAO.LoginVerificering();
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
