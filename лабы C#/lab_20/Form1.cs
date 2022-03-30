using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_20
{
    public partial class Form1 : Form
    {
        Graphics gr;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public void Print(int x1, int y1,int W, int H, int single1, int single2)
        {
            Random rnd = new Random();
            int col = rnd.Next();
            Color color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            SolidBrush brush = new SolidBrush(color);
            Pen pen = new Pen(color, 1.7f);
            gr.FillPie(brush, x1, y1, W, H, single1, single2);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x1, y1, dopW, dopH, single1, single2;
            timer1.Interval = 10;
            int W = pictureBox1.Width;
            int H = pictureBox1.Height;
            x1 = r.Next(-W / 2, W);
            y1 = r.Next(-H / 2, H);
            single1 = r.Next(-270, 270);
            single2 = r.Next(-270, 270);
            dopW = r.Next(W / 4, W/2);
            dopH = r.Next(H / 4, H/2);
            Print(x1, y1, dopW, dopH, single1, single2);
        }
    }
}
