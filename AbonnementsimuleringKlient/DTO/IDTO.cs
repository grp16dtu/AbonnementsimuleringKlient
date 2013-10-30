using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface IDTO
    {
        List<Medarbejder> HentMedarbejderList();

        void SletMedarbejder();

        void OpretMedarbejder();

        void RedigerMedarbejder();

        List<string[]> HentBrugsHistorik(TidsInterval tidsInterval, HistorikType historikType, Id id);

        List<string> HentGrafDataDropdown();

        void KoerNySimulering();

        List<Simuleringer> HentSimuleringsListe();

        void HentEnkeltSimulering();

        void OpdaterEConomicsCredentials(string aftalenr, string brugernavn, string kodeord);

    }
}
