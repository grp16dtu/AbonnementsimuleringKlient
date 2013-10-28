using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface IIndstillingerController
    {
        /// <summary>
        /// Henter credentials i form af DAO fra db gennem DTO
        /// </summary>
        /// <param name="brugernavn">EConomic brugernavn</param>
        /// <returns>EConomicCredentialsObject er DAO for EConomic credentials</returns>
        public EConomicCredentialsDAO HentCredentials(string brugernavn);
        /// <summary>
        /// Gemmer credentials fra DAO i db gennem DTO
        /// </summary>
        /// <param name="eConomicCredentialsObject">DAO for EConomic account credentials</param>
        public void GemCredentials(EConomicCredentialsDAO eConomicCredentialsObject);
    }
}
