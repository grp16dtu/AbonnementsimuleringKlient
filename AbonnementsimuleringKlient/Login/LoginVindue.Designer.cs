namespace AbonnementsimuleringKlient
{
    partial class LoginVindue
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
            this.brugernavn = new System.Windows.Forms.TextBox();
            this.kodeord = new System.Windows.Forms.TextBox();
            this.logindKnap = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opretKontoKnap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brugernavn
            // 
            this.brugernavn.Location = new System.Drawing.Point(12, 21);
            this.brugernavn.Name = "brugernavn";
            this.brugernavn.Size = new System.Drawing.Size(175, 20);
            this.brugernavn.TabIndex = 0;
            this.brugernavn.Tag = "";
            // 
            // kodeord
            // 
            this.kodeord.Location = new System.Drawing.Point(12, 72);
            this.kodeord.Name = "kodeord";
            this.kodeord.Size = new System.Drawing.Size(175, 20);
            this.kodeord.TabIndex = 1;
            this.kodeord.UseSystemPasswordChar = true;
            // 
            // logindKnap
            // 
            this.logindKnap.Location = new System.Drawing.Point(12, 98);
            this.logindKnap.Name = "logindKnap";
            this.logindKnap.Size = new System.Drawing.Size(175, 23);
            this.logindKnap.TabIndex = 2;
            this.logindKnap.Text = "Log ind";
            this.logindKnap.UseVisualStyleBackColor = true;
            this.logindKnap.Click += new System.EventHandler(this.LoginKnap_Klikket);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(20, 153);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(159, 13);
            this.status.TabIndex = 3;
            this.status.Text = "Indtast brugernavn og password";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brugernavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kodeord";
            // 
            // opretKontoKnap
            // 
            this.opretKontoKnap.Location = new System.Drawing.Point(12, 127);
            this.opretKontoKnap.Name = "opretKontoKnap";
            this.opretKontoKnap.Size = new System.Drawing.Size(175, 23);
            this.opretKontoKnap.TabIndex = 6;
            this.opretKontoKnap.Text = "Opret Konto";
            this.opretKontoKnap.UseVisualStyleBackColor = true;
            this.opretKontoKnap.Click += new System.EventHandler(this.opretKontoKnap_Klikket);
            // 
            // LoginVindue
            // 
            this.AcceptButton = this.logindKnap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 177);
            this.Controls.Add(this.opretKontoKnap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.logindKnap);
            this.Controls.Add(this.kodeord);
            this.Controls.Add(this.brugernavn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginVindue";
            this.Text = "Logind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox brugernavn;
        private System.Windows.Forms.TextBox kodeord;
        private System.Windows.Forms.Button logindKnap;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button opretKontoKnap;
    }
}

