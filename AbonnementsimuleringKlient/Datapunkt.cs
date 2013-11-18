using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class Datapunkt
    {
        // Key figures
        public decimal? Antal { get; set; }
        public decimal? DKK { get; set; }

        // Dimensioner
        public DateTime? Tid { get; set; }
        public string Varenavn { get; set; }
        public string Debitornavn { get; set; }
        public string Afdelingsnavn { get; set; }
    }
}
