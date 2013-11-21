using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface IDAO
    {
        Task<List<BrugerDTO>> HentMedarbejderList();

        bool SletMedarbejder(string brugernavn);

        bool OpretMedarbejder(IBrugerDTO bruger);

        bool RedigerMedarbejder(IBrugerDTO bruger);

        void KoerNySimulering(int index);

        Task<List<Datapunktsgruppering>> HentSimuleringsListe();

        DatapunktLister HentEnkeltSimulering(int index);

        ISimuleringsDTO HentNyesteSimulering(string xAkse, string yAkse);

        IBrugerDTO LoginVerificering(string brugernavn, string kodeord);

        bool OpretKonto(Konto konto);
    }
}
