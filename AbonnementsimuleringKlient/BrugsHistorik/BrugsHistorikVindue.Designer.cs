namespace AbonnementsimuleringKlient
{
    partial class BrugsHistorikVindue
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
            this.tidsInterval = new System.Windows.Forms.ListBox();
            this.historikType = new System.Windows.Forms.ListBox();
            this.id = new System.Windows.Forms.ListBox();
            this.tidsIntervalValg = new System.Windows.Forms.ComboBox();
            this.historikTypeValg = new System.Windows.Forms.ComboBox();
            this.idValg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tidsInterval
            // 
            this.tidsInterval.FormattingEnabled = true;
            this.tidsInterval.Location = new System.Drawing.Point(12, 39);
            this.tidsInterval.Name = "tidsInterval";
            this.tidsInterval.Size = new System.Drawing.Size(203, 433);
            this.tidsInterval.TabIndex = 0;
            // 
            // historikType
            // 
            this.historikType.FormattingEnabled = true;
            this.historikType.Location = new System.Drawing.Point(235, 39);
            this.historikType.Name = "historikType";
            this.historikType.Size = new System.Drawing.Size(203, 433);
            this.historikType.TabIndex = 1;
            // 
            // id
            // 
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(460, 39);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(194, 433);
            this.id.TabIndex = 2;
            // 
            // tidsIntervalValg
            // 
            this.tidsIntervalValg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tidsIntervalValg.FormattingEnabled = true;
            this.tidsIntervalValg.Location = new System.Drawing.Point(12, 12);
            this.tidsIntervalValg.Name = "tidsIntervalValg";
            this.tidsIntervalValg.Size = new System.Drawing.Size(121, 21);
            this.tidsIntervalValg.TabIndex = 3;
            // 
            // historikTypeValg
            // 
            this.historikTypeValg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.historikTypeValg.FormattingEnabled = true;
            this.historikTypeValg.Location = new System.Drawing.Point(234, 12);
            this.historikTypeValg.Name = "historikTypeValg";
            this.historikTypeValg.Size = new System.Drawing.Size(121, 21);
            this.historikTypeValg.TabIndex = 4;
            // 
            // idValg
            // 
            this.idValg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idValg.FormattingEnabled = true;
            this.idValg.Location = new System.Drawing.Point(460, 12);
            this.idValg.Name = "idValg";
            this.idValg.Size = new System.Drawing.Size(121, 21);
            this.idValg.TabIndex = 5;
            // 
            // BrugsHistorikVindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 486);
            this.Controls.Add(this.idValg);
            this.Controls.Add(this.historikTypeValg);
            this.Controls.Add(this.tidsIntervalValg);
            this.Controls.Add(this.id);
            this.Controls.Add(this.historikType);
            this.Controls.Add(this.tidsInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BrugsHistorikVindue";
            this.Text = "BrugsHistorikVindue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox tidsInterval;
        private System.Windows.Forms.ListBox historikType;
        private System.Windows.Forms.ListBox id;
        private System.Windows.Forms.ComboBox tidsIntervalValg;
        private System.Windows.Forms.ComboBox historikTypeValg;
        private System.Windows.Forms.ComboBox idValg;
    }
}