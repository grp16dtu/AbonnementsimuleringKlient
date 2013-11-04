using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface IBrugerDAO
    {
        string Fornavn { get; set; }
        string Efternavn { get; set; }
        int ID { get; set; }
        bool ansvarlig { get; set; }
    }
}
