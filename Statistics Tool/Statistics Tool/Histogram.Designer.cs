namespace Statistics_Tool
{
    partial class Histogram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Histogram));
            this.picHisto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHisto)).BeginInit();
            this.SuspendLayout();
            // 
            // picHisto
            // 
            this.picHisto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHisto.Location = new System.Drawing.Point(0, 0);
            this.picHisto.Name = "picHisto";
            this.picHisto.Size = new System.Drawing.Size(714, 603);
            this.picHisto.TabIndex = 0;
            this.picHisto.TabStop = false;
            this.picHisto.Paint += new System.Windows.Forms.PaintEventHandler(this.picHisto_Paint);
            this.picHisto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picHisto_MouseDown);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 603);
            this.Controls.Add(this.picHisto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Histogram";
            this.Text = "Histogram";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Histogram_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picHisto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHisto;
    }
}