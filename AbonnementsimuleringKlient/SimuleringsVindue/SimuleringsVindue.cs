using System;
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
        private string[] yAkseKey = new string[] {"Stk", "Pris"};
        private string[] xAkseKey = new string[] {"Tid", "Afdeling", "Debitor", "Vare"};
        private DateTime Tidsstempel { get; set; }
        private List<DateTime> SimuleringsListe; 

        public void SetSimuleringsVindueController(SimuleringsVindueController controller)
        {
            this.simuleringsVindueController = controller;


            //listBox1.SelectedIndex = 0;

           // OpdaterVindue(xKey, yKey, Tidsstempel);

            this.FormClosing += new FormClosingEventHandler(Closing_From);
        }

        private void Closing_From(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["LoginVindue"].Close();
        }

        public void VisSimuleringsListe(List<Datapunktsgruppering> liste)
        {
            foreach (var datapunktsgruppering in liste)
            {
                this.listBox1.Items.Add(datapunktsgruppering.Dato.AddHours(9));
            }
            this.listBox1.SelectedIndex = 0;
        }

        public void VisValgteSimulering(string xAkseKey, string yAkseKey, List<string> xAkse, List<double> yAkse)
        {
            Series serie = new Series();

            //Sletter alle andre titler der er i forvejen
            chart1.Titles.Clear();

            chart1.ResetAutoValues();

            chart1.Titles.Add(yAkseKey + "/" + xAkseKey);
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
                serie.IsVisibleInLegend = false;
            }
            //Sletter alle andre titler der er i forvejen
            chart1.Series.Clear();

            //tilfoejer serien til grafen
            chart1.Series.Add(serie);
        }

        public void OpenVindue()
        {
            this.visBrugerAdminKnap.Enabled = this.simuleringsVindueController._aktuelBruger.Ansvarlig;
            this.KorNy.Enabled = this.simuleringsVindueController._aktuelBruger.Ansvarlig;
            simuleringsVindueController.HentSimuleringsDAO(this.listBox1.SelectedIndex);
            yAkse.Items.AddRange(yAkseKey);
            yAkse.Text = yAkseKey[0];
            xAkse.Items.AddRange(xAkseKey);
            xAkse.Text = xAkseKey[0];
            this.Show();
        }

        public void CloseVindue()
        {
            this.Hide();
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
            simuleringsVindueController.HentSimuleringsDAO(this.listBox1.SelectedIndex);
            simuleringsVindueController.OpdaterVindue(this.xAkse.Text, this.yAkse.Text);
        }

        private void KorNy_Click(object sender, EventArgs e)
        {
            simuleringsVindueController.BygNyesteSimuleringsDAO();
        }

        private void xAkse_SelectedIndexChanged(object sender, EventArgs e)
        {
            simuleringsVindueController.OpdaterVindue(this.xAkse.Text, this.yAkse.Text);
        }

        private void yAkse_SelectedIndexChanged(object sender, EventArgs e)
        {
            simuleringsVindueController.OpdaterVindue(this.xAkse.Text, this.yAkse.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
