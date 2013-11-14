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
    public partial class OpretKontoVindue : Form, IOpretKontoVindue
    {

        private OpretKontoVindueController _controller;

        public OpretKontoVindue()
        {
            InitializeComponent();
        }

        public void SetOpretKontoVindueController(OpretKontoVindueController controller)
        {
            this._controller = controller;
            this.FormClosing += new FormClosingEventHandler(Closing_From);
        }

        private void Closing_From(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void opretKonto_Klikket(object sender, EventArgs e)
        {
            if(_controller.OpretKonto(economicAftalenummer.Text,economicBrugernavn.Text,economicKodeord.Text,
                fornavn.Text,efternavn.Text,medarbjederNummer.Text,brugernavn.Text,kodeord.Text))
            {
                CloseVindue();
            }
        }

        public void OpenVindue()
        {
            this.Show();
        }

        public void CloseVindue()
        {
            this.Hide();
        }

        public void AftalenummerfejlShow()
        {
            this.aftalenummerfejl.Show();
        }

        public void AftalenummerfejlHide()
        {
            this.aftalenummerfejl.Hide();
        }

    }
}
