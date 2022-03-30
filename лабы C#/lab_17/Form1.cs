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


namespace lab_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res=0, k;
            try
            {
                if (checkBoxMM.Checked)
                {
                    k = ToDouble(textBoxMM.Text);
                    res += k;
                }
                if (checkBoxSM.Checked)
                {
                    k = ToDouble(textBoxSM.Text);
                    res += k * 10;
                }
                if (checkBoxMetr.Checked)
                {
                    k = ToDouble(textBoxMetr.Text);
                    res += k * 1000;
                }
                labelResult.Text = res.ToString();
            } catch (FormatException ex)
            {
                if((checkBoxMM.Checked == true && textBoxMM.Text.Length == 0) 
                  || (checkBoxSM.Checked == true && textBoxSM.Text.Length ==0)
                  || (checkBoxMetr.Checked == true && textBoxMetr.Text.Length == 0))
                {
                    MessageBox.Show("Заполните поля для выделенных вами CheckBox", "ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxMM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxMM.Text.IndexOf(',') != -1 || (textBoxMM.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void textBoxSM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxSM.Text.IndexOf(',') != -1 || (textBoxSM.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void textBoxMetr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBoxMetr.Text.IndexOf(',') != -1 || (textBoxMetr.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void checkBoxMM_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMM.Focus();
        }

        private void checkBoxSM_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSM.Focus();
        }

        private void checkBoxMetr_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMetr.Focus();
        }
    }
}
