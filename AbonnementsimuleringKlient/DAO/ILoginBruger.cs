using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface ILoginBruger
    {
        string Brugernavn { get; set; }
        string Kodeord { get; set; }
        bool Ansvarlig { get; set; }
        

      
    }
}
