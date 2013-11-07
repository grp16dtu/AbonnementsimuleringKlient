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
        private BrugsHistorikVindueController _brugsHistorikController; 
        private BrugerAdminVindueController _brugerAdminVindueController;
        private IBrugerDAO _aktuelBruger;

        public SimuleringsVindueController(ISimuleringsVindue simuleringsVindue, ISimuleringsDAO simuleringsDAO)
        {
            this._simuleringsVindue = simuleringsVindue;
            this._simuleringsDAO = simuleringsDAO;

            _simuleringsVindue.SetSimuleringsVindueController(this);
        }

        public void OpenVindue(IBrugerDAO bruger) 
        {
            this._simuleringsVindue.OpenVindue();
            this._aktuelBruger = bruger;
        }

        public void CloseVindue()
        {
            _simuleringsVindue.CloseVindue();
        }

        public void SetControllers(BrugsHistorikVindueController brugsHisturikController, BrugerAdminVindueController brugerAdminVindueController)
        {
            this._brugsHistorikController = brugsHisturikController;
            this._brugerAdminVindueController = brugerAdminVindueController;
        }

        internal void OpdaterVindue(string xKey, string yKey, DateTime tidsstempel)
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
         
        public void OpenBrugerHistorikVindue()
        {
            _brugsHistorikController.OpenVindue(_aktuelBruger);
        }

        public void OpenBrugerAdminVindue()
        {
            _brugerAdminVindueController.OpenVindue(_aktuelBruger);
        }
    }      
}
