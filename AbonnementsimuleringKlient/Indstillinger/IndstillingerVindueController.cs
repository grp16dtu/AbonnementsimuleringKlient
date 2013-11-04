using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class IndstillingerVindueController
    {
        private IIndstillingerVindue _indstillingerVindue;
        private IEConomicCredentialsDAO _eConomicCredentialsDAO;

        public IndstillingerVindueController(IIndstillingerVindue indstillingerVindue, IEConomicCredentialsDAO eConomicCredentialsDAO)
        {
            this._indstillingerVindue = indstillingerVindue;
            this._eConomicCredentialsDAO = eConomicCredentialsDAO;

            indstillingerVindue.SetIndstillingerVindueController(this);
        }

        public void OpenVindue()
        {
            _indstillingerVindue.OpenVindue();
        }

        public void CloseVindue()
        {
            _indstillingerVindue.CloseVindue();
        }
    }
}
