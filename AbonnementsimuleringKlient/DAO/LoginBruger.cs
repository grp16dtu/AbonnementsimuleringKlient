using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    class LoginBruger: ILoginBruger
    {
        public string Brugernavn { get; set; }
        public string Kodeord { get; set; }
        public bool Ansvarlig { get; set; }
     
        public LoginBruger(string brugernavn, string kodeord, bool ansvarlig)
        {
            this.Brugernavn = brugernavn;
            this.Kodeord = kodeord;
            this.Ansvarlig = ansvarlig;
        }

        public LoginBruger(string brugernavn, string kodeord)
        {
            this.Brugernavn = brugernavn;
            this.Kodeord = kodeord;
        }
    
    }

}
