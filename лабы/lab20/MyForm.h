#pragma once
#include <stdlib.h>
#include <ctime>
int n, m, i, j, a[60][60];
namespace lab20 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::GroupBox^ groupBox1;
	protected:

	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::GroupBox^ groupBox2;
	private: System::Windows::Forms::TextBox^ textBox5;
	private: System::Windows::Forms::TextBox^ textBox4;
	private: System::Windows::Forms::TextBox^ textBox3;
	private: System::Windows::Forms::CheckBox^ checkBox3;
	private: System::Windows::Forms::CheckBox^ checkBox2;
	private: System::Windows::Forms::CheckBox^ checkBox1;
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Button^ button3;
	private: System::Windows::Forms::DataGridView^ dataGridView1;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->textBox5 = (gcnew System::Windows::Forms::TextBox());
			this->textBox4 = (gcnew System::Windows::Forms::TextBox());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->checkBox3 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox2 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox1 = (gcnew System::Windows::Forms::CheckBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->groupBox1->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->groupBox2->SuspendLayout();
			this->SuspendLayout();
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->dataGridView1);
			this->groupBox1->Controls->Add(this->label4);
			this->groupBox1->Controls->Add(this->textBox2);
			this->groupBox1->Controls->Add(this->textBox1);
			this->groupBox1->Controls->Add(this->label3);
			this->groupBox1->Controls->Add(this->label2);
			this->groupBox1->Controls->Add(this->label1);
			this->groupBox1->Font = (gcnew System::Drawing::Font(L"Montserrat", 8.999999F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->groupBox1->Location = System::Drawing::Point(25, 12);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(619, 335);
			this->groupBox1->TabIndex = 0;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Ввод данных матрицы";
			// 
			// dataGridView1
			// 
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Location = System::Drawing::Point(12, 149);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->Size = System::Drawing::Size(594, 174);
			this->dataGridView1->TabIndex = 5;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Font = (gcnew System::Drawing::Font(L"Montserrat", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label4->Location = System::Drawing::Point(250, 121);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(131, 21);
			this->label4->TabIndex = 4;
			this->label4->Text = L"Матрица а[n,m]";
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(443, 75);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(100, 22);
			this->textBox2->TabIndex = 3;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(166, 75);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(100, 22);
			this->textBox1->TabIndex = 2;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Montserrat", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label3->Location = System::Drawing::Point(334, 75);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(103, 21);
			this->label3->TabIndex = 1;
			this->label3->Text = L"M-столбцов";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Montserrat", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label2->Location = System::Drawing::Point(90, 75);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(72, 21);
			this->label2->TabIndex = 1;
			this->label2->Text = L"N-строк";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Montserrat SemiBold", 11.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label1->Location = System::Drawing::Point(207, 34);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(216, 21);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Задайте размер матрицы";
			// 
			// groupBox2
			// 
			this->groupBox2->Controls->Add(this->textBox5);
			this->groupBox2->Controls->Add(this->textBox4);
			this->groupBox2->Controls->Add(this->textBox3);
			this->groupBox2->Controls->Add(this->checkBox3);
			this->groupBox2->Controls->Add(this->checkBox2);
			this->groupBox2->Controls->Add(this->checkBox1);
			this->groupBox2->Font = (gcnew System::Drawing::Font(L"Montserrat", 8.999999F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->groupBox2->Location = System::Drawing::Point(25, 353);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Size = System::Drawing::Size(619, 231);
			this->groupBox2->TabIndex = 1;
			this->groupBox2->TabStop = false;
			this->groupBox2->Text = L"Найти";
			// 
			// textBox5
			// 
			this->textBox5->Font = (gcnew System::Drawing::Font(L"Montserrat", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->textBox5->Location = System::Drawing::Point(471, 180);
			this->textBox5->Name = L"textBox5";
			this->textBox5->ReadOnly = true;
			this->textBox5->Size = System::Drawing::Size(100, 26);
			this->textBox5->TabIndex = 3;
			// 
			// textBox4
			// 
			this->textBox4->Font = (gcnew System::Drawing::Font(L"Montserrat", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->textBox4->Location = System::Drawing::Point(471, 105);
			this->textBox4->Name = L"textBox4";
			this->textBox4->ReadOnly = true;
			this->textBox4->Size = System::Drawing::Size(100, 26);
			this->textBox4->TabIndex = 3;
			// 
			// textBox3
			// 
			this->textBox3->Font = (gcnew System::Drawing::Font(L"Montserrat", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->textBox3->Location = System::Drawing::Point(471, 36);
			this->textBox3->Name = L"textBox3";
			this->textBox3->ReadOnly = true;
			this->textBox3->Size = System::Drawing::Size(100, 26);
			this->textBox3->TabIndex = 3;
			// 
			// checkBox3
			// 
			this->checkBox3->AutoSize = true;
			this->checkBox3->Font = (gcnew System::Drawing::Font(L"Montserrat", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->checkBox3->Location = System::Drawing::Point(8, 154);
			this->checkBox3->Name = L"checkBox3";
			this->checkBox3->Size = System::Drawing::Size(414, 67);
			this->checkBox3->TabIndex = 2;
			this->checkBox3->Text = L"В матрице a[5;5] найти произведение количества\r\nчетных чисел 2-ой строки и количе"
				L"ства\r\nотрицательных чисел 4-го столбца";
			this->checkBox3->UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this->checkBox2->AutoSize = true;
			this->checkBox2->Font = (gcnew System::Drawing::Font(L"Montserrat", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->checkBox2->Location = System::Drawing::Point(9, 90);
			this->checkBox2->Name = L"checkBox2";
			this->checkBox2->Size = System::Drawing::Size(340, 46);
			this->checkBox2->TabIndex = 1;
			this->checkBox2->Text = L"Найти количество нечетных элементов,\r\nнаходящихся на побочной диагонали";
			this->checkBox2->UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this->checkBox1->AutoSize = true;
			this->checkBox1->Font = (gcnew System::Drawing::Font(L"Montserrat", 11.25F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->checkBox1->Location = System::Drawing::Point(8, 23);
			this->checkBox1->Name = L"checkBox1";
			this->checkBox1->Size = System::Drawing::Size(362, 46);
			this->checkBox1->TabIndex = 0;
			this->checkBox1->Text = L"Найти количество кратных 3 элементов из\r\nинтервала [-6;8] матрицы a[5;5]";
			this->checkBox1->UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this->button1->Font = (gcnew System::Drawing::Font(L"Montserrat", 9.749999F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->button1->Location = System::Drawing::Point(37, 603);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(147, 62);
			this->button1->TabIndex = 2;
			this->button1->Text = L"Создать таблицу";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// button2
			// 
			this->button2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->button2->Location = System::Drawing::Point(217, 603);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(219, 62);
			this->button2->TabIndex = 2;
			this->button2->Text = L"Перенести данные из таблицу в массив\r\nи решить задание";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// button3
			// 
			this->button3->Font = (gcnew System::Drawing::Font(L"Montserrat", 9.749999F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->button3->Location = System::Drawing::Point(471, 603);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(147, 62);
			this->button3->TabIndex = 2;
			this->button3->Text = L"Выход";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MyForm::button3_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(666, 677);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->groupBox2);
			this->Controls->Add(this->groupBox1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->groupBox2->ResumeLayout(false);
			this->groupBox2->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		srand(time(0));
		if ((textBox1->Text != "") && (textBox2->Text != ""))
		{
			n = Convert::ToInt64(textBox1->Text);
			m = Convert::ToInt64(textBox2->Text);
			dataGridView1->Columns->Clear();
			dataGridView1->RowCount = n;
			dataGridView1->ColumnCount = m;
			for (i = 0; i < n; i++)
				for (j = 0; j < m; j++)
				{
					a[i][j] = 8 - rand() % 15;
					dataGridView1->Rows[i]->Cells[j]->Value = Convert::ToSingle(a[i][j]);				// Присваиваем значения каждой ячейке таблицы
				}
		}
		else
			MessageBox::Show(
				"Заполните пожалуйста данные", "Ошибка",
				MessageBoxButtons::OK,
				MessageBoxIcon::Exclamation);
	}
	private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
		int k,nechet,str,stl;
		if (checkBox1->Checked)
		{
			for (i = 0; i < n; i++)
				for (j = 0; j < m; j++)
					if (a[i][j] % 3 == 0)
						k++;											//Кол-во кратных 3 элементов
			this->textBox3->Text = Convert::ToString(k);
		}
		if (checkBox2->Checked)
		{
			for (i = 0; i < n; i++)
				for (j = 0; j < m; j++)
					if (j == n - 1 - i)
						if (a[i][j] % 2 != 0)
							nechet++;									//Кол-во нечетных элементов на побочной диагонали
			this->textBox4->Text = Convert::ToString(nechet);
		}
		if (checkBox3->Checked)
		{
			for (i = 0; i < n; i++)
				for (j = 0; j < m; j++)
					if (i == 1  && a[i][j] % 2 == 0)
						str++;								// Элементы второй строки
			for (i = 0; i < n; i++)
				for (j = 0; j < m; j++)
					if (j == 3 && a[i][j] < 0)
						stl++;								//Элементы 4-го столбца
			
			this->textBox5->Text = Convert::ToString(stl*str);
		}
	}

private: System::Void button3_Click(System::Object^ sender, System::EventArgs^ e) {
	exit(0);
}
};
}
