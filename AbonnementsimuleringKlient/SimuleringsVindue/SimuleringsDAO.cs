using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class SimuleringsDAO : ISimuleringsDAO
    {
        private IDTO DTO;

        public List<string> Xakse
        {
            get;
            private set;
        }

        public List<double> Yakse
        {
            get;
            private set;
        }

        public SimuleringsDAO()
        {
            //this.DTO = DTO.Instance;    
        }

        public void GenererNySimulering()
        {
            throw new NotImplementedException();
        }

        public List<string> HentSimuleringsListe()
        {
            throw new NotImplementedException();
        }

        public void HentSimulering(SimuleringsVindue.xAkseKey xKey, SimuleringsVindue.yAkseKey yKey, DateTime tidsStempel)
        {
          //  this.DTO.HentSimulering(xKey, yKey, tidsStempel);
        }

        public List<string> HentXakse()
        {
            throw new NotImplementedException();
        }

        public List<double> HentYakse()
        {
            throw new NotImplementedException();
        }
    }
}
