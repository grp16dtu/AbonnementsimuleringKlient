using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbonnementsimuleringKlient
{
    interface IEConomicCredentialsDAO
    {
        bool LoginVerificering();
        string KrypterKodeord(string kodeord);
        string DekrypterKodeord(string kodeord);
    }
}
