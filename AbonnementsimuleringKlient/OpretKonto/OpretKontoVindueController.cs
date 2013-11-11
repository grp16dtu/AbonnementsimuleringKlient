using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class OpretKontoVindueController
    {
        private IOpretKontoVindue _opretKontoVindue;

        public OpretKontoVindueController(OpretKontoVindue opretKontoVindue)
        {
            this._opretKontoVindue = opretKontoVindue;

            opretKontoVindue.SetOpretKontoVindueController(this);
        }


        public void OpenVindue()
        {
            _opretKontoVindue.OpenVindue();
        }
    }
}
