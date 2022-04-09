using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace lab_21._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen myPen = new Pen(Color.Blue);
            int w = pictureBox1.Width, h = pictureBox1.Height;
            float xmin = -10, xmax = 10, ymin = -10, ymax = 10;
            float xstep = (xmax - xmin) / w;
            float kx = w / (xmax - xmin), ky = h / (ymax - ymin);
            float x1 = xmin, y1 = Convert.ToSingle(Pow(Cos(x1), 2) - Sin(2 * x1)), x2, y2;

            Pen Pen1 = new Pen(Color.Black);
            g.DrawLine(Pen1, 0, h / 2, w, h / 2);
            g.DrawLine(Pen1, w / 2, 0, w / 2, h);

            for (int i = 0; i < w; i++)
            {
                x2 = x1 + xstep;
                y2 = Convert.ToSingle(Pow(Cos(x2), 2) - Sin(2 * x2));
                g.DrawLine(myPen, kx * (x1 - xmin), h - ky * (y1 - ymin), kx * (x2 - xmin), h - ky * (y2 - ymin));
                x1 = x2;
                y1 = y2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 20);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-1, 1);
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
            for (int i = 0; i < 20; i++)
            {
                chart1.Series[0].Points.AddXY(i, Pow(Cos(i), 2) - Sin(2 * i));
            }
        }

        int N = 19;

        private void timer1_Tick(object sender, EventArgs e)
        {
            N++;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, N);
            chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.AddXY(N, Pow(Cos(N), 2) - Sin(2 * N));
            chart1.ChartAreas[0].AxisX.Minimum = N - 20;
            chart1.ChartAreas[0].AxisX.Maximum = N;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button2.Text = "Старт";
            }
            else
            {
                timer1.Enabled = true;
                button2.Text = "Стоп";
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = hScrollBar1.Value;
        }
    }
}
