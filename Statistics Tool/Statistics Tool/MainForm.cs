#region imports used
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
#endregion

namespace Statistics_Tool
{
    public partial class MainForm : Form
    {
        // TODO: Revamp the Histogram Form
        // TODO: Create BoxPlot form

        #region constructor
        public MainForm()
        {
            InitializeComponent();
            textBox1.Text = "Enter array elements seperated by commas";
            textBox1.ForeColor = System.Drawing.Color.Gray;
        }
        #endregion

        #region Where the magic happens
        private void button1_Click(object sender, EventArgs e)
        {
            #region Making sure user's entry is in correct format
            if (textBox1.Text != null && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox1.Text) && Regex.IsMatch(textBox1.Text, @"^[-0-9,\s]+$"))
            {
                #region Preparing user's entry for analysis 
                string entry = textBox1.Text.Trim().ToString();
                string[] arr = entry.Split(',');
                double[] doubles = new double[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    doubles[i] = Convert.ToDouble(arr[i].Trim());
                }
                Array.Sort(doubles);
                DataAnalysis da = new DataAnalysis();
                #endregion

                #region Measure Of Center
                meanTxtBox.Text = Math.Round(da.findMean(doubles), 3).ToString();
                if (da.findMedian(doubles) != -100.0)
                    MedianTxtBox.Text = da.findMedian(doubles).ToString();
                else
                    MedianTxtBox.Text = "Error";

                if (da.findModes(doubles) != null)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    double[] modes = da.findModes(doubles);
                    for (int i = 0; i < modes.Length; i++)
                    {
                        stringBuilder.Append(modes[i].ToString());
                        stringBuilder.Append(',');
                    }
                    ModeTxtBox.Text = stringBuilder.ToString().Substring(0, stringBuilder.Length - 1);
                }
                else
                {
                    ModeTxtBox.Text = "No modes for this array";
                }
                #endregion

                #region Measure Of Spread
                standardDeviationTxtBox.Text = Math.Round(da.findStdDeviation(doubles), 3).ToString();
                VarianceTxtBox.Text = Math.Round(da.findVariance(doubles), 3).ToString();

                #region Five Number Summary
                MaxTxtBox.Text = da.getMaxValue(doubles).ToString();
                MinTxtBox.Text = da.getMinValue(doubles).ToString();
                RangeTxtBox.Text = da.range(doubles).ToString();
                double[] fiveNumberSummary = da.findIQR(doubles);
                q1TxtBox.Text = fiveNumberSummary[0].ToString();
                q2TxtBox.Text = fiveNumberSummary[2].ToString();
                iqrTxtBox.Text = fiveNumberSummary[3].ToString();
                #endregion

                #endregion
            }
            else
            {
                Notification toast = new Notification("Data Analysis Tool", "Your entry is not in the correct format", 2, FormAnimator.AnimationMethod.Center, FormAnimator.AnimationDirection.Down);
                toast.Show();
            }
            #endregion
        }
        #endregion

        #region Copy answers to clipboard
        private void meanTxtBox_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(meanTxtBox.Text);
        }

        private void MedianTxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(MedianTxtBox.Text);
        }

        private void ModeTxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(ModeTxtBox.Text);
        }

        private void VarianceTxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(VarianceTxtBox.Text);
        }

        private void standardDeviationTxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(standardDeviationTxtBox.Text);
        }

        private void MinTxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(MinTxtBox.Text);
        }

        private void MaxTxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(MaxTxtBox.Text);
        }

        private void RangeTxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(RangeTxtBox.Text);
        }

        private void q1TxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(q1TxtBox.Text);
        }

        private void q2TxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(q2TxtBox.Text);
        }

        private void iqrTxtBox_TextChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(iqrTxtBox.Text);
        }

        #endregion

        #region Draw histogram
        private void button2_Click(object sender, EventArgs e)
        {
            #region Making sure user's entry is in correct format
            if (textBox1.Text != null && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrWhiteSpace(textBox1.Text) && Regex.IsMatch(textBox1.Text, @"^[-0-9,\s]+$"))
            {
                #region Preparing user's entry for analysis 
                string entry = textBox1.Text.Trim().ToString();
                string[] arr = entry.Split(',');
                double[] doubles = new double[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    doubles[i] = Convert.ToDouble(arr[i].Trim());
                }
                Array.Sort(doubles);
                DataAnalysis da = new DataAnalysis();
                #endregion

                #region Show Histogram
                Histogram histogram = new Histogram(doubles);
                histogram.Show();
                #endregion

                this.Hide();
            }
            else
            {
                Notification toast = new Notification("Data Analysis Tool", "Your entry is not in the correct format", 2, FormAnimator.AnimationMethod.Center, FormAnimator.AnimationDirection.Down);
                toast.Show();
            }
            #endregion
        }
        #endregion

        #region frontend effects
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text.ToString()) || string.IsNullOrEmpty(textBox1.Text.ToString()))
            {
                textBox1.Text = "Enter array elements seperated by commas";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter array elements seperated by commas")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }
        #endregion  
    }
}
