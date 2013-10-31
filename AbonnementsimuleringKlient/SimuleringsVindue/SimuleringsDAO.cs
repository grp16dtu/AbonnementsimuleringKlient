using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    class SimuleringsDAO : ISimuleringsDAO
    {
        private IDTO DTO;
        
        public List<string> Xakse
        {
            get { throw new NotImplementedException(); }
        }

        public List<double> Yakse
        {
            get { throw new NotImplementedException(); }
        }

        public SimuleringsDAO()
        {
            this.DTO = DTO.Instance;    
        }

        public void GenererNySimulering()
        {
            throw new NotImplementedException();
        }

        public List<string> HentSimuleringsListe()
        {
            throw new NotImplementedException();
        }

        public void HentSimulering(SimuleringsVindue.xAkseKey xKey, SimuleringsVindue.yAkseKey yKey, string tidsStempel)
        {
            throw new NotImplementedException();
        }
    }
}
