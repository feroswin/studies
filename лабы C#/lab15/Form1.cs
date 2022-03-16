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
using static System.Console;

namespace lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double De, Mn, result, result1;
            char sign;
            try
            {
                De = ToDouble(textBoxDe.Text);
                Mn = ToDouble(textBoxMn.Text);
                sign = ToChar(textBoxSign.Text);
                if (sign == '+')
                {
                    result = De * De + Mn * Mn * (-1);
                    result1 = 2 * De * Mn;
                    label6.Text = result.ToString("f2") + " + " + result1.ToString("f2") + "i"; 
                } 
                else
                {
                    result = De * De + Mn * Mn * (-1);
                    result1 = 2 * De * Mn;
                    label6.Text = result.ToString("f2") + " - " + result1.ToString("f2") + "i";
                }
            } catch (FormatException ex)
            {
                if (textBoxDe.Text.Length == 0 || (textBoxMn.Text.Length == 0) || (textBoxSign.Text.Length == 0))
                    MessageBox.Show("Поля должны быть заполнены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((textBoxDe.Text.IndexOf(',') != -1) || (textBoxDe.Text.Length == 0))
                    e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    textBoxSign.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBoxSign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '+') || (e.KeyChar == '-')) return;
            if (Char.IsControl(e.KeyChar)) 
            { 
                if (e.KeyChar == (char)Keys.Enter)
                    textBoxMn.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBoxMn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if ((textBoxMn.Text.IndexOf(',') != -1) || (textBoxMn.Text.Length == 0))
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
    }
}
