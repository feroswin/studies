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

namespace lab_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n,m;
        int[,] mas = new int[50, 50];


        private void buttonWriteArray_Click(object sender, EventArgs e)
        {
            try
            {
                checkBoxEvenElem.Enabled = true;
                n = ToInt32(textBoxN.Text);
                m = ToInt32(textBoxM.Text);
                dataGridViewArray.ColumnCount = n;
                dataGridViewArray.RowCount = m;
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        dataGridViewArray.Columns[i].Width = 50;
                        mas[i, j] = r.Next(-20, 20);
                        dataGridViewArray[i, j].Value = mas[i, j];
                    }
                }
                if (n != m)
                    checkBoxEvenElem.Enabled = false;
                labelResSquare.Text = "".ToString();
                labelResElem.Text ="".ToString();
            }
            catch (FormatException)
            {
                if (textBoxN.Text.Length == 0 && textBoxM.Text.Length == 0)
                    MessageBox.Show("Поля должны быть заполнены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (textBoxN.Text.Length == 0)
                    MessageBox.Show($"Заполните поле `{label1.Text}`", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Заполните поле `{label2.Text}`", "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int k = 0;
            int max = mas[0, 0];
            if (checkBoxSquare.Checked)
            {
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (max < mas[i, j])
                            max = mas[i, j];
                    }
                labelResSquare.Text = $" (Элемент {max})  {max*max}";
            }
            if (checkBoxEvenElem.Enabled && checkBoxEvenElem.Checked)
            {
                for(int i = 0; i < n; i++)
                    for(int j=0; j<n; j++)
                    {
                        if(j == n-i-1)
                        {
                            if (mas[i, j] % 2 == 0)
                                k++;
                        }
                    }
                labelResElem.Text = k.ToString();
            }
        }


        private void textBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar)) return;
            if (e.KeyChar == ',' || e.KeyChar == '.') e.Handled = true;
            e.Handled = true;
        }


        private void textBoxM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar)) return;
            if (e.KeyChar == ',' || e.KeyChar == '.') e.Handled = true;
            e.Handled = true;
        }
    }
}
