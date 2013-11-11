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
        private IDTO _dto;
        private IBrugerDAO _aktuelBruger;

        public LoginVindueController(LoginVindue loginVindue, IEConomicCredentialsDAO eConomicCredentialsDAO)
        {
            this._loginVindue = loginVindue;
            this._dto = DTO.Instance;
            

            loginVindue.SetLoginVindueController(this);
        }

        public void SetControllers(SimuleringsVindueController simuleringsVindueController)
        {
            this._simuleringsVindueController = simuleringsVindueController;
        }

        public void OpenSimuleringsVindue()
        {
            _simuleringsVindueController.OpenVindue(_aktuelBruger);
        }

        public bool LoginVerificering(string brugernavn, string kodeord)
        {
            _aktuelBruger =_dto.LoginVerificering(brugernavn, kodeord);
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

        public string KrypterKodeord(string kodeord)
        {
            return "";
        }
        
    }
}
