using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface IBrugerDAO
    {
        /// <summary>
        /// Henter en liste over brugshistorik, i form af objekterne BrugsHistorik
        /// </summary>
        /// <returns>En liste med Brugshistorik, som indeholder oplysninger on type historik, id for hvem der er i historikken, og hvornår det var gjort</returns>
        List<BrugsHistorik> HentBrugsHistorik();

        //ikke sikker paa at den skal vaere der?
        void Id_Klikket();

        //ikke sikker paa at den skal vaere der?
        void TidsStempel_klikket();

        //ikke sikker paa at den skal vaere der?
        void HistorikType_klikket();
    }
}
