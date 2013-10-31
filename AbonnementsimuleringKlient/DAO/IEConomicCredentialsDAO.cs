using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbonnementsimuleringKlient
{
    interface IEConomicCredentialsDAO
    {
        string Brugernavn { get; set; }
        string Kodeord { get; set; }
        string Aftalenummer { get; set; }

        bool LoginVerificering();
        string KrypterKodeord(string kodeord);
        string DekrypterKodeord(string kodeord);
    }
}
