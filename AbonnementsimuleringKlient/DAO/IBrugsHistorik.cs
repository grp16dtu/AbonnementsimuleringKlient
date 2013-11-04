using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface IBrugsHistorik
    {
        string BrugerId { get; set; }
        BrugsHistorik.HistorikType Type { get; set; }
        DateTime TidsStempel { get; set; }
    }
}
