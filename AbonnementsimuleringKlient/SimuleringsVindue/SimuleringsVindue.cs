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
        public SimuleringsVindue()
        {
            InitializeComponent();
        }

        public void SetSimuleringsVindueController(SimuleringsVindueController controller)
        {
            this.simuleringsVindueController = controller;
        }

        public List<string> VisSimuleringsListe()
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
            throw new NotImplementedException();
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

        private void visBrugshistorikKnap_Click(object sender, EventArgs e)
        {
            simuleringsVindueController.OpenBrugerHisturikVindue();
        }

        private void visBrugerAdminKnap_Click(object sender, EventArgs e)
        {
            simuleringsVindueController.OpenBrugerAdminVindue();
        }
    }
}
