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

        List<Datapunktsgruppering> HentSimuleringsListe();

        DatapunktLister HentEnkeltSimulering(int index);

        ISimuleringsDAO HentNyesteSimulering(string xAkse, string yAkse);

        void OpdaterEConomicsCredentials(string aftalenr, string brugernavn, string kodeord);

        //void HentSimulering(SimuleringsVindue.xAkseKey xKey, SimuleringsVindue.yAkseKey yKey, DateTime tidsStempel);

        IBrugerDAO LoginVerificering(string brugernavn, string kodeord);

        bool OpretKonto(Konto konto);
    }
}
