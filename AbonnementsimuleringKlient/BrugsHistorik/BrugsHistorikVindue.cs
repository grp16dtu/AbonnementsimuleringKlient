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
    public partial class BrugsHistorikVindue : Form,IBrugsHistorikVindue
    {
        private BrugsHistorikVindueController controller;

        public BrugsHistorikVindue()
        {
            InitializeComponent();
        }

        public List<BrugsHistorik> HentBrugsHistorik()
        {
            return null;
        }

        private void Id_klikket()
        {

        }

        private void TidsStempel_klikket()
        {

        }

        private void HistorikType_klikket()
        {

        }

        public void SetBrugsHistorikVindueController(BrugsHistorikVindueController controller)
        {
            this.controller = controller;
        }

        public void OpenVindue()
        {
            this.Show();
        }

        public void CloseVindue()
        {
            this.Hide();
        }
    }
}
