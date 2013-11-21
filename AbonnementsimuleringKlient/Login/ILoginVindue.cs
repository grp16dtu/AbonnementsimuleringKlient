using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface ILoginVindue
    {
        void OpenVindue();
        void CloseVindue();

        void SetLoginVindueController(LoginVindueController controller);
    }
}
