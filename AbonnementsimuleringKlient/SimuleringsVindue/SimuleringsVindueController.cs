﻿using System;
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

        public void SetControllers(BrugsHistorikVindueController brugsHisturikController, BrugerAdminVindueController brugerAdminVindueController)
        {
            this._brugsHistorikController = brugsHisturikController;
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
            //_simuleringsDAO 
            if (valgteindex >= 0)
            {
                GenererSimuleringsDAO(_dto.HentEnkeltSimulering(_datapunktsgrupperings[valgteindex].Id));
            }


            //_simuleringsDAO = _dto.KoerNySimulering();

            /*
            var dao = _simuleringsDAO;

            dao.XakseAfdeling = new List<string> { "Afdeling1", "Afdeling2", "Afdeling2", "Afdeling2", "Afdeling2" };
            dao.XakseDebitor = new List<string> { "Debitor1", "Debitor2", "Afdeling2", "Afdeling2", "Afdeling2" };
            dao.XakseTid = new List<string> { "Tid1", "Tid2", "Afdeling2", "Afdeling2", "Afdeling2" };
            dao.XakseVare = new List<string> { "Vare1", "Vare2",  "Afdeling2", "Afdeling2" };
            dao.YaksePrisAfdeling = new List<double> { 123,123 , 456,846,200};
            dao.YaksePrisDebitor = new List<double> { 123, 123, 965,986,127 };
            dao.YaksePrisTid = new List<double> { 123, 123,456,953,356 };
            dao.YaksePrisVare = new List<double> {  123,846,458,652 };
            dao.YakseStkAfdeling = new List<double> { 123, 123 ,0,15,456};
            dao.YakseStkDebitor = new List<double> { 123, 123,658,8,963 };
            dao.YakseStkTid = new List<double> { 123, 123,658,956,1559 };
            dao.YakseStkVare = new List<double> { 10000, 50000 ,5588,2352};

            _simuleringsDAO = dao;
            */
        }
         
        public void OpenBrugerHistorikVindue()
        {
            _brugsHistorikController.OpenVindue(_aktuelBruger);
        }

        public void OpenBrugerAdminVindue()
        {
            _brugerAdminVindueController.OpenVindue(_aktuelBruger);
        }

        public void BygNyesteSimuleringsDAO()
        {
            //TODO: OPTIMER!!

            _dto.KoerNySimulering();

            OpdaterVindue("Tid", "Pris");
        }

        public List<Datapunktsgruppering> HentSimuleringsList()
        {
            return _dto.HentSimuleringsListe();
        }


        public void GenererSimuleringsDAO(DatapunktLister data)
        {
            foreach (var afdeling in data.AfdelingAntal)
            {
                _simuleringsDAO.XakseAfdeling.Add(afdeling.Afdelingsnavn);
                _simuleringsDAO.YakseStkAfdeling.Add((double)afdeling.Antal);
            }

            foreach (var afdeling in data.AfdelingDKK)
            {
                _simuleringsDAO.YaksePrisAfdeling.Add((double)afdeling.DKK);
            }

            foreach (var afdeling in data.DebitorAntal)
            {
                _simuleringsDAO.XakseDebitor.Add(afdeling.Debitornavn);
                _simuleringsDAO.YakseStkDebitor.Add((double)afdeling.Antal);
            }

            foreach (var afdeling in data.DebitorDKK)
            {
                _simuleringsDAO.YakseStkAfdeling.Add((double)afdeling.DKK);
            }

            foreach (var afdeling in data.TidAntal)
            {
                _simuleringsDAO.XakseTid.Add(afdeling.Tid.ToString());
                _simuleringsDAO.YakseStkTid.Add((double)afdeling.Antal);
            }
            foreach (var afdeling in data.TidDKK)
            {
                _simuleringsDAO.YaksePrisTid.Add((double)afdeling.DKK);
            }

            foreach (var afdeling in data.VareAntal)
            {
                _simuleringsDAO.XakseVare.Add(afdeling.Varenavn);
                _simuleringsDAO.YakseStkVare.Add((double)afdeling.Antal);
            }

            foreach (var afdeling in data.VareDKK)
            {
                _simuleringsDAO.YaksePrisVare.Add((double)afdeling.DKK);
            }

        }
    }      
}
