using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class OpretKontoVindueController
    {
        private RegexUtilities _util;

        private IOpretKontoVindue _opretKontoVindue;
        private Konto _konto;
        private IBrugerDTO _brugerDTO;
        private IDAO _iDAO;


        public OpretKontoVindueController(IOpretKontoVindue opretKontoVindue)
        {
            this._opretKontoVindue = opretKontoVindue;
            _util = new RegexUtilities();
            _konto = new Konto();
            _iDAO = DAO.Instance;
            opretKontoVindue.SetOpretKontoVindueController(this);
        }

        public void OpenVindue()
        {
            _opretKontoVindue.OpenVindue();
        }

        public bool OpretKonto(string economicAftalenummer, string economicBrugernavn, string economicKodeord, string
                fornavn, string efternavn, string medarbjederNummer, string brugernavn, string kodeord)
        {
            if (economicAftalenummer == "" || economicBrugernavn == "" || economicKodeord == "" || fornavn == ""
                || efternavn == "" || medarbjederNummer == "" || brugernavn == "" || kodeord == "")
            {
                _opretKontoVindue.FeltIkkeUdfyldtShow();
                return false;
            }
            else
            {
                _opretKontoVindue.MedarbejderIntFejlHide();
                _opretKontoVindue.FeltIkkeUdfyldtHide();
                _opretKontoVindue.EmailIkkeValidHide();
                if (economicAftalenummer.Length > 6)
                {
                    _opretKontoVindue.AftalenummerfejlShow();
                    return false;
                }
                else
                {
                    try
                    {
                        _konto.EconomicAftalenummer = Convert.ToInt32(economicAftalenummer);
                    }
                    catch (Exception)
                    {
                        _opretKontoVindue.IntFejlShow();
                        return false;
                    }
                    _opretKontoVindue.IntFejlHide();
                    _opretKontoVindue.AftalenummerfejlHide();
                    _konto.EconomicBrugernavn = economicBrugernavn;
                    _konto.EconomicKodeord = economicKodeord;
                    if (_util.IsValidEmail(brugernavn))
                    {
                        try
                        {
                            _brugerDTO = new BrugerDTO(fornavn, efternavn, Convert.ToInt32(medarbjederNummer), true, brugernavn, kodeord);
                        }
                        catch (Exception)
                        {
                            _opretKontoVindue.MedarbejderIntFejlShow();
                            return false;
                        }
                    }
                    else
                    {
                        _opretKontoVindue.EmailIkkeValidShow();
                        return false;
                    }

                    _konto.AbosimBruger = _brugerDTO;
                    return _iDAO.OpretKonto(_konto);
                }
            }
        }

    }
}
