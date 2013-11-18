using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class SimuleringsVindueController
    {
        private ISimuleringsVindue _simuleringsVindue;
        private ISimuleringsDAO _simuleringsDAO;
        private BrugerAdminVindueController _brugerAdminVindueController;
        public IBrugerDAO _aktuelBruger { get; private set; }
        private IDTO _dto;
        private List<Datapunktsgruppering> _datapunktsgrupperings; 


        public SimuleringsVindueController(ISimuleringsVindue simuleringsVindue, ISimuleringsDAO simuleringsDAO)
        {
            this._simuleringsVindue = simuleringsVindue;
            this._simuleringsDAO = simuleringsDAO;
            this._dto = DTO.Instance;

            _simuleringsVindue.SetSimuleringsVindueController(this);
        }

        public void OpenVindue(IBrugerDAO bruger) 
        {          
            this._aktuelBruger = bruger;
            _datapunktsgrupperings = this._dto.HentSimuleringsListe(); 
            _simuleringsVindue.VisSimuleringsListe(_datapunktsgrupperings);
            this._simuleringsVindue.OpenVindue();
        }

        public void CloseVindue()
        {
            _simuleringsVindue.CloseVindue();
        }

        public void SetControllers(BrugerAdminVindueController brugerAdminVindueController)
        {
            this._brugerAdminVindueController = brugerAdminVindueController;
        }

        internal void OpdaterVindue(string xKey, string yKey)
        {
            switch(yKey)
            {
                case "Stk":
                    switch(xKey)
                    {
                        case "Tid":
                            _simuleringsVindue.VisValgteSimulering(xKey, yKey, _simuleringsDAO.XakseTid, _simuleringsDAO.YakseStkTid);
                            break;
                        case "Vare":
                            _simuleringsVindue.VisValgteSimulering(xKey, yKey, _simuleringsDAO.XakseVare, _simuleringsDAO.YakseStkVare);
                            break;
                        case "Debitor":
                            _simuleringsVindue.VisValgteSimulering(xKey, yKey, _simuleringsDAO.XakseDebitor, _simuleringsDAO.YakseStkDebitor);
                            break;
                        case "Afdeling":
                            _simuleringsVindue.VisValgteSimulering(xKey, yKey, _simuleringsDAO.XakseAfdeling, _simuleringsDAO.YakseStkAfdeling);
                            break;
                    }
                    break;
                case "Pris":
                    switch (xKey)
                    {
                        case "Tid":
                            _simuleringsVindue.VisValgteSimulering(xKey, yKey, _simuleringsDAO.XakseTid, _simuleringsDAO.YaksePrisTid);
                            break;
                        case "Vare":
                            _simuleringsVindue.VisValgteSimulering(xKey, yKey, _simuleringsDAO.XakseVare, _simuleringsDAO.YaksePrisVare);
                            break;
                        case "Debitor":
                            _simuleringsVindue.VisValgteSimulering(xKey, yKey, _simuleringsDAO.XakseDebitor, _simuleringsDAO.YaksePrisDebitor);
                            break;
                        case "Afdeling":
                            _simuleringsVindue.VisValgteSimulering(xKey, yKey, _simuleringsDAO.XakseAfdeling, _simuleringsDAO.YaksePrisAfdeling);
                            break;
                    }
                    break;
            }
        }

        public void HentSimuleringsDAO(int valgteindex)
        {
            if (valgteindex >= 0)
            {
                GenererSimuleringsDAO(_dto.HentEnkeltSimulering(_datapunktsgrupperings[valgteindex].Id));
            }
        }
         
        public void OpenBrugerAdminVindue()
        {
            _brugerAdminVindueController.OpenVindue(_aktuelBruger);
        }

        public void BygNyesteSimuleringsDAO()
        {
            _dto.KoerNySimulering();

            _datapunktsgrupperings = this._dto.HentSimuleringsListe();
            _simuleringsVindue.VisSimuleringsListe(_datapunktsgrupperings);

            OpdaterVindue("Tid", "Pris");
        }

        public List<Datapunktsgruppering> HentSimuleringsList()
        {
            return _dto.HentSimuleringsListe();
        }


        public void GenererSimuleringsDAO(DatapunktLister data)
        {
            _simuleringsDAO.XakseAfdeling = new List<string>();
            _simuleringsDAO.YakseStkAfdeling = new List<double>();
            _simuleringsDAO.YaksePrisAfdeling = new List<double>();
            _simuleringsDAO.XakseDebitor = new List<string>();
            _simuleringsDAO.YakseStkDebitor = new List<double>();
            _simuleringsDAO.YaksePrisDebitor = new List<double>();
            _simuleringsDAO.XakseTid = new List<string>();
            _simuleringsDAO.YakseStkTid = new List<double>();
            _simuleringsDAO.YaksePrisTid = new List<double>();
            _simuleringsDAO.XakseVare = new List<string>();
            _simuleringsDAO.YakseStkVare = new List<double>();
            _simuleringsDAO.YaksePrisVare = new List<double>();

            foreach (var afdeling in data.AfdelingAntal)
            {
                if (afdeling.Afdelingsnavn == null)
                {
                    string fejl = "Uden Afdeling";
                    _simuleringsDAO.XakseAfdeling.Add(fejl);
                }
                else
                {
                    _simuleringsDAO.XakseAfdeling.Add(afdeling.Afdelingsnavn);
                }
                _simuleringsDAO.YakseStkAfdeling.Add((double)afdeling.Antal);
            }

            foreach (var afdeling in data.AfdelingDKK)
            {
                _simuleringsDAO.YaksePrisAfdeling.Add((double)afdeling.DKK);
            }

            foreach (var debitor in data.DebitorAntal)
            {
                _simuleringsDAO.XakseDebitor.Add(debitor.Debitornavn);
                _simuleringsDAO.YakseStkDebitor.Add((double)debitor.Antal);
            }

            foreach (var debitor in data.DebitorDKK)
            {
                _simuleringsDAO.YaksePrisDebitor.Add((double)debitor.DKK);
            }

            foreach (var tid in data.TidAntal)
            {
                _simuleringsDAO.XakseTid.Add(tid.Tid.ToString());
                _simuleringsDAO.YakseStkTid.Add((double)tid.Antal);
            }
            foreach (var tid in data.TidDKK)
            {
                _simuleringsDAO.YaksePrisTid.Add((double)tid.DKK);
            }

            foreach (var vare in data.VareAntal)
            {
                _simuleringsDAO.XakseVare.Add(vare.Varenavn);
                _simuleringsDAO.YakseStkVare.Add((double)vare.Antal);
            }

            foreach (var vare in data.VareDKK)
            {
                _simuleringsDAO.YaksePrisVare.Add((double)vare.DKK);
            }

        }
    }      
}
