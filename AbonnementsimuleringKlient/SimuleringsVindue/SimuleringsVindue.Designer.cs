namespace AbonnementsimuleringKlient
{
    partial class SimuleringsVindue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.simuleringsGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yAkse = new System.Windows.Forms.ComboBox();
            this.xAkse = new System.Windows.Forms.ComboBox();
            this.visBrugerAdminKnap = new System.Windows.Forms.Button();
            this.simuleringslisteBox = new System.Windows.Forms.ListBox();
            this.visSimuleringKnap = new System.Windows.Forms.Button();
            this.KorNy = new System.Windows.Forms.Button();
            this.indexTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IndexFejlLabel = new System.Windows.Forms.Label();
            this.animationServerGeneratingSimulering = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.simuleringsGraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationServerGeneratingSimulering)).BeginInit();
            this.SuspendLayout();
            // 
            // simuleringsGraf
            // 
            chartArea2.Name = "ChartArea1";
            this.simuleringsGraf.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.simuleringsGraf.Legends.Add(legend2);
            this.simuleringsGraf.Location = new System.Drawing.Point(12, 50);
            this.simuleringsGraf.Name = "simuleringsGraf";
            this.simuleringsGraf.Size = new System.Drawing.Size(423, 300);
            this.simuleringsGraf.TabIndex = 0;
            this.simuleringsGraf.Text = "chart1";
            // 
            // yAkse
            // 
            this.yAkse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yAkse.FormattingEnabled = true;
            this.yAkse.Location = new System.Drawing.Point(12, 23);
            this.yAkse.Name = "yAkse";
            this.yAkse.Size = new System.Drawing.Size(50, 21);
            this.yAkse.TabIndex = 1;
            this.yAkse.SelectedIndexChanged += new System.EventHandler(this.xAkse_SelectedIndexChanged);
            // 
            // xAkse
            // 
            this.xAkse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xAkse.Location = new System.Drawing.Point(441, 329);
            this.xAkse.Name = "xAkse";
            this.xAkse.Size = new System.Drawing.Size(69, 21);
            this.xAkse.TabIndex = 2;
            this.xAkse.SelectedIndexChanged += new System.EventHandler(this.yAkse_SelectedIndexChanged);
            // 
            // visBrugerAdminKnap
            // 
            this.visBrugerAdminKnap.Location = new System.Drawing.Point(441, 21);
            this.visBrugerAdminKnap.Name = "visBrugerAdminKnap";
            this.visBrugerAdminKnap.Size = new System.Drawing.Size(135, 23);
            this.visBrugerAdminKnap.TabIndex = 4;
            this.visBrugerAdminKnap.Text = "Brugeradministration";
            this.visBrugerAdminKnap.UseVisualStyleBackColor = true;
            this.visBrugerAdminKnap.Click += new System.EventHandler(this.visBrugerAdminKnap_Click);
            // 
            // simuleringslisteBox
            // 
            this.simuleringslisteBox.FormattingEnabled = true;
            this.simuleringslisteBox.Location = new System.Drawing.Point(441, 50);
            this.simuleringslisteBox.Name = "simuleringslisteBox";
            this.simuleringslisteBox.Size = new System.Drawing.Size(135, 69);
            this.simuleringslisteBox.TabIndex = 5;
            this.simuleringslisteBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // visSimuleringKnap
            // 
            this.visSimuleringKnap.Location = new System.Drawing.Point(441, 125);
            this.visSimuleringKnap.Name = "visSimuleringKnap";
            this.visSimuleringKnap.Size = new System.Drawing.Size(135, 23);
            this.visSimuleringKnap.TabIndex = 6;
            this.visSimuleringKnap.Text = "Vis";
            this.visSimuleringKnap.UseVisualStyleBackColor = true;
            this.visSimuleringKnap.Click += new System.EventHandler(this.visSimuleringKnap_Click);
            // 
            // KorNy
            // 
            this.KorNy.BackColor = System.Drawing.SystemColors.Control;
            this.KorNy.Location = new System.Drawing.Point(441, 193);
            this.KorNy.Name = "KorNy";
            this.KorNy.Size = new System.Drawing.Size(135, 23);
            this.KorNy.TabIndex = 7;
            this.KorNy.Text = "Kør ny";
            this.KorNy.UseVisualStyleBackColor = true;
            this.KorNy.Click += new System.EventHandler(this.KorNy_Click);
            // 
            // indexTextbox
            // 
            this.indexTextbox.Location = new System.Drawing.Point(543, 167);
            this.indexTextbox.Name = "indexTextbox";
            this.indexTextbox.Size = new System.Drawing.Size(33, 20);
            this.indexTextbox.TabIndex = 8;
            this.indexTextbox.Text = "1";
            this.indexTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Index";
            // 
            // IndexFejlLabel
            // 
            this.IndexFejlLabel.AutoSize = true;
            this.IndexFejlLabel.ForeColor = System.Drawing.Color.Red;
            this.IndexFejlLabel.Location = new System.Drawing.Point(453, 161);
            this.IndexFejlLabel.Name = "IndexFejlLabel";
            this.IndexFejlLabel.Size = new System.Drawing.Size(69, 26);
            this.IndexFejlLabel.TabIndex = 10;
            this.IndexFejlLabel.Text = "Index tal skal\r\n være heltal";
            this.IndexFejlLabel.Visible = false;
            // 
            // animationServerGeneratingSimulering
            // 
            this.animationServerGeneratingSimulering.Cursor = System.Windows.Forms.Cursors.Default;
            this.animationServerGeneratingSimulering.InitialImage = global::AbonnementsimuleringKlient.Properties.Resources.loading;
            this.animationServerGeneratingSimulering.Location = new System.Drawing.Point(477, 222);
            this.animationServerGeneratingSimulering.Name = "animationServerGeneratingSimulering";
            this.animationServerGeneratingSimulering.Size = new System.Drawing.Size(80, 74);
            this.animationServerGeneratingSimulering.TabIndex = 11;
            this.animationServerGeneratingSimulering.TabStop = false;
            // 
            // SimuleringsVindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.animationServerGeneratingSimulering);
            this.Controls.Add(this.IndexFejlLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indexTextbox);
            this.Controls.Add(this.KorNy);
            this.Controls.Add(this.visSimuleringKnap);
            this.Controls.Add(this.simuleringslisteBox);
            this.Controls.Add(this.visBrugerAdminKnap);
            this.Controls.Add(this.xAkse);
            this.Controls.Add(this.yAkse);
            this.Controls.Add(this.simuleringsGraf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SimuleringsVindue";
            this.Text = "Simulering";
            ((System.ComponentModel.ISupportInitialize)(this.simuleringsGraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationServerGeneratingSimulering)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart simuleringsGraf;
        private System.Windows.Forms.ComboBox yAkse;
        private System.Windows.Forms.ComboBox xAkse;
        private System.Windows.Forms.Button visBrugerAdminKnap;
        private System.Windows.Forms.ListBox simuleringslisteBox;
        private System.Windows.Forms.Button visSimuleringKnap;
        private System.Windows.Forms.Button KorNy;
        private System.Windows.Forms.TextBox indexTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IndexFejlLabel;
        private System.Windows.Forms.PictureBox animationServerGeneratingSimulering;
    }
}