using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface IIndstillingerVindue
    {
        /// <summary>
        /// Henter credentials i form af DAO fra db gennem DTO
        /// </summary>
        /// <param name="brugernavn">EConomic brugernavn</param>
        /// <returns>EConomicCredentialsObject er DAO for EConomic credentials</returns>
        EConomicCredentialsDAO HentCredentials(string brugernavn);
        /// <summary>
        /// Gemmer credentials fra DAO i db gennem DTO
        /// </summary>
        /// <param name="eConomicCredentialsObject">DAO for EConomic account credentials</param>
        void GemCredentials(EConomicCredentialsDAO eConomicCredentialsObject);

        void SetIndstillingerVindueController(IndstillingerVindueController controller);

        void OpenVindue();

        void CloseVindue();
    }
}
