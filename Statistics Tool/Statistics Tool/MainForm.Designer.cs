namespace Statistics_Tool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ModeTxtBox = new System.Windows.Forms.TextBox();
            this.standardDeviationTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RangeTxtBox = new System.Windows.Forms.TextBox();
            this.VarianceTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MinTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MedianTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.meanTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.iqrTxtBox = new System.Windows.Forms.TextBox();
            this.q2TxtBox = new System.Windows.Forms.TextBox();
            this.q1TxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(18, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(29, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Analyze Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModeTxtBox
            // 
            this.ModeTxtBox.Enabled = false;
            this.ModeTxtBox.ForeColor = System.Drawing.Color.Black;
            this.ModeTxtBox.Location = new System.Drawing.Point(141, 252);
            this.ModeTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModeTxtBox.Name = "ModeTxtBox";
            this.ModeTxtBox.Size = new System.Drawing.Size(176, 30);
            this.ModeTxtBox.TabIndex = 33;
            this.ModeTxtBox.TextChanged += new System.EventHandler(this.ModeTxtBox_TextChanged);
            // 
            // standardDeviationTxtBox
            // 
            this.standardDeviationTxtBox.Enabled = false;
            this.standardDeviationTxtBox.ForeColor = System.Drawing.Color.Black;
            this.standardDeviationTxtBox.Location = new System.Drawing.Point(141, 367);
            this.standardDeviationTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.standardDeviationTxtBox.Name = "standardDeviationTxtBox";
            this.standardDeviationTxtBox.Size = new System.Drawing.Size(176, 30);
            this.standardDeviationTxtBox.TabIndex = 38;
            this.standardDeviationTxtBox.TextChanged += new System.EventHandler(this.standardDeviationTxtBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mean";
            // 
            // MaxTxtBox
            // 
            this.MaxTxtBox.Enabled = false;
            this.MaxTxtBox.ForeColor = System.Drawing.Color.Black;
            this.MaxTxtBox.Location = new System.Drawing.Point(496, 182);
            this.MaxTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaxTxtBox.Name = "MaxTxtBox";
            this.MaxTxtBox.Size = new System.Drawing.Size(176, 30);
            this.MaxTxtBox.TabIndex = 37;
            this.MaxTxtBox.TextChanged += new System.EventHandler(this.MaxTxtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(380, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Min";
            // 
            // RangeTxtBox
            // 
            this.RangeTxtBox.Enabled = false;
            this.RangeTxtBox.ForeColor = System.Drawing.Color.Black;
            this.RangeTxtBox.Location = new System.Drawing.Point(496, 245);
            this.RangeTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RangeTxtBox.Name = "RangeTxtBox";
            this.RangeTxtBox.Size = new System.Drawing.Size(176, 30);
            this.RangeTxtBox.TabIndex = 36;
            this.RangeTxtBox.TextChanged += new System.EventHandler(this.RangeTxtBox_TextChanged);
            // 
            // VarianceTxtBox
            // 
            this.VarianceTxtBox.Enabled = false;
            this.VarianceTxtBox.ForeColor = System.Drawing.Color.Black;
            this.VarianceTxtBox.Location = new System.Drawing.Point(141, 311);
            this.VarianceTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VarianceTxtBox.Name = "VarianceTxtBox";
            this.VarianceTxtBox.Size = new System.Drawing.Size(176, 30);
            this.VarianceTxtBox.TabIndex = 35;
            this.VarianceTxtBox.TextChanged += new System.EventHandler(this.VarianceTxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 67);
            this.label5.TabIndex = 24;
            this.label5.Text = "Std Deviation";
            // 
            // MinTxtBox
            // 
            this.MinTxtBox.Enabled = false;
            this.MinTxtBox.ForeColor = System.Drawing.Color.Black;
            this.MinTxtBox.Location = new System.Drawing.Point(496, 122);
            this.MinTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinTxtBox.Name = "MinTxtBox";
            this.MinTxtBox.Size = new System.Drawing.Size(176, 30);
            this.MinTxtBox.TabIndex = 34;
            this.MinTxtBox.TextChanged += new System.EventHandler(this.MinTxtBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(380, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 311);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Variance";
            // 
            // MedianTxtBox
            // 
            this.MedianTxtBox.Enabled = false;
            this.MedianTxtBox.ForeColor = System.Drawing.Color.Black;
            this.MedianTxtBox.Location = new System.Drawing.Point(141, 189);
            this.MedianTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MedianTxtBox.Name = "MedianTxtBox";
            this.MedianTxtBox.Size = new System.Drawing.Size(176, 30);
            this.MedianTxtBox.TabIndex = 32;
            this.MedianTxtBox.TextChanged += new System.EventHandler(this.MedianTxtBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(380, 252);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Range";
            // 
            // meanTxtBox
            // 
            this.meanTxtBox.Enabled = false;
            this.meanTxtBox.ForeColor = System.Drawing.Color.Black;
            this.meanTxtBox.Location = new System.Drawing.Point(141, 127);
            this.meanTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meanTxtBox.Name = "meanTxtBox";
            this.meanTxtBox.Size = new System.Drawing.Size(176, 30);
            this.meanTxtBox.TabIndex = 31;
            this.meanTxtBox.DoubleClick += new System.EventHandler(this.meanTxtBox_DoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 189);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Median";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 252);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Mode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(380, 362);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Q3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(380, 306);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "Q1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(380, 418);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 20);
            this.label14.TabIndex = 41;
            this.label14.Text = "IQR";
            // 
            // iqrTxtBox
            // 
            this.iqrTxtBox.Enabled = false;
            this.iqrTxtBox.ForeColor = System.Drawing.Color.Black;
            this.iqrTxtBox.Location = new System.Drawing.Point(496, 418);
            this.iqrTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iqrTxtBox.Name = "iqrTxtBox";
            this.iqrTxtBox.Size = new System.Drawing.Size(176, 30);
            this.iqrTxtBox.TabIndex = 42;
            this.iqrTxtBox.TextChanged += new System.EventHandler(this.iqrTxtBox_TextChanged);
            // 
            // q2TxtBox
            // 
            this.q2TxtBox.Enabled = false;
            this.q2TxtBox.ForeColor = System.Drawing.Color.Black;
            this.q2TxtBox.Location = new System.Drawing.Point(496, 362);
            this.q2TxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.q2TxtBox.Name = "q2TxtBox";
            this.q2TxtBox.Size = new System.Drawing.Size(176, 30);
            this.q2TxtBox.TabIndex = 43;
            this.q2TxtBox.TextChanged += new System.EventHandler(this.q2TxtBox_TextChanged);
            // 
            // q1TxtBox
            // 
            this.q1TxtBox.Enabled = false;
            this.q1TxtBox.ForeColor = System.Drawing.Color.Black;
            this.q1TxtBox.Location = new System.Drawing.Point(496, 306);
            this.q1TxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.q1TxtBox.Name = "q1TxtBox";
            this.q1TxtBox.Size = new System.Drawing.Size(176, 30);
            this.q1TxtBox.TabIndex = 44;
            this.q1TxtBox.TextChanged += new System.EventHandler(this.q1TxtBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(475, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Powered by: Ahmed ElSheikh";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(221, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 32);
            this.button2.TabIndex = 46;
            this.button2.Text = "Plot Histogram";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Data_Analysis_Tool.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(716, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.q1TxtBox);
            this.Controls.Add(this.q2TxtBox);
            this.Controls.Add(this.iqrTxtBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ModeTxtBox);
            this.Controls.Add(this.standardDeviationTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RangeTxtBox);
            this.Controls.Add(this.VarianceTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MinTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MedianTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.meanTxtBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Analysis Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ModeTxtBox;
        private System.Windows.Forms.TextBox standardDeviationTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RangeTxtBox;
        private System.Windows.Forms.TextBox VarianceTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MinTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MedianTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox meanTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox iqrTxtBox;
        private System.Windows.Forms.TextBox q2TxtBox;
        private System.Windows.Forms.TextBox q1TxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

