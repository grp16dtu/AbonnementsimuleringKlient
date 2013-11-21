using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface IBrugerDTO
    {
        string Fornavn { get; set; }
        string Efternavn { get; set; }
        int? MedarbejderNummer { get; set; }
        bool Ansvarlig { get; set; }
        //email bruges som unik identifier for brugernavn
        string Brugernavn { get; set; }
        string Kodeord { get; set; }
        void OpdaterBrugerDAO(string fornavn, string efternavn, int? medarbejderNummer, bool ansvarlig, string brugernavn, string kodeord);

        event EventHandler Changed;

    }
}
