using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonnementsimuleringKlient
{
    public partial class SimuleringsVindue : Form, ISimuleringsVindue
    {
        private SimuleringsVindueController simuleringsVindueController;
        public enum yAkseKey { Stk, Pris };
        public enum xAkseKey { Tid, Afdeling, Debitor, Vare };
        public xAkseKey xKey { get; set; }
        public yAkseKey yKey { get; set; }
        public DateTime Tidsstempel { get; set; }
        public List<DateTime> SimuleringsListe; 
        public void SetSimuleringsVindueController(SimuleringsVindueController controller)
        {
            this.simuleringsVindueController = controller;
            this.xKey = xAkseKey.Tid;
            this.yKey = yAkseKey.Pris;

            OpdaterVindue(xKey, yKey, Tidsstempel);
        }

        public List<DateTime> VisSimuleringsListe()
        {
            throw new NotImplementedException();
        }

        public SimuleringsDAO VisValgteSimulering(string tidsstempel)
        {
            throw new NotImplementedException();
        }

        public void GenererNySimulering(int index)
        {
            throw new NotImplementedException();
        }

        public void BrugerAdministration()
        {
            throw new NotImplementedException();
        }

        public void XAkse()
        {
            OpdaterVindue(xKey, yKey, Tidsstempel);
        }

        public void YAkse()
        {
            throw new NotImplementedException();
        }

        public void OpenVindue()
        {
            this.Show();
        }

        public void CloseVindue()
        {
            this.Hide();
        }

        public void OpdaterVindue(xAkseKey xKey, yAkseKey yKey, DateTime tidsstempel)
        {
            if (tidsstempel != null)
            {
                simuleringsVindueController.OpdaterVindue(xKey, yKey, tidsstempel);
            }else
            {
                SimuleringsListe = VisSimuleringsListe();
                simuleringsVindueController.OpdaterVindue(xKey, yKey, SimuleringsListe.Last());
            }
        }
        public SimuleringsVindue()
        {
            InitializeComponent();
        }
        

     
    }
}
