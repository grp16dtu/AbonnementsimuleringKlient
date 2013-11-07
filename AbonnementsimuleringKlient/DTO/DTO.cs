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
        private HttpResponseMessage response;

        private IDTO iDTO;

        private static DTO instance;
        private DTO()
        {
            httpKlient = new HttpClient();
            httpKlient.BaseAddress = new Uri("http://grp16dtu-001-site1.smarterasp.net:80/");

            httpKlient.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //singleton
        public static DTO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DTO();
                }
                return instance;
            }
        }

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


        //public void HentSimulering(SimuleringsVindue.xAkseKey xKey, SimuleringsVindue.yAkseKey yKey, DateTime tidsStempel)
        //{
        //    throw new NotImplementedException();
        //}

        public IBrugerDAO LoginVerificering(string brugernavn, string kodeord)
        {
            response = httpKlient.GetAsync("API/bruger/hent/?brugernavn=" + brugernavn + "&kodeord=" + kodeord).Result;
            if(response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<BrugerDAO>().Result;
            }
            else 
            {
                return null;
            }
            
        }


        public ISimuleringsDAO HentNyesteSimulering(string xAkse, string yAkse)
        {
            //TODO: TEST og ret
            response = httpKlient.GetAsync("API/bruger/hent/?xakse=" + xAkse + "&yakse=" + yAkse).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<ISimuleringsDAO>().Result;
            }
            else
            {
                return null;
            }
        }
    }
}
