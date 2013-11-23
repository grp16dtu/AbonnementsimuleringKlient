using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

using System.Windows.Forms;

namespace AbonnementsimuleringKlient
{
    public class DAO : IDAO
    {
        private HttpClient httpKlient;
        private HttpResponseMessage response;
        private static DAO instance;

        private DAO()
        {
            httpKlient = new HttpClient();
            httpKlient.BaseAddress = new Uri("http://grp16dtu-001-site1.smarterasp.net:80/");
            httpKlient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //singleton
        public static DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO();
                }
                return instance;
            }
        }

        public async Task<List<BrugerDTO>> HentMedarbejderList()
        {
            response = httpKlient.GetAsync("API/Bruger/Hentalle/").Result;
            var liste = await response.Content.ReadAsAsync<List<BrugerDTO>>();
            if (response.IsSuccessStatusCode)
            {
                return liste;
            }
            else
            {
                return null;
            }
        }

        public bool SletMedarbejder(string brugernavn)
        {
            response = httpKlient.DeleteAsync("API/Bruger/Slet/" + brugernavn).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OpretMedarbejder(IBrugerDTO bruger)
        {
            response = httpKlient.PostAsJsonAsync<IBrugerDTO>("API/Bruger/Opret/", bruger).Result;
            return response.IsSuccessStatusCode;
        }

        public bool RedigerMedarbejder(IBrugerDTO bruger)
        {
            response = httpKlient.PutAsJsonAsync<IBrugerDTO>("API/Bruger/Rediger/", bruger).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void KoerNySimulering(int index)
        {
            response = httpKlient.GetAsync("Api/Simulering/Ny/"+index+"/").Result;
        }


        public async Task <List<Datapunktsgruppering>> HentSimuleringsListe()
        {
            response = httpKlient.GetAsync("Api/Datapunkter/Hentoversigt/").Result;
            return response.Content.ReadAsAsync<List<Datapunktsgruppering>>().Result;
        }

        public DatapunktLister HentEnkeltSimulering(int index)
        {
            response = httpKlient.GetAsync("Api/Datapunkter/Hentalle/"+index).Result;
            return response.Content.ReadAsAsync<DatapunktLister>().Result;
        }

        public IBrugerDTO LoginVerificering(string brugernavn, string kodeord)
        {
            httpKlient.DefaultRequestHeaders.Authorization = CreateBasicHeader(brugernavn, kodeord);

            response = httpKlient.GetAsync("API/Bruger/Hent/?brugernavn=" + brugernavn + "&kodeord=" + kodeord).Result;
            if(response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<BrugerDTO>().Result;
            }
            else 
            {
                return null;
            }
            
        }

        public AuthenticationHeaderValue CreateBasicHeader(string username, string password)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(username + ":" + password);
            return new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        public bool OpretKonto(Konto konto)
        {
            response = httpKlient.PostAsJsonAsync("API/konto/opret/", konto).Result;
            var statuskode = response.StatusCode.ToString();
            var svar = response.Content.ReadAsStringAsync().Result;

            if(statuskode == "OK")
            {
                MessageBox.Show(svar);
                return true;
            }
            else
            {
                MessageBox.Show(svar);
                return false;
            }
        }
    }
}
