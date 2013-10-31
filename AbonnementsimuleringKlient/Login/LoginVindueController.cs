using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    class LoginVindueController : ILoginVindueController
    {
        private IEConomicCredentialsDAO EConomicCredentialsDAO = new EConomicCredentialsDAO();

        public bool LoginVerificering(string brugernavn, string kodeord)
        {
            EConomicCredentialsDAO.Brugernavn = brugernavn;
            EConomicCredentialsDAO.Kodeord = kodeord;
            return EConomicCredentialsDAO.LoginVerificering();
        }

    }
}
