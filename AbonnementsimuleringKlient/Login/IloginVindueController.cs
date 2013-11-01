using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface ILoginVindueController
    {
        bool LoginVerificering(string brugernavn, string kodeord);

        void OpenVindue();
        void CloseVindue();

        void SetLoginVindueController(LoginVindueController controller);
    }
}
