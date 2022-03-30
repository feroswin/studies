
namespace lab_17
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
            this.checkBoxMM = new System.Windows.Forms.CheckBox();
            this.checkBoxSM = new System.Windows.Forms.CheckBox();
            this.checkBoxMetr = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMM = new System.Windows.Forms.TextBox();
            this.textBoxSM = new System.Windows.Forms.TextBox();
            this.textBoxMetr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxMM
            // 
            this.checkBoxMM.AutoSize = true;
            this.checkBoxMM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMM.Location = new System.Drawing.Point(27, 106);
            this.checkBoxMM.Name = "checkBoxMM";
            this.checkBoxMM.Size = new System.Drawing.Size(122, 23);
            this.checkBoxMM.TabIndex = 0;
            this.checkBoxMM.Text = "Миллиметрах";
            this.checkBoxMM.UseVisualStyleBackColor = true;
            this.checkBoxMM.CheckedChanged += new System.EventHandler(this.checkBoxMM_CheckedChanged);
            // 
            // checkBoxSM
            // 
            this.checkBoxSM.AutoSize = true;
            this.checkBoxSM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSM.Location = new System.Drawing.Point(27, 146);
            this.checkBoxSM.Name = "checkBoxSM";
            this.checkBoxSM.Size = new System.Drawing.Size(210, 23);
            this.checkBoxSM.TabIndex = 1;
            this.checkBoxSM.Text = "Сантиметрах (1 см - 10мм)";
            this.checkBoxSM.UseVisualStyleBackColor = true;
            this.checkBoxSM.CheckedChanged += new System.EventHandler(this.checkBoxSM_CheckedChanged);
            // 
            // checkBoxMetr
            // 
            this.checkBoxMetr.AutoSize = true;
            this.checkBoxMetr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMetr.Location = new System.Drawing.Point(27, 185);
            this.checkBoxMetr.Name = "checkBoxMetr";
            this.checkBoxMetr.Size = new System.Drawing.Size(176, 23);
            this.checkBoxMetr.TabIndex = 2;
            this.checkBoxMetr.Text = "Метрах (1м - 1000мм)";
            this.checkBoxMetr.UseVisualStyleBackColor = true;
            this.checkBoxMetr.CheckedChanged += new System.EventHandler(this.checkBoxMetr_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите расстояние в:";
            // 
            // textBoxMM
            // 
            this.textBoxMM.Location = new System.Drawing.Point(278, 105);
            this.textBoxMM.Name = "textBoxMM";
            this.textBoxMM.Size = new System.Drawing.Size(100, 23);
            this.textBoxMM.TabIndex = 4;
            this.textBoxMM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMM_KeyPress);
            // 
            // textBoxSM
            // 
            this.textBoxSM.Location = new System.Drawing.Point(278, 147);
            this.textBoxSM.Name = "textBoxSM";
            this.textBoxSM.Size = new System.Drawing.Size(100, 23);
            this.textBoxSM.TabIndex = 5;
            this.textBoxSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSM_KeyPress);
            // 
            // textBoxMetr
            // 
            this.textBoxMetr.Location = new System.Drawing.Point(278, 186);
            this.textBoxMetr.Name = "textBoxMetr";
            this.textBoxMetr.Size = new System.Drawing.Size(100, 23);
            this.textBoxMetr.TabIndex = 6;
            this.textBoxMetr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMetr_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(127, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Перевести в миллиметры";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вычисление расстояния\r\n в миллиметрах";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Расстояние в миллиметрах равно";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(266, 251);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 19);
            this.labelResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 367);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMetr);
            this.Controls.Add(this.textBoxSM);
            this.Controls.Add(this.textBoxMM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxMetr);
            this.Controls.Add(this.checkBoxSM);
            this.Controls.Add(this.checkBoxMM);
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMM;
        private System.Windows.Forms.CheckBox checkBoxSM;
        private System.Windows.Forms.CheckBox checkBoxMetr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMM;
        private System.Windows.Forms.TextBox textBoxSM;
        private System.Windows.Forms.TextBox textBoxMetr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResult;
    }
}

