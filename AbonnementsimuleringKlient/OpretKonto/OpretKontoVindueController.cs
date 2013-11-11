using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class OpretKontoVindueController
    {
        private IOpretKontoVindue _opretKontoVindue;
        private Konto _konto;
        private IBrugerDAO _BrugerDAO;

        public OpretKontoVindueController(IOpretKontoVindue opretKontoVindue)
        {
            this._opretKontoVindue = opretKontoVindue;
            _konto = new Konto();

            opretKontoVindue.SetOpretKontoVindueController(this);
        }

        public void OpenVindue()
        {
            _opretKontoVindue.OpenVindue();
        }

        public bool OpretKonto(string economicAftalenummer,string economicBrugernavn,string economicKodeord,string 
                fornavn,string efternavn,string medarbjederNummer,string brugernavn,string kodeord)
        {

            _konto.EconomicAftalenummer = int.Parse(economicAftalenummer);
            _konto.EconomicBrugernavn = economicBrugernavn;
            _konto.EconomicKodeord = economicKodeord;
            _BrugerDAO = new BrugerDAO(fornavn,efternavn,int.Parse(medarbjederNummer),true,brugernavn,kodeord);  
            // brugernavn og kodeord skal tilføjes i BrugerDAO construkter 

            return true;
        }

    }
}
