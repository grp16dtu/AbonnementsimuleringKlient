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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yAkse = new System.Windows.Forms.ComboBox();
            this.xAkse = new System.Windows.Forms.ComboBox();
            this.visBrugshistorikKnap = new System.Windows.Forms.Button();
            this.visBrugerAdminKnap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.visSimuleringKnap = new System.Windows.Forms.Button();
            this.KorNy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 50);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(423, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.yAkse.FormattingEnabled = true;
            this.yAkse.Location = new System.Drawing.Point(12, 23);
            this.yAkse.Name = "comboBox1";
            this.yAkse.Size = new System.Drawing.Size(50, 21);
            this.yAkse.TabIndex = 1;
            this.yAkse.SelectedIndexChanged += new System.EventHandler(this.xAkse_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.xAkse.Location = new System.Drawing.Point(441, 329);
            this.xAkse.Name = "comboBox2";
            this.xAkse.Size = new System.Drawing.Size(50, 21);
            this.xAkse.TabIndex = 2;
            this.xAkse.SelectedIndexChanged += new System.EventHandler(this.yAkse_SelectedIndexChanged);
            // 
            // visBrugshistorikKnap
            // 
            this.visBrugshistorikKnap.Location = new System.Drawing.Point(209, 20);
            this.visBrugshistorikKnap.Name = "visBrugshistorikKnap";
            this.visBrugshistorikKnap.Size = new System.Drawing.Size(110, 23);
            this.visBrugshistorikKnap.TabIndex = 3;
            this.visBrugshistorikKnap.Text = "Vis brugshistorik";
            this.visBrugshistorikKnap.UseVisualStyleBackColor = true;
            this.visBrugshistorikKnap.Click += new System.EventHandler(this.visBrugshistorikKnap_Click);
            // 
            // visBrugerAdminKnap
            // 
            this.visBrugerAdminKnap.Location = new System.Drawing.Point(325, 20);
            this.visBrugerAdminKnap.Name = "visBrugerAdminKnap";
            this.visBrugerAdminKnap.Size = new System.Drawing.Size(110, 23);
            this.visBrugerAdminKnap.TabIndex = 4;
            this.visBrugerAdminKnap.Text = "Brugeradministration";
            this.visBrugerAdminKnap.UseVisualStyleBackColor = true;
            this.visBrugerAdminKnap.Click += new System.EventHandler(this.visBrugerAdminKnap_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Simuleringsliste 1",
            "Simuleringsliste 2",
            "Simuleringsliste 3",
            "Simuleringsliste 4",
            "Simuleringsliste 5"});
            this.listBox1.Location = new System.Drawing.Point(441, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 69);
            this.listBox1.TabIndex = 5;
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
            this.KorNy.BackColor = System.Drawing.Color.Red;
            this.KorNy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.KorNy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.KorNy.Location = new System.Drawing.Point(441, 193);
            this.KorNy.Name = "KorNy";
            this.KorNy.Size = new System.Drawing.Size(135, 23);
            this.KorNy.TabIndex = 7;
            this.KorNy.Text = "Kør ny";
            this.KorNy.UseVisualStyleBackColor = false;
            this.KorNy.Click += new System.EventHandler(this.KorNy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(543, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 8;
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
            // SimuleringsVindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KorNy);
            this.Controls.Add(this.visSimuleringKnap);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.visBrugerAdminKnap);
            this.Controls.Add(this.visBrugshistorikKnap);
            this.Controls.Add(this.xAkse);
            this.Controls.Add(this.yAkse);
            this.Controls.Add(this.chart1);
            this.Name = "SimuleringsVindue";
            this.Text = "Simulering";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox yAkse;
        private System.Windows.Forms.ComboBox xAkse;
        private System.Windows.Forms.Button visBrugshistorikKnap;
        private System.Windows.Forms.Button visBrugerAdminKnap;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button visSimuleringKnap;
        private System.Windows.Forms.Button KorNy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}