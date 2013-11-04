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
        private LoginVindueController controller;

        public LoginVindue()
        {
            InitializeComponent();
        }

        private void SkiftLabelStatus()
        {
            status.Text = "Forkert Brugernavn eller Kodeord";
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
            this.controller = controller;
        }

        private void LoginKnap_Klikket(object sender, EventArgs e)
        {
            if (controller.LoginVerificering(brugernavn.Text, kodeord.Text))
            {
                //open main vindue
            }
            else
            {
                SkiftLabelStatus();
            }
        }
    }
}
