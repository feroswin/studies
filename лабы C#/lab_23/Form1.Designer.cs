
namespace lab_23
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_Enterprises = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеСхDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРегистрацииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видСобственностиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоРаботниковDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.основнойВидПродукцииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.являетсяПередовымВОсвоенииНовойТехнологииDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.прибыльDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сведенияОбОрганизацииBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database61DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database61DataSet = new lab_23.Database61DataSet();
            this.информацияОСотрудникахBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информация_о_сотрудникахTableAdapter = new lab_23.Database61DataSetTableAdapters.Информация_о_сотрудникахTableAdapter();
            this.dataGridView_Employees = new System.Windows.Forms.DataGridView();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПредприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домашнийТелефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияОСотрудникахBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сведенияОбОрганизацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сведения_об_организацииTableAdapter = new lab_23.Database61DataSetTableAdapters.Сведения_об_организацииTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sort_enterprises = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Enterprises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведенияОбОрганизацииBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database61DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database61DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведенияОбОрганизацииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Enterprises
            // 
            this.dataGridView_Enterprises.AutoGenerateColumns = false;
            this.dataGridView_Enterprises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Enterprises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.наименованиеСхDataGridViewTextBoxColumn1,
            this.датаРегистрацииDataGridViewTextBoxColumn1,
            this.видСобственностиDataGridViewTextBoxColumn1,
            this.числоРаботниковDataGridViewTextBoxColumn1,
            this.основнойВидПродукцииDataGridViewTextBoxColumn1,
            this.являетсяПередовымВОсвоенииНовойТехнологииDataGridViewCheckBoxColumn1,
            this.прибыльDataGridViewTextBoxColumn1,
            this.примечаниеDataGridViewTextBoxColumn1});
            this.dataGridView_Enterprises.DataSource = this.сведенияОбОрганизацииBindingSource1;
            this.dataGridView_Enterprises.Location = new System.Drawing.Point(25, 68);
            this.dataGridView_Enterprises.Name = "dataGridView_Enterprises";
            this.dataGridView_Enterprises.Size = new System.Drawing.Size(633, 226);
            this.dataGridView_Enterprises.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            // 
            // наименованиеСхDataGridViewTextBoxColumn1
            // 
            this.наименованиеСхDataGridViewTextBoxColumn1.DataPropertyName = "Наименование с/х";
            this.наименованиеСхDataGridViewTextBoxColumn1.HeaderText = "Наименование с/х";
            this.наименованиеСхDataGridViewTextBoxColumn1.Name = "наименованиеСхDataGridViewTextBoxColumn1";
            // 
            // датаРегистрацииDataGridViewTextBoxColumn1
            // 
            this.датаРегистрацииDataGridViewTextBoxColumn1.DataPropertyName = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn1.HeaderText = "Дата регистрации";
            this.датаРегистрацииDataGridViewTextBoxColumn1.Name = "датаРегистрацииDataGridViewTextBoxColumn1";
            // 
            // видСобственностиDataGridViewTextBoxColumn1
            // 
            this.видСобственностиDataGridViewTextBoxColumn1.DataPropertyName = "Вид собственности";
            this.видСобственностиDataGridViewTextBoxColumn1.HeaderText = "Вид собственности";
            this.видСобственностиDataGridViewTextBoxColumn1.Name = "видСобственностиDataGridViewTextBoxColumn1";
            // 
            // числоРаботниковDataGridViewTextBoxColumn1
            // 
            this.числоРаботниковDataGridViewTextBoxColumn1.DataPropertyName = "Число работников";
            this.числоРаботниковDataGridViewTextBoxColumn1.HeaderText = "Число работников";
            this.числоРаботниковDataGridViewTextBoxColumn1.Name = "числоРаботниковDataGridViewTextBoxColumn1";
            // 
            // основнойВидПродукцииDataGridViewTextBoxColumn1
            // 
            this.основнойВидПродукцииDataGridViewTextBoxColumn1.DataPropertyName = "Основной вид продукции";
            this.основнойВидПродукцииDataGridViewTextBoxColumn1.HeaderText = "Основной вид продукции";
            this.основнойВидПродукцииDataGridViewTextBoxColumn1.Name = "основнойВидПродукцииDataGridViewTextBoxColumn1";
            // 
            // являетсяПередовымВОсвоенииНовойТехнологииDataGridViewCheckBoxColumn1
            // 
            this.являетсяПередовымВОсвоенииНовойТехнологииDataGridViewCheckBoxColumn1.DataPropertyName = "Является передовым в освоении новой технологии";
            this.являетсяПередовымВОсвоенииНовойТехнологииDataGridViewCheckBoxColumn1.HeaderText = "Является передовым в освоении новой технологии";
            this.являетсяПередовымВОсвоенииНовойТехнологииDataGridViewCheckBoxColumn1.Name = "являетсяПередовымВОсвоенииНовойТехнологииDataGridViewCheckBoxColumn1";
            // 
            // прибыльDataGridViewTextBoxColumn1
            // 
            this.прибыльDataGridViewTextBoxColumn1.DataPropertyName = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn1.HeaderText = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn1.Name = "прибыльDataGridViewTextBoxColumn1";
            // 
            // примечаниеDataGridViewTextBoxColumn1
            // 
            this.примечаниеDataGridViewTextBoxColumn1.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn1.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn1.Name = "примечаниеDataGridViewTextBoxColumn1";
            // 
            // сведенияОбОрганизацииBindingSource1
            // 
            this.сведенияОбОрганизацииBindingSource1.DataMember = "Сведения об организации";
            this.сведенияОбОрганизацииBindingSource1.DataSource = this.database61DataSetBindingSource;
            // 
            // database61DataSetBindingSource
            // 
            this.database61DataSetBindingSource.DataSource = this.database61DataSet;
            this.database61DataSetBindingSource.Position = 0;
            // 
            // database61DataSet
            // 
            this.database61DataSet.DataSetName = "Database61DataSet";
            this.database61DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // информацияОСотрудникахBindingSource
            // 
            this.информацияОСотрудникахBindingSource.DataMember = "Информация о сотрудниках";
            this.информацияОСотрудникахBindingSource.DataSource = this.database61DataSet;
            // 
            // информация_о_сотрудникахTableAdapter
            // 
            this.информация_о_сотрудникахTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_Employees
            // 
            this.dataGridView_Employees.AutoGenerateColumns = false;
            this.dataGridView_Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.фИОСотрудникаDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.кодПредприятияDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.домашнийТелефонDataGridViewTextBoxColumn,
            this.зарплатаDataGridViewTextBoxColumn,
            this.стажРаботыDataGridViewTextBoxColumn});
            this.dataGridView_Employees.DataSource = this.информацияОСотрудникахBindingSource1;
            this.dataGridView_Employees.Location = new System.Drawing.Point(25, 364);
            this.dataGridView_Employees.Name = "dataGridView_Employees";
            this.dataGridView_Employees.Size = new System.Drawing.Size(632, 223);
            this.dataGridView_Employees.TabIndex = 1;
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            // 
            // фИОСотрудникаDataGridViewTextBoxColumn
            // 
            this.фИОСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ФИО сотрудника";
            this.фИОСотрудникаDataGridViewTextBoxColumn.HeaderText = "ФИО сотрудника";
            this.фИОСотрудникаDataGridViewTextBoxColumn.Name = "фИОСотрудникаDataGridViewTextBoxColumn";
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // кодПредприятияDataGridViewTextBoxColumn
            // 
            this.кодПредприятияDataGridViewTextBoxColumn.DataPropertyName = "Код предприятия";
            this.кодПредприятияDataGridViewTextBoxColumn.HeaderText = "Код предприятия";
            this.кодПредприятияDataGridViewTextBoxColumn.Name = "кодПредприятияDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // домашнийТелефонDataGridViewTextBoxColumn
            // 
            this.домашнийТелефонDataGridViewTextBoxColumn.DataPropertyName = "Домашний телефон";
            this.домашнийТелефонDataGridViewTextBoxColumn.HeaderText = "Домашний телефон";
            this.домашнийТелефонDataGridViewTextBoxColumn.Name = "домашнийТелефонDataGridViewTextBoxColumn";
            // 
            // зарплатаDataGridViewTextBoxColumn
            // 
            this.зарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.Name = "зарплатаDataGridViewTextBoxColumn";
            // 
            // стажРаботыDataGridViewTextBoxColumn
            // 
            this.стажРаботыDataGridViewTextBoxColumn.DataPropertyName = "Стаж работы";
            this.стажРаботыDataGridViewTextBoxColumn.HeaderText = "Стаж работы";
            this.стажРаботыDataGridViewTextBoxColumn.Name = "стажРаботыDataGridViewTextBoxColumn";
            // 
            // информацияОСотрудникахBindingSource1
            // 
            this.информацияОСотрудникахBindingSource1.DataMember = "Информация о сотрудниках";
            this.информацияОСотрудникахBindingSource1.DataSource = this.database61DataSetBindingSource;
            // 
            // сведенияОбОрганизацииBindingSource
            // 
            this.сведенияОбОрганизацииBindingSource.DataMember = "Сведения об организации";
            this.сведенияОбОрганизацииBindingSource.DataSource = this.database61DataSetBindingSource;
            // 
            // сведения_об_организацииTableAdapter
            // 
            this.сведения_об_организацииTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сведения об предприятиях с/х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сведения о сотрудниках организаций";
            // 
            // Sort_enterprises
            // 
            this.Sort_enterprises.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_enterprises.Location = new System.Drawing.Point(742, 251);
            this.Sort_enterprises.Name = "Sort_enterprises";
            this.Sort_enterprises.Size = new System.Drawing.Size(129, 43);
            this.Sort_enterprises.TabIndex = 4;
            this.Sort_enterprises.Text = "Сортировать предприятия";
            this.Sort_enterprises.UseVisualStyleBackColor = true;
            this.Sort_enterprises.Click += new System.EventHandler(this.Sort_enterprises_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(742, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBoxCharacter_Search_Enterprises_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(742, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(742, 420);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(742, 500);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(742, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сортировать сотрудников";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(751, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Точный поиск";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(751, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Точный поиск";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(727, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Поиск по символам";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(727, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Поиск по символам";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 622);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sort_enterprises);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Employees);
            this.Controls.Add(this.dataGridView_Enterprises);
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 23";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Enterprises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведенияОбОрганизацииBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database61DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database61DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияОСотрудникахBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведенияОбОрганизацииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Enterprises;
        private System.Windows.Forms.BindingSource database61DataSetBindingSource;
        private Database61DataSet database61DataSet;
        private System.Windows.Forms.BindingSource информацияОСотрудникахBindingSource;
        private Database61DataSetTableAdapters.Информация_о_сотрудникахTableAdapter информация_о_сотрудникахTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_Employees;
        private System.Windows.Forms.BindingSource сведенияОбОрганизацииBindingSource;
        private Database61DataSetTableAdapters.Сведения_об_организацииTableAdapter сведения_об_организацииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСхDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРегистрацииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn видСобственностиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоРаботниковDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn основнойВидПродукцииDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn являетсяПередовымВОсвоенииНовойТехнологииDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn прибыльDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource сведенияОбОрганизацииBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПредприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домашнийТелефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource информацияОСотрудникахBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sort_enterprises;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

