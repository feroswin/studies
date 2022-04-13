using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Convert;

namespace lab_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        double s = 0;


        // Загрузить в файл
        private void button2_Click(object sender, EventArgs e)
        {
            FileStream filestream = new FileStream("file.txt", FileMode.OpenOrCreate, FileAccess.Write);
            filestream.SetLength(0);
            StreamWriter streamwriter = new StreamWriter(filestream);
            for (int i = 0; i < listBox1.Items.Count; i++)
                streamwriter.WriteLine(listBox1.Items[i].ToString());
            streamwriter.Flush();
            streamwriter.Close();
            filestream.Close();
        }

        // Удалить запись
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        // Добавить запись
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.TextLength == 0)
                    throw new FormatException();
                string x1 = textBox1.Text;
                listBox1.Items.Add(x1);
                textBox1.Text = "";
            } catch (FormatException)
            {
                MessageBox.Show("Поле для добавления записи должно быть заполнено", "Ошибка",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        
        // Считать из файла
        private void button5_Click(object sender, EventArgs e)
        {
            i = 0;
            s = 0;
            string stringText;
            string fileName = "file.txt";
            TextReader textreader = new StreamReader(fileName);
            listBox1.Items.Clear();
            while (textreader.Peek() > -1)
            {
                stringText = textreader.ReadLine();
                listBox1.Items.Add(stringText);
            }
            textreader.Close();
        }

        // Сумма очков каждого спортсмена
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string[] fields;
            string stringText;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                stringText = Convert.ToString(listBox1.Items[i]);
                fields = stringText.Split(',');
                sportsmen[i].name = fields[0];
                sportsmen[i].sum_grade = ToInt32(fields[1]) + ToInt32(fields[2]) + ToInt32(fields[3]);
                label1.Text += $"Имя:{sportsmen[i].name}  Ср.балл: {sportsmen[i].sum_grade} \n";
            }
        }

        struct sportsmens
        {
            public string name;
            public double sum_grade;
        }
        sportsmens[] sportsmen = new sportsmens[70];

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button4_Click(sender, e);
                return;
            }
            if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                    return;
                }
                e.Handled = true;
            }
        }
    }
}
