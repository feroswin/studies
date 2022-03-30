
namespace lab_19
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonWriteArray = new System.Windows.Forms.Button();
            this.dataGridViewArray = new System.Windows.Forms.DataGridView();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelResSquare = new System.Windows.Forms.Label();
            this.labelResElem = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.checkBoxEvenElem = new System.Windows.Forms.CheckBox();
            this.checkBoxSquare = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonWriteArray);
            this.groupBox1.Controls.Add(this.dataGridViewArray);
            this.groupBox1.Controls.Add(this.textBoxM);
            this.groupBox1.Controls.Add(this.textBoxN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите размерность матрицы";
            // 
            // buttonWriteArray
            // 
            this.buttonWriteArray.Location = new System.Drawing.Point(88, 218);
            this.buttonWriteArray.Name = "buttonWriteArray";
            this.buttonWriteArray.Size = new System.Drawing.Size(140, 31);
            this.buttonWriteArray.TabIndex = 5;
            this.buttonWriteArray.Text = "Заполнить матрицу";
            this.buttonWriteArray.UseVisualStyleBackColor = true;
            this.buttonWriteArray.Click += new System.EventHandler(this.buttonWriteArray_Click);
            // 
            // dataGridViewArray
            // 
            this.dataGridViewArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArray.ColumnHeadersVisible = false;
            this.dataGridViewArray.Location = new System.Drawing.Point(334, 31);
            this.dataGridViewArray.Name = "dataGridViewArray";
            this.dataGridViewArray.RowHeadersVisible = false;
            this.dataGridViewArray.RowTemplate.Height = 25;
            this.dataGridViewArray.Size = new System.Drawing.Size(262, 247);
            this.dataGridViewArray.TabIndex = 4;
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(203, 144);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(100, 25);
            this.textBoxM.TabIndex = 3;
            this.textBoxM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxM_KeyPress);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(203, 72);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 25);
            this.textBoxN.TabIndex = 2;
            this.textBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество строк M:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество столбцов N:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelResSquare);
            this.groupBox2.Controls.Add(this.labelResElem);
            this.groupBox2.Controls.Add(this.buttonCalculate);
            this.groupBox2.Controls.Add(this.checkBoxEvenElem);
            this.groupBox2.Controls.Add(this.checkBoxSquare);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 212);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найти";
            // 
            // labelResSquare
            // 
            this.labelResSquare.AutoSize = true;
            this.labelResSquare.Location = new System.Drawing.Point(386, 48);
            this.labelResSquare.Name = "labelResSquare";
            this.labelResSquare.Size = new System.Drawing.Size(0, 17);
            this.labelResSquare.TabIndex = 4;
            // 
            // labelResElem
            // 
            this.labelResElem.AutoSize = true;
            this.labelResElem.Location = new System.Drawing.Point(386, 124);
            this.labelResElem.Name = "labelResElem";
            this.labelResElem.Size = new System.Drawing.Size(0, 17);
            this.labelResElem.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(253, 165);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(94, 27);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // checkBoxEvenElem
            // 
            this.checkBoxEvenElem.AutoSize = true;
            this.checkBoxEvenElem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxEvenElem.Location = new System.Drawing.Point(24, 98);
            this.checkBoxEvenElem.Name = "checkBoxEvenElem";
            this.checkBoxEvenElem.Size = new System.Drawing.Size(280, 42);
            this.checkBoxEvenElem.TabIndex = 1;
            this.checkBoxEvenElem.Text = "Количество четных элементов, \r\nнаходящихся на побочной диагонали";
            this.checkBoxEvenElem.UseVisualStyleBackColor = true;
            // 
            // checkBoxSquare
            // 
            this.checkBoxSquare.AutoSize = true;
            this.checkBoxSquare.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSquare.Location = new System.Drawing.Point(24, 42);
            this.checkBoxSquare.Name = "checkBoxSquare";
            this.checkBoxSquare.Size = new System.Drawing.Size(257, 23);
            this.checkBoxSquare.TabIndex = 0;
            this.checkBoxSquare.Text = "Квадрат максимального элемента";
            this.checkBoxSquare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArray)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonWriteArray;
        private System.Windows.Forms.DataGridView dataGridViewArray;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelResSquare;
        private System.Windows.Forms.Label labelResElem;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.CheckBox checkBoxEvenElem;
        private System.Windows.Forms.CheckBox checkBoxSquare;
    }
}

