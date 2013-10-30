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
            this.SuspendLayout();
            // 
            // tidsInterval
            // 
            this.tidsInterval.FormattingEnabled = true;
            this.tidsInterval.Location = new System.Drawing.Point(13, 13);
            this.tidsInterval.Name = "tidsInterval";
            this.tidsInterval.Size = new System.Drawing.Size(120, 95);
            this.tidsInterval.TabIndex = 0;
            // 
            // historikType
            // 
            this.historikType.FormattingEnabled = true;
            this.historikType.Location = new System.Drawing.Point(247, 12);
            this.historikType.Name = "historikType";
            this.historikType.Size = new System.Drawing.Size(120, 95);
            this.historikType.TabIndex = 1;
            // 
            // id
            // 
            this.id.FormattingEnabled = true;
            this.id.Location = new System.Drawing.Point(454, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(120, 95);
            this.id.TabIndex = 2;
            // 
            // BrugsHistorikVindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 486);
            this.Controls.Add(this.id);
            this.Controls.Add(this.historikType);
            this.Controls.Add(this.tidsInterval);
            this.Name = "BrugsHistorikVindue";
            this.Text = "BrugsHistorikVindue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox tidsInterval;
        private System.Windows.Forms.ListBox historikType;
        private System.Windows.Forms.ListBox id;
    }
}