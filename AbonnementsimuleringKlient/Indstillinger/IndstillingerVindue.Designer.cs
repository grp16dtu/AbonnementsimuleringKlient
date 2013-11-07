namespace AbonnementsimuleringKlient
{
    partial class IndstillingerVindue
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
            this.economicAftalenummer = new System.Windows.Forms.TextBox();
            this.economicBrugernavn = new System.Windows.Forms.TextBox();
            this.economicKodeord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // economicAftalenummer
            // 
            this.economicAftalenummer.Location = new System.Drawing.Point(12, 31);
            this.economicAftalenummer.Name = "economicAftalenummer";
            this.economicAftalenummer.Size = new System.Drawing.Size(163, 20);
            this.economicAftalenummer.TabIndex = 0;
            // 
            // economicBrugernavn
            // 
            this.economicBrugernavn.Location = new System.Drawing.Point(12, 70);
            this.economicBrugernavn.Name = "economicBrugernavn";
            this.economicBrugernavn.Size = new System.Drawing.Size(163, 20);
            this.economicBrugernavn.TabIndex = 1;
            // 
            // economicKodeord
            // 
            this.economicKodeord.Location = new System.Drawing.Point(12, 109);
            this.economicKodeord.Name = "economicKodeord";
            this.economicKodeord.Size = new System.Drawing.Size(163, 20);
            this.economicKodeord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Economic aftalenummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Economic brugernavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Economic kodeord";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IndstillingerVindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 187);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.economicKodeord);
            this.Controls.Add(this.economicBrugernavn);
            this.Controls.Add(this.economicAftalenummer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IndstillingerVindue";
            this.Text = "Indstillinger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox economicAftalenummer;
        private System.Windows.Forms.TextBox economicBrugernavn;
        private System.Windows.Forms.TextBox economicKodeord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}