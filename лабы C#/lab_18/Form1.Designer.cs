
namespace lab_18
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCreateArray = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.dataGridViewArrayC = new System.Windows.Forms.DataGridView();
            this.dataGridViewArrayM = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReWrite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размерность\r\nисходного массива";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(214, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonCreateArray
            // 
            this.buttonCreateArray.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateArray.Location = new System.Drawing.Point(348, 45);
            this.buttonCreateArray.Name = "buttonCreateArray";
            this.buttonCreateArray.Size = new System.Drawing.Size(86, 27);
            this.buttonCreateArray.TabIndex = 2;
            this.buttonCreateArray.Text = "Создать";
            this.buttonCreateArray.UseVisualStyleBackColor = true;
            this.buttonCreateArray.Click += new System.EventHandler(this.buttonCreateArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Исходный массив";
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewArray.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.ColumnHeadersVisible = false;
            this.dataGridViewArray.EnableHeadersVisualStyles = false;
            this.dataGridViewArray.Location = new System.Drawing.Point(33, 130);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.ReadOnly = true;
            this.dataGridViewArray.RowHeadersVisible = false;
            this.dataGridViewArray.RowHeadersWidth = 20;
            this.dataGridViewArray.Size = new System.Drawing.Size(429, 40);
            this.dataGridViewArray.TabIndex = 5;
            // 
            // dataGridViewArrayC
            // 
            this.dataGridViewArrayC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewArrayC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewArrayC.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewArrayC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrayC.ColumnHeadersVisible = false;
            this.dataGridViewArrayC.Location = new System.Drawing.Point(33, 211);
            this.dataGridViewArrayC.Name = "dataGridViewArrayC";
            this.dataGridViewArrayC.ReadOnly = true;
            this.dataGridViewArrayC.RowHeadersVisible = false;
            this.dataGridViewArrayC.Size = new System.Drawing.Size(429, 40);
            this.dataGridViewArrayC.TabIndex = 6;
            // 
            // dataGridViewArrayM
            // 
            this.dataGridViewArrayM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewArrayM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewArrayM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrayM.ColumnHeadersVisible = false;
            this.dataGridViewArrayM.Location = new System.Drawing.Point(33, 298);
            this.dataGridViewArrayM.Name = "dataGridViewArrayM";
            this.dataGridViewArrayM.ReadOnly = true;
            this.dataGridViewArrayM.RowHeadersVisible = false;
            this.dataGridViewArrayM.Size = new System.Drawing.Size(429, 40);
            this.dataGridViewArrayM.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Массив С (с положительными числами)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Массив M (с отрицательными чсилами)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonReWrite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 323);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // buttonReWrite
            // 
            this.buttonReWrite.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReWrite.Location = new System.Drawing.Point(149, 268);
            this.buttonReWrite.Name = "buttonReWrite";
            this.buttonReWrite.Size = new System.Drawing.Size(169, 29);
            this.buttonReWrite.TabIndex = 11;
            this.buttonReWrite.Text = "Переписать элементы";
            this.buttonReWrite.UseVisualStyleBackColor = true;
            this.buttonReWrite.Click += new System.EventHandler(this.buttonReWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 429);
            this.Controls.Add(this.dataGridViewArrayM);
            this.Controls.Add(this.dataGridViewArrayC);
            this.Controls.Add(this.dataGridViewArray);
            this.Controls.Add(this.buttonCreateArray);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 18";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCreateArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.DataGridView dataGridViewArrayC;
        private System.Windows.Forms.DataGridView dataGridViewArrayM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReWrite;
    }
}

