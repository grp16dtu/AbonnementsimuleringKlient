using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface IOpretKontoVindue
    {
        void OpenVindue();
        void CloseVindue();
        void SetOpretKontoVindueController(OpretKontoVindueController controller);
    }
}
