#pragma once

namespace lab17 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// —водка дл€ MyForm
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
		/// ќсвободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::PictureBox^ pictureBox1;
	protected:


	protected:

	private:
		/// <summary>
		/// ќб€зательна€ переменна€ конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// “ребуемый метод дл€ поддержки конструктора Ч не измен€йте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// pictureBox1
			// 
			this->pictureBox1->Location = System::Drawing::Point(12, 12);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(1205, 850);
			this->pictureBox1->TabIndex = 0;
			this->pictureBox1->TabStop = false;
			this->pictureBox1->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &MyForm::pictureBox1_Paint);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1229, 874);
			this->Controls->Add(this->pictureBox1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void pictureBox1_Paint(System::Object^ sender, System::Windows::Forms::PaintEventArgs^ e) {
		int kletka = 30;
		Pen^ aPen = gcnew Pen(Color::Black, 2);
		Pen^ cPen = gcnew Pen(Color::Black, 2);
		cPen->DashStyle = System::Drawing::Drawing2D::DashStyle::Dash;
		array<Point>^ s;
		s = gcnew array<Point>(4);
		s[0].X = kletka * 22;
		s[0].Y = kletka * 2;
		s[1].X = kletka * 21;
		s[1].Y = kletka * 11;
		s[2].X = kletka * 15;
		s[2].Y = kletka * 15;
		s[3].X = kletka * 22;
		s[3].Y = kletka * 2;
		e->Graphics->FillPolygon(Brushes::Gold, s);
		e->Graphics->DrawLines(aPen, s);
		array<Point>^ p;
		p = gcnew array<Point>(12);
		p[0].X = kletka * 15;
		p[0].Y = kletka * 15;
		p[1].X = kletka * 21;
		p[1].Y = kletka * 17;
		p[2].X = kletka * 28;
		p[2].Y = kletka * 10;
		p[3].X = kletka * 28;
		p[3].Y = kletka * 4;
		p[4].X = kletka * 22;
		p[4].Y = kletka * 2;
		p[5].X = kletka * 15;
		p[5].Y = kletka * 9;
		p[6].X = kletka * 15;
		p[6].Y = kletka * 15;
		p[7].X = kletka * 15;
		p[7].Y = kletka * 9;
		p[8].X = kletka * 21;
		p[8].Y = kletka * 11;
		p[9].X = kletka * 21;
		p[9].Y = kletka * 17;
		p[10].X = kletka * 21;
		p[10].Y = kletka * 11;
		p[11].X = kletka * 28;
		p[11].Y = kletka * 4;
		e->Graphics->DrawLines(aPen, p);

		array<Point>^ p1;
		p1 = gcnew array<Point>(6);
		p1[0].X = kletka * 15;
		p1[0].Y = kletka * 15;
		p1[1].X = kletka * 22;
		p1[1].Y = kletka * 8;
		p1[2].X = kletka * 28;
		p1[2].Y = kletka * 10;
		p1[3].X = kletka * 28;
		p1[3].Y = kletka * 4;
		p1[4].X = kletka * 22;
		p1[4].Y = kletka * 2;
		p1[5].X = kletka * 22;
		p1[5].Y = kletka * 8;
		e->Graphics->DrawLines(cPen, p1);
	}
	};
}
