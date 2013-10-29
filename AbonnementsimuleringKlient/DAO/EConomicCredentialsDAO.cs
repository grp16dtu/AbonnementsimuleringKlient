using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbonnementsimuleringKlient
{
    class EConomicCredentialsDAO
    {
        public string Brugernavn { get; set; }
        public string Kodeord { get; set; }
        public string Aftalenummer { get; set; }

        private IDTO DTO;

        public bool LoginVerificering()
        {
            throw new NotImplementedException();
        }

        private string KrypterKodeord(string kodeord)
        {
            return "";
        }

        private string DekrypterKodeord(string kodeord)
        {
            return "";
        }
    }
}
