using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbonnementsimuleringKlient
{
    class BrugerDAO:IBrugerDAO
    {
        private IDTO DTO;
        public string Fornavn {get; set;}

        public string Efternavn { get; set; }

        public int ID { get; set; }

        public bool ansvarlig { get; set; }

        public BrugerDAO(string fornavn, string efternavn, int id, bool ansvarlig)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.ID = id;
            this.ansvarlig = ansvarlig;
        }
    }
}
