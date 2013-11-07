using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonnementsimuleringKlient
{
    public interface ISimuleringsDAO
    {
        List<DateTime> SimuleringsListe { get; set; }
        List<string> XakseTid { get; set; }
        List<string> XakseAfdeling { get; set; }
        List<string> XakseDebitor { get; set; }
        List<string> XakseVare { get; set; }
        List<double> YakseStkTid { get; set; }
        List<double> YaksePrisTid { get; set; }
        List<double> YakseStkAfdeling { get; set; }
        List<double> YaksePrisAfdeling { get; set; }
        List<double> YakseStkDebitor { get; set; }
        List<double> YaksePrisDebitor { get; set; }
        List<double> YakseStkVare { get; set; }
        List<double> YaksePrisVare { get; set; }
    }
}
