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
        private IDTO _dto;


        public OpretKontoVindueController(IOpretKontoVindue opretKontoVindue)
        {
            this._opretKontoVindue = opretKontoVindue;
            _konto = new Konto();
            _dto = DTO.Instance;
            opretKontoVindue.SetOpretKontoVindueController(this);
        }

        public void OpenVindue()
        {
            _opretKontoVindue.OpenVindue();
        }

        public bool OpretKonto(string economicAftalenummer,string economicBrugernavn,string economicKodeord,string 
                fornavn,string efternavn,string medarbjederNummer,string brugernavn,string kodeord)
        {
            if(economicAftalenummer.Length > 6 || economicAftalenummer.Length == 0)
            {
                _opretKontoVindue.AftalenummerfejlShow();
                return false;
            }
            else
            {
                _konto.EconomicAftalenummer = Convert.ToInt32(economicAftalenummer);
                _opretKontoVindue.AftalenummerfejlHide();
                _konto.EconomicBrugernavn = economicBrugernavn;
                _konto.EconomicKodeord = economicKodeord;
                _BrugerDAO = new BrugerDAO(fornavn,efternavn,Convert.ToInt32(medarbjederNummer),true,brugernavn,kodeord);
                _konto.AbosimBruger = _BrugerDAO;
                return _dto.OpretKonto(_konto);
            }
        }

    }
}
