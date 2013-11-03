using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbonnementsimuleringKlient
{
    class EConomicCredentialsDAO : IEConomicCredentialsDAO
    {
        public string Brugernavn { get; set; }
        public string Kodeord { get; set; }
        public string Aftalenummer { get; set; }
    }
}
