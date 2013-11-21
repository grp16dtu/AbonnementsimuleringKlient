using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public class SimuleringsDTO : ISimuleringsDTO
    {
        public List<string> XakseTid { get; set; }
        public List<string> XakseAfdeling { get; set; }
        public List<string> XakseDebitor{ get; set; }
        public List<string> XakseVare{ get; set; }
        public List<double> YakseStkTid{ get; set; }
        public List<double> YaksePrisTid{ get; set; }
        public List<double> YakseStkAfdeling{ get; set; }
        public List<double> YaksePrisAfdeling{ get; set; }
        public List<double> YakseStkDebitor{ get; set; }
        public List<double> YaksePrisDebitor{ get; set; }
        public List<double> YakseStkVare{ get; set; }
        public List<double> YaksePrisVare { get; set; }

    }
}
