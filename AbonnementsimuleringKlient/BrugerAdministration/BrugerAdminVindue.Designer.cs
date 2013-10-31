namespace AbonnementsimuleringKlient
{
    partial class BrugerAdminVindue
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
            this.fornavn = new System.Windows.Forms.TextBox();
            this.efternavn = new System.Windows.Forms.TextBox();
            this.medarbejdernummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.instillinger = new System.Windows.Forms.Button();
            this.opretBruger = new System.Windows.Forms.Button();
            this.sletBruger = new System.Windows.Forms.Button();
            this.gemBruger = new System.Windows.Forms.Button();
            this.ansvarlig = new System.Windows.Forms.CheckBox();
            this.medarbejdere = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medarbejdere)).BeginInit();
            this.SuspendLayout();
            // 
            // fornavn
            // 
            this.fornavn.Location = new System.Drawing.Point(138, 28);
            this.fornavn.Name = "fornavn";
            this.fornavn.Size = new System.Drawing.Size(139, 20);
            this.fornavn.TabIndex = 1;
            // 
            // efternavn
            // 
            this.efternavn.Location = new System.Drawing.Point(138, 79);
            this.efternavn.Name = "efternavn";
            this.efternavn.Size = new System.Drawing.Size(139, 20);
            this.efternavn.TabIndex = 2;
            // 
            // medarbejdernummer
            // 
            this.medarbejdernummer.Location = new System.Drawing.Point(138, 132);
            this.medarbejdernummer.Name = "medarbejdernummer";
            this.medarbejdernummer.Size = new System.Drawing.Size(139, 20);
            this.medarbejdernummer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fornavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Efternavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Medarbejdernummer";
            // 
            // instillinger
            // 
            this.instillinger.Location = new System.Drawing.Point(283, 28);
            this.instillinger.Name = "instillinger";
            this.instillinger.Size = new System.Drawing.Size(108, 23);
            this.instillinger.TabIndex = 7;
            this.instillinger.Text = "Instillinger";
            this.instillinger.UseVisualStyleBackColor = true;
            this.instillinger.Click += new System.EventHandler(this.instillinger_Click);
            // 
            // opretBruger
            // 
            this.opretBruger.Location = new System.Drawing.Point(283, 79);
            this.opretBruger.Name = "opretBruger";
            this.opretBruger.Size = new System.Drawing.Size(108, 23);
            this.opretBruger.TabIndex = 8;
            this.opretBruger.Text = "Opret";
            this.opretBruger.UseVisualStyleBackColor = true;
            this.opretBruger.Click += new System.EventHandler(this.opretBruger_Click);
            // 
            // sletBruger
            // 
            this.sletBruger.Location = new System.Drawing.Point(283, 130);
            this.sletBruger.Name = "sletBruger";
            this.sletBruger.Size = new System.Drawing.Size(108, 23);
            this.sletBruger.TabIndex = 9;
            this.sletBruger.Text = "Slet";
            this.sletBruger.UseVisualStyleBackColor = true;
            this.sletBruger.Click += new System.EventHandler(this.sletBruger_Click);
            // 
            // gemBruger
            // 
            this.gemBruger.Location = new System.Drawing.Point(283, 259);
            this.gemBruger.Name = "gemBruger";
            this.gemBruger.Size = new System.Drawing.Size(108, 30);
            this.gemBruger.TabIndex = 10;
            this.gemBruger.Text = "Gem";
            this.gemBruger.UseVisualStyleBackColor = true;
            this.gemBruger.Click += new System.EventHandler(this.gemBruger_Click);
            // 
            // ansvarlig
            // 
            this.ansvarlig.AutoSize = true;
            this.ansvarlig.Location = new System.Drawing.Point(138, 167);
            this.ansvarlig.Name = "ansvarlig";
            this.ansvarlig.Size = new System.Drawing.Size(69, 17);
            this.ansvarlig.TabIndex = 11;
            this.ansvarlig.Text = "Ansvarlig";
            this.ansvarlig.UseVisualStyleBackColor = true;
            // 
            // medarbejdere
            // 
            this.medarbejdere.AllowUserToAddRows = false;
            this.medarbejdere.AllowUserToDeleteRows = false;
            this.medarbejdere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medarbejdere.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NavnColumn});
            this.medarbejdere.Dock = System.Windows.Forms.DockStyle.Left;
            this.medarbejdere.Location = new System.Drawing.Point(0, 0);
            this.medarbejdere.Name = "medarbejdere";
            this.medarbejdere.ReadOnly = true;
            this.medarbejdere.RowHeadersVisible = false;
            this.medarbejdere.Size = new System.Drawing.Size(132, 301);
            this.medarbejdere.TabIndex = 12;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            // 
            // NavnColumn
            // 
            this.NavnColumn.HeaderText = "Navn";
            this.NavnColumn.Name = "NavnColumn";
            this.NavnColumn.ReadOnly = true;
            // 
            // BrugerAdminVindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 301);
            this.Controls.Add(this.medarbejdere);
            this.Controls.Add(this.ansvarlig);
            this.Controls.Add(this.gemBruger);
            this.Controls.Add(this.sletBruger);
            this.Controls.Add(this.opretBruger);
            this.Controls.Add(this.instillinger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medarbejdernummer);
            this.Controls.Add(this.efternavn);
            this.Controls.Add(this.fornavn);
            this.Name = "BrugerAdminVindue";
            this.Text = "Brugeradministration";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.medarbejdere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fornavn;
        private System.Windows.Forms.TextBox efternavn;
        private System.Windows.Forms.TextBox medarbejdernummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button instillinger;
        private System.Windows.Forms.Button opretBruger;
        private System.Windows.Forms.Button sletBruger;
        private System.Windows.Forms.Button gemBruger;
        private System.Windows.Forms.CheckBox ansvarlig;
        private System.Windows.Forms.DataGridView medarbejdere;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NavnColumn;
    }
}