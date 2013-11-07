using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface IDTO
    {
        List<IBrugerDAO> HentMedarbejderList();

        void SletMedarbejder();

        void OpretMedarbejder();

        void RedigerMedarbejder();

        List<string[]> HentBrugsHistorik();

        List<string> HentGrafDataDropdown();

        void KoerNySimulering();

        List<SimuleringsDAO> HentSimuleringsListe();

        void HentEnkeltSimulering();

        void OpdaterEConomicsCredentials(string aftalenr, string brugernavn, string kodeord);


        //void HentSimulering(SimuleringsVindue.xAkseKey xKey, SimuleringsVindue.yAkseKey yKey, DateTime tidsStempel);
        ILoginBruger LoginVerificering(ILoginBruger bruger);
        static DTO Instance { get; }
    }
}
