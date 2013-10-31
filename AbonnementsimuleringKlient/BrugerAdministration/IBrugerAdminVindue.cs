using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface IBrugerAdminVindue
    {
        /// <summary>
        /// Åbner vinduet Instillinger
        /// </summary>
        void HentIndstillingerVindue();

        /// <summary>
        /// Sender en forespoergsel til serveren om at oprette en bruger
        /// </summary>

        //TODO: Tilfoej argumenter, som er brugeren?
        void OpretBruger();

        /// <summary>
        /// Sender en forespoergsle til serveren om at slette en bruger
        /// </summary>

        //TODO: Tilfoej argumenter, som er brugeren?
        void SletBruger();

        /// <summary>
        /// Sender en forespoergsle til serveren om at gemme en bruger
        /// </summary>
        
        //TODO: Tilfoej argumenter, som er brugeren?
        void GemBruger();

        /// <summary>
        /// Sender en forespørgsel til serveren om at hente en bestemt bruger
        /// </summary>
   
        //TODO: Tilfoej argumenter, som identificerer brugeren?
        void MedarbejderFraListe();

        /// <summary>
        /// Sender en forespørgsel til serveren om at hente listen over brugere
        /// </summary>
        void HentMedarbejderListe();

        void SetBrugerAdminVindueController(BrugerAdminVindueController controller);

        void OpenVindue();

        void CloseVindue();
    }
}
