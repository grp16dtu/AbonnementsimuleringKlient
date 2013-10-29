using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbonnementsimuleringKlient
{
    class BrugerDAO:IBrugerDAO
    {
        private IDTO _DTO;
        public string Fornavn {get; set;}

        public string Efternavn { get; set; }

        public int ID { get; set; }

        public bool ansvarlig { get; set; }

        public List<IBrugsHistorik> HentBrugsHistorik()
        {
            throw new NotImplementedException();
        }

        public void Id_Klikket()
        {
            throw new NotImplementedException();
        }

        public void TidsStempel_klikket()
        {
            throw new NotImplementedException();
        }

        public void HistorikType_klikket()
        {
            throw new NotImplementedException();
        }
    }
}
