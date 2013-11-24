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
        private BackgroundWorker _arbejder;
        private SimuleringsVindueController simuleringsVindueController;
        private string[] yAkseKey = new string[] {"Stk", "DKK"};
        private string[] xAkseKey = new string[] {"Tid", "Afdeling", "Debitor", "Vare"};

        public void SetSimuleringsVindueController(SimuleringsVindueController controller)
        {
            this.simuleringsVindueController = controller;

            this.FormClosing += new FormClosingEventHandler(Closing_From);
        }

        private void Closing_From(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["LoginVindue"].Close();
        }

        public void VisSimuleringsListe(List<Datapunktsgruppering> liste)
        {
            this.listBox1.Items.Clear();
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
                data.LabelAngle = -90;

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

            //Sætter labels på alle xakse værdier
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            //Sætter labels på højkant ved Tid
            if (xAkseKey == "Tid")
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            }

        }

        public void OpenVindue()
        {
            this.visBrugerAdminKnap.Enabled = this.simuleringsVindueController.aktuelBruger.Ansvarlig;
            this.KorNy.Enabled = this.simuleringsVindueController.aktuelBruger.Ansvarlig;
            simuleringsVindueController.HentSimuleringsDTO(this.listBox1.SelectedIndex);
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
            _arbejder = new BackgroundWorker();
            _arbejder.WorkerReportsProgress = true;
            _arbejder.DoWork += new DoWorkEventHandler(arbejder_doWork);
            _arbejder.RunWorkerCompleted += new RunWorkerCompletedEventHandler(arbejder_done);
        }

        private void arbejder_doWork(object sender, DoWorkEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.loading;
            int index = Convert.ToInt32(e.Argument);
            simuleringsVindueController.BygNyesteSimuleringsDTO(index);
        }

        private void arbejder_done(object sender, RunWorkerCompletedEventArgs e)
        {
            KorNy.Enabled = true;
            pictureBox1.Image = null;
            listBox1.SelectedIndex = 0;
            simuleringsVindueController.HentSimuleringsList();
            visSimuleringKnap_Click(null, EventArgs.Empty);
        }

        private void visSimuleringKnap_Click(object sender, EventArgs e)
        {
            simuleringsVindueController.HentSimuleringsDTO(this.listBox1.SelectedIndex);
            OpdaterVindue(this.xAkse.Text, this.yAkse.Text);
        }

        public void OpdaterVindue(string xKey, string yKey)
        {
            var simuleringsDTO = this.simuleringsVindueController.getSimuleringsDTO();

            switch (yKey)
            {
                case "Stk":
                    getXAxisValueToDisplayWithYAxisStk(xKey, yKey, simuleringsDTO);
                    break;

                case "DKK":
                    getXAxisValueToDisplayWithYAxisDKK(xKey, yKey, simuleringsDTO);
                    break;
            }
        }


        private void getXAxisValueToDisplayWithYAxisStk(string xKey, string yKey, ISimuleringsDTO simuleringsDTO)
        {
            switch (xKey)
            {
                case "Tid":
                    VisValgteSimulering(xKey, yKey, simuleringsDTO.XakseTid, simuleringsDTO.YakseStkTid);
                    break;
                case "Vare":
                    VisValgteSimulering(xKey, yKey, simuleringsDTO.XakseVare, simuleringsDTO.YakseStkVare);
                    break;
                case "Debitor":
                    VisValgteSimulering(xKey, yKey, simuleringsDTO.XakseDebitor, simuleringsDTO.YakseStkDebitor);
                    break;
                case "Afdeling":
                    VisValgteSimulering(xKey, yKey, simuleringsDTO.XakseAfdeling, simuleringsDTO.YakseStkAfdeling);
                    break;
            }
        }

        private void getXAxisValueToDisplayWithYAxisDKK(string xKey, string yKey, ISimuleringsDTO simuleringsDTO)
        {
            switch (xKey)
            {
                case "Tid":
                    VisValgteSimulering(xKey, yKey, simuleringsDTO.XakseTid, simuleringsDTO.YaksePrisTid);
                    break;
                case "Vare":
                    VisValgteSimulering(xKey, yKey, simuleringsDTO.XakseVare, simuleringsDTO.YaksePrisVare);
                    break;
                case "Debitor":
                    VisValgteSimulering(xKey, yKey, simuleringsDTO.XakseDebitor, simuleringsDTO.YaksePrisDebitor);
                    break;
                case "Afdeling":
                    VisValgteSimulering(xKey, yKey, simuleringsDTO.XakseAfdeling, simuleringsDTO.YaksePrisAfdeling);
                    break;
            }
        }

        private void KorNy_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Hide();
                var index = Convert.ToInt32(textBox1.Text);
                if (!this._arbejder.IsBusy)
                {
                    KorNy.Enabled = false;
                }
                _arbejder.RunWorkerAsync(index);
            }
            catch (Exception)
            {
                label2.Show();
            }

        }

        private void xAkse_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpdaterVindue(this.xAkse.Text, this.yAkse.Text);
        }

        private void yAkse_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpdaterVindue(this.xAkse.Text, this.yAkse.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
