using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AbonnementsimuleringKlient
{
    public class DTO : IDTO
    {
        private HttpClient httpKlient;

        private IDTO iDTO;

        public List<IBrugerDAO> HentMedarbejderList()
        {
            throw new NotImplementedException();
        }

        public void SletMedarbejder()
        {
            throw new NotImplementedException();
        }

        public void OpretMedarbejder()
        {
            throw new NotImplementedException();
        }

        public void RedigerMedarbejder()
        {
            throw new NotImplementedException();
        }

        public List<string[]> HentBrugsHistorik()
        {
            throw new NotImplementedException();
        }

        public List<string> HentGrafDataDropdown()
        {
            throw new NotImplementedException();
        }

        public void KoerNySimulering()
        {
            throw new NotImplementedException();
        }

        public List<SimuleringsDAO> HentSimuleringsListe()
        {
            throw new NotImplementedException();
        }

        public void HentEnkeltSimulering()
        {
            throw new NotImplementedException();
        }

        public void OpdaterEConomicsCredentials(string aftalenr, string brugernavn, string kodeord)
        {
            throw new NotImplementedException();
        }


        public void HentSimulering(SimuleringsVindue.xAkseKey xKey, SimuleringsVindue.yAkseKey yKey, DateTime tidsStempel)
        {
            throw new NotImplementedException();
        }
    }
}
