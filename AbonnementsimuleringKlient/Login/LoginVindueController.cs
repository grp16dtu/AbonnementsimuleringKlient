using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    class LoginVindueController : ILoginVindueController
    {
        private IEConomicCredentialsDAO eConomicCredentialsDAO;
        private LoginVindue loginVindue;

        public LoginVindueController(LoginVindue loginVindue, IEConomicCredentialsDAO eConomicCredentialsDAO)
        {
            this.eConomicCredentialsDAO = eConomicCredentialsDAO;
            this.loginVindue = loginVindue;

            SetLoginVindueController(this);
        }

        public bool LoginVerificering(string brugernavn, string kodeord)
        {
            eConomicCredentialsDAO.Brugernavn = brugernavn;
            eConomicCredentialsDAO.Kodeord = kodeord;
            return eConomicCredentialsDAO.LoginVerificering();
        }

        public void OpenVindue()
        {
            throw new NotImplementedException();
        }

        public void CloseVindue()
        {
            throw new NotImplementedException();
        }

        public void SetLoginVindueController(LoginVindueController controller)
        {
            throw new NotImplementedException();
        }
    }
}
