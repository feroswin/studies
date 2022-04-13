using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database61DataSet.Сведения_об_организации". При необходимости она может быть перемещена или удалена.
            this.сведения_об_организацииTableAdapter.Fill(this.database61DataSet.Сведения_об_организации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database61DataSet.Информация_о_сотрудниках". При необходимости она может быть перемещена или удалена.
            this.информация_о_сотрудникахTableAdapter.Fill(this.database61DataSet.Информация_о_сотрудниках);

        }

        private void Sort_enterprises_Click(object sender, EventArgs e)
        {
            if (dataGridView_Enterprises.SortOrder == SortOrder.Ascending)
                dataGridView_Enterprises.Sort(dataGridView_Enterprises.Columns[1], ListSortDirection.Descending);
            else dataGridView_Enterprises.Sort(dataGridView_Enterprises.Columns[1], ListSortDirection.Ascending);
        }

        private void textBoxCharacter_Search_Enterprises_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_Enterprises.RowCount - 1; i++)
            {
                string str = dataGridView_Enterprises.Rows[i].Cells[1].Value.ToString();
                if (str.Contains(textBox1.Text) == true) dataGridView_Enterprises.Rows[i].Selected = true;
                else dataGridView_Enterprises.Rows[i].Selected = false;
                if (textBox1.Text == "") dataGridView_Enterprises.Rows[i].Selected = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_Enterprises.RowCount - 1; i++)
            {
                string str = dataGridView_Enterprises.Rows[i].Cells[1].Value.ToString();
                if (str == textBox2.Text) dataGridView_Enterprises.Rows[i].Selected = true;
                else dataGridView_Enterprises.Rows[i].Selected = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView_Employees.SortOrder == SortOrder.Ascending)
                dataGridView_Employees.Sort(dataGridView_Employees.Columns[1], ListSortDirection.Descending);
            else dataGridView_Employees.Sort(dataGridView_Employees.Columns[1], ListSortDirection.Ascending);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_Employees.RowCount - 1; i++)
            {
                string str = dataGridView_Employees.Rows[i].Cells[1].Value.ToString();
                if (str.Contains(textBox3.Text) == true) dataGridView_Employees.Rows[i].Selected = true;
                else dataGridView_Employees.Rows[i].Selected = false;
                if (textBox3.Text == "") dataGridView_Employees.Rows[i].Selected = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_Employees.RowCount - 1; i++)
            {
                string str = dataGridView_Employees.Rows[i].Cells[1].Value.ToString();
                if (str == textBox4.Text) dataGridView_Employees.Rows[i].Selected = true;
                else dataGridView_Employees.Rows[i].Selected = false;
            }
        }
    }
}
