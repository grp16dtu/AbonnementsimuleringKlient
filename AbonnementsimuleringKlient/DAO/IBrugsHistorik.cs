using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    interface IBrugsHistorik
    {
        string BrugerId { get; set; }
        HistorikType Type { get; set; }
        DateTime TidsStempel { get; set; }
    }
}
