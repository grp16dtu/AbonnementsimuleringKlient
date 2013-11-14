using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbonnementsimuleringServer.Models
{
    public class DatapunktLister
    {
        public List<Datapunkt> TidAntal { get; set; }
        public List<Datapunkt> TidDKK { get; set; }
        public List<Datapunkt> VareAntal { get; set; }
        public List<Datapunkt> VareDKK { get; set; }
        public List<Datapunkt> AfdelingAntal { get; set; }
        public List<Datapunkt> AfdelingDKK { get; set; }
        public List<Datapunkt> DebitorAntal { get; set; }
        public List<Datapunkt> DebitorDKK { get; set; }

        public DatapunktLister()
        {
        }
    }
}