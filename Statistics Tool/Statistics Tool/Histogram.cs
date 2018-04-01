using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics_Tool
{
    public partial class Histogram : Form
    {
        private double[] DataValues;

        public Histogram(double[] arr)
        {
            InitializeComponent();
            DataValues = arr;
        }

        // Draw a histogram.
        private void DrawHistogram(Graphics gr, Color back_color, double[] values, int width, int height)
        {
            //Color[] Colors = new Color[] { Color.Red, Color.LightGreen, Color.Blue, Color.Pink, Color.Green, Color.LightBlue, Color.Orange, Color.Yellow, Color.Purple };
            Color[] Colors = new Color[] { Color.FromArgb(5, 11, 230) };

            gr.Clear(back_color);

            // Make a transformation to the PictureBox.
            DataAnalysis da = new DataAnalysis();
            RectangleF data_bounds = new RectangleF(0, 0, values.Length, (float)da.getMaxValue(values));
            PointF[] points = { new PointF(0, height), new PointF(width, height), new PointF(0, 0) };
            Matrix transformation = new Matrix(data_bounds, points);
            gr.Transform = transformation;

            // Draw the histogram.
            using (Pen thin_pen = new Pen(Color.White, 0))
            {
                for (int i = 0; i < values.Length; i++)
                {
                    RectangleF rect = new RectangleF(i, 0, 1, (float)values[i]);
                    using (Brush the_brush = new SolidBrush(Colors[i % Colors.Length]))
                    {
                        gr.FillRectangle(the_brush, rect);
                        gr.DrawRectangle(thin_pen, rect.X, rect.Y, rect.Width, rect.Height);
                    }
                }
            }

            gr.ResetTransform();
            gr.DrawRectangle(Pens.Black, 0, 0, width - 1, height - 1);
        }

        // Display the value clicked.
        private void picHisto_MouseDown(object sender, MouseEventArgs e)
        {
            // Determine which data value was clicked.
            float bar_wid = picHisto.ClientSize.Width / (int)DataValues.Length;
            int i = (int)(e.X / bar_wid);
            Notification toast = new Notification("Data Analysis Tool", string.Format("Bar {0} has value of {1}", i + 1, DataValues[i]), 2, FormAnimator.AnimationMethod.Slide, FormAnimator.AnimationDirection.Right);
            toast.Show();
        }

        // Draw the histogram.
        private void picHisto_Paint(object sender, PaintEventArgs e)
        {
            DrawHistogram(e.Graphics, Color.White, DataValues, picHisto.ClientSize.Width, picHisto.ClientSize.Height);
        }

        private void Histogram_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Histogram_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Notification toast = new Notification("Data Analysis Tool", " A histogram provides a snapshot of all the data, making it a quick way to get the big picture of the data. \n A histogram, the bars connect to each other — as opposed to a bar graph for categorical data, where the bars represent categories that don’t have a particular order, and are separated. The height of each bar of a histogram represents either the number of individuals (called the frequency) in each group or the percentage of individuals (the relative frequency) in each group", 2, FormAnimator.AnimationMethod.Roll, FormAnimator.AnimationDirection.Left);
            toast.Show();
        }
    }
}
