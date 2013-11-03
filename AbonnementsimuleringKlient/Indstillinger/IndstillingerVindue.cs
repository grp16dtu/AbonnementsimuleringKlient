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
    public partial class IndstillingerVindue : Form, IIndstillingerVindue
    {
        IndstillingerVindueController controller;

        public IndstillingerVindue()
        {
            InitializeComponent();
        }

        public EConomicCredentialsDAO HentCredentials(string brugernavn)
        {
            throw new NotImplementedException();
        }

        public void GemCredentials(EConomicCredentialsDAO eConomicCredentialsObject)
        {
            throw new NotImplementedException();
        }

        public void SetIndstillingerVindueController(IndstillingerVindueController controller)
        {
            this.controller = controller;
        }

        public void OpenVindue()
        {
            this.Show();
        }

        public void CloseVindue()
        {
            this.Close();
        }
    }
}
