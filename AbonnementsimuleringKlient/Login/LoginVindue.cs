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
    public partial class LoginVindue : Form
    {
        private LoginVindueController LoginVindueController = new LoginVindueController();

        public LoginVindue()
        {
            InitializeComponent();
        }

        private void LoginKnap_Klikket() 
        {
            if (LoginVindueController.LoginVerificering(brugernavn.Text, kodeord.Text))
            {
                //open main vindue
            }
            else
            {
                SkiftLabelStatus();
            }
        }

        private void SkiftLabelStatus() 
        {
            status.Text = "Forkert Brugernavn eller Kodeord";
        }
    }
}
