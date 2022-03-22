using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;

namespace lab_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum;
            try
            {
                sum = ToDouble(textBox1.Text);
                if (radioButtonDoll.Checked)
                {
                    sum = sum * 108.05;
                    label4.Text = sum.ToString("0.###") + " рублей";
                }
                else
                {
                    sum = sum * 0.009;
                    label4.Text = sum.ToString("0.###") + " долларов";
                }
            } catch (FormatException ex)
            {
                if (textBox1.Text.Length == 0)
                    MessageBox.Show("Поля должны быть заполенены", "ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }
    }
}
