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
    public partial class LoginVindue : Form, ILoginVindue
    {
        private LoginVindueController _controller;

        public LoginVindue()
        {
            InitializeComponent();
        }

        private void SkiftLabelStatus(int statusTal)
        {
            if(statusTal == 1)
            {
                status.Text = "Forkert Brugernavn eller Kodeord";
            }
            else
            {
                status.Text = "Mangler Bruger navn eller kodeord";
            }
        }

        //TODO Ikke færdig
        private bool Ansvarlig()
        {
            return false; 
        }

        public void OpenVindue()
        {
            this.Show();
        }

        public void CloseVindue()
        {
            this.Hide();
        }

        public void SetLoginVindueController(LoginVindueController controller)
        {
            this._controller = controller;
        }

        private void LoginKnap_Klikket(object sender, EventArgs e)
        {
            if (brugernavn.Text == "" || kodeord.Text == "")
            {
                SkiftLabelStatus(0);
            }
            else
            {
                if (_controller.LoginVerificering(brugernavn.Text, kodeord.Text))
                {
                    _controller.OpenSimuleringsVindue();
                    CloseVindue();
                }
                else
                {
                    SkiftLabelStatus(1);
                }
            }
        }
    }
}
