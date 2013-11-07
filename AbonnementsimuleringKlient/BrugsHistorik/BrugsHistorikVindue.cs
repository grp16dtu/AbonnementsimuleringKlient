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
        private BrugsHistorikVindueController _controller;

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
            this._controller = controller;
            this.FormClosing += new FormClosingEventHandler(Closing_From);
        }

        private void Closing_From(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
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
