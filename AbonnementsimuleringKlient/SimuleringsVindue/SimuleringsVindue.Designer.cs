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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimuleringsVindue));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yAkse = new System.Windows.Forms.ComboBox();
            this.xAkse = new System.Windows.Forms.ComboBox();
            this.visBrugerAdminKnap = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.KorNy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 50);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(423, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(441, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 95);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(543, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(453, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Index tal skal\r\n være heltal";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.InitialImage = global::AbonnementsimuleringKlient.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(477, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SimuleringsVindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KorNy);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.visBrugerAdminKnap);
            this.Controls.Add(this.xAkse);
            this.Controls.Add(this.yAkse);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SimuleringsVindue";
            this.Text = "Simulering";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox yAkse;
        private System.Windows.Forms.ComboBox xAkse;
        private System.Windows.Forms.Button visBrugerAdminKnap;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button KorNy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}