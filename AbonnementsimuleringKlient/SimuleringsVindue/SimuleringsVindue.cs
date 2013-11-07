﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AbonnementsimuleringKlient
{
    public partial class SimuleringsVindue : Form, ISimuleringsVindue
    {
        private SimuleringsVindueController simuleringsVindueController;
        public string[] yAkseKey = new string[] {"Stk", "Pris"};
        public string[] xAkseKey = new string[] {"Tid", "Afdeling", "Debitor", "Vare"};
        public DateTime Tidsstempel { get; set; }
        public List<DateTime> SimuleringsListe; 
        public void SetSimuleringsVindueController(SimuleringsVindueController controller)
        {
            this.simuleringsVindueController = controller;

            yAkse.Items.AddRange(yAkseKey);
            yAkse.DisplayMember = yAkseKey[0];
            xAkse.Items.AddRange(xAkseKey);
            xAkse.DisplayMember = xAkseKey[0];


           // OpdaterVindue(xKey, yKey, Tidsstempel);

            this.FormClosing += new FormClosingEventHandler(Closing_From);
        }

        private void Closing_From(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["LoginVindue"].Close();
        }

        public List<DateTime> VisSimuleringsListe()
        {
            throw new NotImplementedException();
        }

        public void VisValgteSimulering(string xAkseKey, string yAkseKey, List<string> xAkse, List<double> yAkse)
        {
            Series serie = new Series();

            //Sletter alle andre titler der er i forvejen
            chart1.Titles.Clear();

            //serie.Name = xAkseKey + "/" + yAkseKey;
            chart1.Titles.Add(xAkseKey + "/" + yAkseKey);
            for(int i = 0; i< xAkse.Count; i++)
            {
                //Datapunkterne skal laegges her i
                DataPoint data = new DataPoint();
                //dataen tilfoejes en af gangen, der skal være lige mange x, som y vaerdien
                data.SetValueXY(xAkse[i], yAkse[i]);

                //skriver det reelle tal af kolonnen paa grafen
                data.Label = yAkse[i].ToString();

                //graftypen
                serie.ChartType = SeriesChartType.RangeColumn;

                //tilfoejer dataen til serien
                serie.Points.Add(data);
            }
            //Sletter alle andre titler der er i forvejen
            chart1.Series.Clear();

            //tilfoejer serien til grafen
            chart1.Series.Add(serie);
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
           // OpdaterVindue(xKey, yKey, Tidsstempel);
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
        /*
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
        */

        private void visBrugshistorikKnap_Click(object sender, EventArgs e)
        {
            simuleringsVindueController.OpenBrugerHistorikVindue();
        }

        private void visBrugerAdminKnap_Click(object sender, EventArgs e)
        {
            simuleringsVindueController.OpenBrugerAdminVindue();
        }

        public SimuleringsVindue()
        {
            InitializeComponent();
        }

        private void visSimuleringKnap_Click(object sender, EventArgs e)
        {
            //TODO: implement
            List<string> xAkse = new List<string>() { "Januar", "Februar", "Marts", "April", "Maj", "Juni", "Juli", "August", "September", "Oktober", "November", "December" };
            List<double> yAkse = new List<double>() { 500, 600, 700, 753, 695, 100, 1250, 864, 789, 351, 789, 654 };

            VisValgteSimulering("Hardcodede måneder", "random tal", xAkse, yAkse);
        }

        private void KorNy_Click(object sender, EventArgs e)
        {
            //TODO: implementer!!
        }

        private void xAkse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yAkse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        


     
    }
}
