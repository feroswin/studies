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


/*  
    Переписать подряд в массив С положительные, а в массив М отрицательные
    элементы исходного одномерного массива
*/

namespace lab_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearArray()
        {
            dataGridViewArrayC.Rows.Clear();
            dataGridViewArrayC.Columns.Clear();
            dataGridViewArrayM.Rows.Clear();
            dataGridViewArrayM.Columns.Clear();
        }


        int n;
        double[] mas = new double[50];


        private void buttonCreateArray_Click(object sender, EventArgs e)
        {
            try
            {
                n = ToInt32(textBox1.Text);
                Random r = new Random();
                dataGridViewArray.ColumnCount = n;
                dataGridViewArray.RowCount = 1;
                for (int i = 0; i < n; i++)
                {
                    mas[i] = r.Next(-8, 8) / 2.0;
                    dataGridViewArray[i, 0].Value = mas[i];
                }
                ClearArray();
            } catch (FormatException ex)
            {
                if (textBox1.Text.Length == 0)
                    MessageBox.Show("Поле обязательно должно быть заполнено", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonReWrite_Click(object sender, EventArgs e)
        {
            int k=0;
            dataGridViewArrayC.ColumnCount = n;
            dataGridViewArrayC.RowCount = 1;
            for (int i = 0; i < n; i++)
                if (mas[i] > 0)
                    for (int j = k; j < n; j++)
                    {
                        dataGridViewArrayC[j, 0].Value = mas[i];
                        k++;
                        break;
                    }
            k = 0;
            dataGridViewArrayM.ColumnCount = n;
            dataGridViewArrayM.RowCount = 1;
            for (int i = 0; i < n; i++)
                if (mas[i] < 0)
                    for (int j = k; j < n; j++)
                    {
                        dataGridViewArrayM[j, 0].Value = mas[i];
                        k++;
                        break;
                    }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar))
                return;
            e.Handled = true;
        }
    }
}
