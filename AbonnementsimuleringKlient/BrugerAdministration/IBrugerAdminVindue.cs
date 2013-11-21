using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface IBrugerAdminVindue
    {
        void SetBrugerAdminVindueController(BrugerAdminVindueController controller);

        void OpenVindue();

        void CloseVindue();

        void OpdaterMedarbejderListe(object sender, EventArgs e);

        
    }
}
