﻿using System;
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
    public partial class BrugerAdminVindue : Form
    {
        IBrugerAdminVindueController brugerAdminVindueController;
        public BrugerAdminVindue()
        {
            InitializeComponent();
            brugerAdminVindueController = new BrugerAdminVindueController();
        }

        private void instillinger_Click(object sender, EventArgs e)
        {

        }

        private void opretBruger_Click(object sender, EventArgs e)
        {

        }

        private void sletBruger_Click(object sender, EventArgs e)
        {

        }

        private void gemBruger_Click(object sender, EventArgs e)
        {

        }

        private void OnLoad(object sender, EventArgs e)
        {
        }
    }
}
