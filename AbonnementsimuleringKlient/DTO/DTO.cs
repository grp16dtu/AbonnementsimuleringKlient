﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

using System.Windows.Forms;

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
            httpKlient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
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

        public async Task<List<BrugerDAO>> HentMedarbejderList()
        {

            response = httpKlient.GetAsync("API/Bruger/Hentalle/").Result;
          
            //MessageBox.Show(response.ToString());

            var liste = await response.Content.ReadAsAsync<List<BrugerDAO>>();


            if (response.IsSuccessStatusCode)
            {
                return liste;
            }
            else
            {
                //MessageBox.Show(response.ToString());
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

        public bool OpretMedarbejder(IBrugerDAO bruger)
        {
            response = httpKlient.PostAsJsonAsync<IBrugerDAO>("API/Bruger/Opret/", bruger).Result;
            //MessageBox.Show(response.ToString());
            return response.IsSuccessStatusCode;
        }

        public bool RedigerMedarbejder(IBrugerDAO bruger)
        {
            response = httpKlient.PutAsJsonAsync<IBrugerDAO>("API/Bruger/Rediger/", bruger).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string[]> HentBrugsHistorik()
        {
            throw new NotImplementedException();
        }

        public List<string> HentGrafDataDropdown()
        {
            throw new NotImplementedException();
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

        public void OpdaterEConomicsCredentials(string aftalenr, string brugernavn, string kodeord)
        {
            throw new NotImplementedException();
        }

        public IBrugerDAO LoginVerificering(string brugernavn, string kodeord)
        {
            httpKlient.DefaultRequestHeaders.Authorization = CreateBasicHeader(brugernavn, kodeord);

            response = httpKlient.GetAsync("API/Bruger/Hent/?brugernavn=" + brugernavn + "&kodeord=" + kodeord).Result;
            if(response.IsSuccessStatusCode)
            {
                //MessageBox.Show(response.Content.ReadAsStringAsync().Result);
                return response.Content.ReadAsAsync<BrugerDAO>().Result;
            }
            else 
            {
                //MessageBox.Show(response.ToString());
                return null;
            }
            
        }

        public AuthenticationHeaderValue CreateBasicHeader(string username, string password)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(username + ":" + password);
            return new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }


        public ISimuleringsDAO HentNyesteSimulering(string xAkse, string yAkse)
        {
            var getString = "API/Datapunkter/";

            switch (xAkse)
            {
                case "Tid":
                    getString += "/Datapunkter/TidDkk/";
                    break;
            }
            //TODO: TEST og ret
            response = httpKlient.GetAsync(getString).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<ISimuleringsDAO>().Result;
            }
            else
            {
                return null;
            }
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
