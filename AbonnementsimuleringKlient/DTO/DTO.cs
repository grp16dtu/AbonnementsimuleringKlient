using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    class DTO : IDTO
    {
        private HttpKlient httpKlient;

        private IDTO iDTO;

        public List<Medarbejder> HentMedarbejderList()
        {
            throw new NotImplementedException();
        }

        public void SletMedarbejder()
        {
            throw new NotImplementedException();
        }

        public void OpretMedarbejder()
        {
            throw new NotImplementedException();
        }

        public void RedigerMedarbejder()
        {
            throw new NotImplementedException();
        }

        public List<string[]> HentBrugsHistorik(TidsInterval tidsInterval, HistorikType historikType, Id id)
        {
            throw new NotImplementedException();
        }

        public List<string> HentGrafDataDropdown()
        {
            throw new NotImplementedException();
        }

        public void KoerNySimulering()
        {
            throw new NotImplementedException();
        }

        public List<Simuleringer> HentSimuleringsListe()
        {
            throw new NotImplementedException();
        }

        public void HentEnkeltSimulering()
        {
            throw new NotImplementedException();
        }

        public void OpdaterEConomicsCredentials(string aftalenr, string brugernavn, string kodeord)
        {
            throw new NotImplementedException();
        }
    }
}
