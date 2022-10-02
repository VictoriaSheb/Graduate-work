#pragma once

namespace FormsOfRepresentation {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для FormNoise
	/// </summary>
	public ref class FormNoise : public System::Windows::Forms::Form
	{
	public:
		FormNoise(void)
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
		~FormNoise()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ lbSizeII;
	protected:
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ lbSizeTI;
	private: System::Windows::Forms::Button^ btnClose;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TrackBar^ trackBar1;
	private: System::Windows::Forms::ComboBox^ cbNoise;
	private: System::Windows::Forms::Label^ lbSNR;
	private: System::Windows::Forms::Button^ btnOk;
	private: System::Windows::Forms::GroupBox^ groupBox1;
	private: System::Windows::Forms::PictureBox^ pbTI;

	protected:












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
			this->lbSizeII = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->lbSizeTI = (gcnew System::Windows::Forms::Label());
			this->btnClose = (gcnew System::Windows::Forms::Button());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->trackBar1 = (gcnew System::Windows::Forms::TrackBar());
			this->cbNoise = (gcnew System::Windows::Forms::ComboBox());
			this->lbSNR = (gcnew System::Windows::Forms::Label());
			this->btnOk = (gcnew System::Windows::Forms::Button());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->pbTI = (gcnew System::Windows::Forms::PictureBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBar1))->BeginInit();
			this->groupBox1->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbTI))->BeginInit();
			this->SuspendLayout();
			// 
			// lbSizeII
			// 
			this->lbSizeII->AutoSize = true;
			this->lbSizeII->Location = System::Drawing::Point(107, 489);
			this->lbSizeII->Name = L"lbSizeII";
			this->lbSizeII->Size = System::Drawing::Size(0, 17);
			this->lbSizeII->TabIndex = 19;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->label3->Location = System::Drawing::Point(78, 566);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(46, 19);
			this->label3->TabIndex = 28;
			this->label3->Text = L"ОСШ:";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(78, 14);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(76, 17);
			this->label1->TabIndex = 26;
			this->label1->Text = L"Вид шума:";
			// 
			// lbSizeTI
			// 
			this->lbSizeTI->AutoSize = true;
			this->lbSizeTI->Location = System::Drawing::Point(107, 459);
			this->lbSizeTI->Name = L"lbSizeTI";
			this->lbSizeTI->Size = System::Drawing::Size(0, 17);
			this->lbSizeTI->TabIndex = 18;
			// 
			// btnClose
			// 
			this->btnClose->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->btnClose->Location = System::Drawing::Point(689, 589);
			this->btnClose->Name = L"btnClose";
			this->btnClose->Size = System::Drawing::Size(103, 36);
			this->btnClose->TabIndex = 25;
			this->btnClose->Text = L"Выйти";
			this->btnClose->UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->label2->Location = System::Drawing::Point(78, 527);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(115, 19);
			this->label2->TabIndex = 27;
			this->label2->Text = L"Зашумлённость:";
			// 
			// trackBar1
			// 
			this->trackBar1->Location = System::Drawing::Point(210, 527);
			this->trackBar1->Name = L"trackBar1";
			this->trackBar1->Size = System::Drawing::Size(515, 56);
			this->trackBar1->TabIndex = 22;
			// 
			// cbNoise
			// 
			this->cbNoise->FormattingEnabled = true;
			this->cbNoise->Location = System::Drawing::Point(171, 11);
			this->cbNoise->Name = L"cbNoise";
			this->cbNoise->Size = System::Drawing::Size(230, 24);
			this->cbNoise->TabIndex = 21;
			// 
			// lbSNR
			// 
			this->lbSNR->AutoSize = true;
			this->lbSNR->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbSNR->Location = System::Drawing::Point(131, 566);
			this->lbSNR->Name = L"lbSNR";
			this->lbSNR->Size = System::Drawing::Size(45, 19);
			this->lbSNR->TabIndex = 24;
			this->lbSNR->Text = L"label1";
			// 
			// btnOk
			// 
			this->btnOk->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->btnOk->Location = System::Drawing::Point(557, 589);
			this->btnOk->Name = L"btnOk";
			this->btnOk->Size = System::Drawing::Size(103, 36);
			this->btnOk->TabIndex = 23;
			this->btnOk->Text = L"Выбрать";
			this->btnOk->UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this->groupBox1->BackColor = System::Drawing::Color::LightGray;
			this->groupBox1->Controls->Add(this->pbTI);
			this->groupBox1->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F, System::Drawing::FontStyle::Bold));
			this->groupBox1->Location = System::Drawing::Point(64, 53);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(681, 453);
			this->groupBox1->TabIndex = 20;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Текущее изображение";
			// 
			// pbTI
			// 
			this->pbTI->ErrorImage = nullptr;
			this->pbTI->Location = System::Drawing::Point(64, 33);
			this->pbTI->Name = L"pbTI";
			this->pbTI->Size = System::Drawing::Size(547, 401);
			this->pbTI->SizeMode = System::Windows::Forms::PictureBoxSizeMode::AutoSize;
			this->pbTI->TabIndex = 1;
			this->pbTI->TabStop = false;
			// 
			// FormNoise
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::Color::Silver;
			this->ClientSize = System::Drawing::Size(829, 637);
			this->Controls->Add(this->lbSizeII);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->lbSizeTI);
			this->Controls->Add(this->btnClose);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->trackBar1);
			this->Controls->Add(this->cbNoise);
			this->Controls->Add(this->lbSNR);
			this->Controls->Add(this->btnOk);
			this->Controls->Add(this->groupBox1);
			this->Name = L"FormNoise";
			this->Text = L"FormNoise";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->trackBar1))->EndInit();
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbTI))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

};
}
