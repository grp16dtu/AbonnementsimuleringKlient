using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    class IndstillingerVindueController
    {
        private IIndstillingerVindue indstillingerVindue;
        private IEConomicCredentialsDAO eConomicCredentialsDAO;

        public IndstillingerVindueController(IIndstillingerVindue indstillingerVindue, IEConomicCredentialsDAO eConomicCredentialsDAO)
        {
            this.indstillingerVindue = indstillingerVindue;
            this.eConomicCredentialsDAO = eConomicCredentialsDAO;

            indstillingerVindue.SetIndstillingerVindueController(this);
        }

        public void OpenVindue()
        {
            indstillingerVindue.OpenVindue();
        }

        public void CloseVindue()
        {
            indstillingerVindue.CloseVindue();
        }
    }
}
