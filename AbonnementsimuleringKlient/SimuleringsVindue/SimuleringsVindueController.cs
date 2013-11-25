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
        private ISimuleringsDTO _simuleringsDTO;
        private BrugerAdminVindueController _brugerAdminVindueController;
        public IBrugerDTO aktuelBruger { get; private set; }
        private IDAO _iDAO;
        private List<Datapunktsgruppering> _datapunktsgrupperings; 

        public SimuleringsVindueController(ISimuleringsVindue simuleringsVindue, ISimuleringsDTO simuleringsDTO)
        {
            this._simuleringsVindue = simuleringsVindue;
            this._simuleringsDTO = simuleringsDTO;
            this._iDAO = DAO.Instance;

            _simuleringsVindue.SetSimuleringsVindueController(this);
        }

        public ISimuleringsDTO getSimuleringsDTO()
        {
            return this._simuleringsDTO;
        }

        public async void OpenVindue(IBrugerDTO bruger) 
        {          
            this.aktuelBruger = bruger;
            _datapunktsgrupperings = await this._iDAO.HentSimuleringsListe(); 
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

        public void HentSimuleringsDTO(int valgteindex)
        {
            if (valgteindex >= 0)
            {
                GenererSimuleringsDTO(_iDAO.HentEnkeltSimulering(_datapunktsgrupperings[valgteindex].Id));
            }
        }
         
        public void OpenBrugerAdminVindue()
        {
            _brugerAdminVindueController.OpenVindue(aktuelBruger);
        }

        public void BygNyesteSimulering(int index)
        {
            _iDAO.KoerNySimulering(index);
        }

        public async void HentSimuleringsList()
        {
            _datapunktsgrupperings = await this._iDAO.HentSimuleringsListe();
            _simuleringsVindue.VisSimuleringsListe(_datapunktsgrupperings);
        }


        public void GenererSimuleringsDTO(DatapunktLister data)
        {
            _simuleringsDTO.XakseAfdeling = new List<string>();
            _simuleringsDTO.YakseStkAfdeling = new List<double>();
            _simuleringsDTO.YaksePrisAfdeling = new List<double>();
            _simuleringsDTO.XakseDebitor = new List<string>();
            _simuleringsDTO.YakseStkDebitor = new List<double>();
            _simuleringsDTO.YaksePrisDebitor = new List<double>();
            _simuleringsDTO.XakseTid = new List<string>();
            _simuleringsDTO.YakseStkTid = new List<double>();
            _simuleringsDTO.YaksePrisTid = new List<double>();
            _simuleringsDTO.XakseVare = new List<string>();
            _simuleringsDTO.YakseStkVare = new List<double>();
            _simuleringsDTO.YaksePrisVare = new List<double>();

            foreach (var afdeling in data.AfdelingAntal)
            {
                if (afdeling.Afdelingsnavn == null)
                {
                    string fejl = "Uden Afdeling";
                    _simuleringsDTO.XakseAfdeling.Add(fejl);
                }
                else
                {
                    _simuleringsDTO.XakseAfdeling.Add(afdeling.Afdelingsnavn);
                }
                _simuleringsDTO.YakseStkAfdeling.Add((double)afdeling.Antal);
            }

            foreach (var afdeling in data.AfdelingDKK)
            {
                _simuleringsDTO.YaksePrisAfdeling.Add((double)afdeling.DKK);
            }

            foreach (var debitor in data.DebitorAntal)
            {
                _simuleringsDTO.XakseDebitor.Add(debitor.Debitornavn);
                _simuleringsDTO.YakseStkDebitor.Add((double)debitor.Antal);
            }

            foreach (var debitor in data.DebitorDKK)
            {
                _simuleringsDTO.YaksePrisDebitor.Add((double)debitor.DKK);
            }

            foreach (var tid in data.TidAntal)
            {
                _simuleringsDTO.XakseTid.Add(tid.Tid.Value.ToShortDateString());
                _simuleringsDTO.YakseStkTid.Add((double)tid.Antal);
            }
            foreach (var tid in data.TidDKK)
            {
                _simuleringsDTO.YaksePrisTid.Add((double)tid.DKK);
            }

            foreach (var vare in data.VareAntal)
            {
                _simuleringsDTO.XakseVare.Add(vare.Varenavn);
                _simuleringsDTO.YakseStkVare.Add((double)vare.Antal);
            }

            foreach (var vare in data.VareDKK)
            {
                _simuleringsDTO.YaksePrisVare.Add((double)vare.DKK);
            }

        }
    }      
}
