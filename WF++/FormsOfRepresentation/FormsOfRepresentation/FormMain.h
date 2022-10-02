#pragma once
#include "FormNoise.h";
#include <windows.h>
#include <iostream>
#include "FMainManager.h"
#include "CriterionFunction.h"
#include "ImageCombiner.h"
#include <msclr\marshal_cppstd.h>
#include "TotallyOverkill.h"
#include "Multistart.h"
#include "Clipping.h"
//#include "Constructions.h"

namespace FormsOfRepresentation {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для FormMain
	/// </summary>
	public ref class FormMain : public System::Windows::Forms::Form
	{
	public:
		FormMain(void)
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
		~FormMain()
		{
			if (components)
			{
				delete components;
			}
		}

	public:
	private: System::Windows::Forms::OpenFileDialog^ openFileDialog1;
	private: System::Windows::Forms::TabPage^ tbpView;
	private: System::Windows::Forms::GroupBox^ gbTypeOfCalculator;
	private: System::Windows::Forms::RadioButton^ rbSingle;

	private: System::Windows::Forms::RadioButton^ rbCPU;
	private: System::Windows::Forms::RadioButton^ rbGPU;

	private: System::Windows::Forms::Panel^ panel3;
	private: System::Windows::Forms::Button^ btnFind;
	private: System::Windows::Forms::TextBox^ tbY;
	private: System::Windows::Forms::Label^ label16;
	private: System::Windows::Forms::TextBox^ tbX;
	private: System::Windows::Forms::Label^ label15;
	private: System::Windows::Forms::Panel^ panel2;
	private: System::Windows::Forms::GroupBox^ gbAll;
	private: System::Windows::Forms::Label^ lbCFAll;
	private: System::Windows::Forms::Panel^ panel4;
	private: System::Windows::Forms::Panel^ pnColorAll;
	private: System::Windows::Forms::Label^ label13;
	private: System::Windows::Forms::Label^ lbResultAll;
	private: System::Windows::Forms::Button^ btnAll;
	private: System::Windows::Forms::Label^ lbTimeAll;
	private: System::Windows::Forms::GroupBox^ gbMultistart;
	private: System::Windows::Forms::Label^ lbCFMulti;
	private: System::Windows::Forms::Panel^ panel6;
	private: System::Windows::Forms::Panel^ pnColorMulti;
	private: System::Windows::Forms::Label^ label14;
	private: System::Windows::Forms::GroupBox^ groupBox4;
	private: System::Windows::Forms::Button^ btnDetals;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ tbCountPoints;
	private: System::Windows::Forms::Label^ lbResultMulti;
	private: System::Windows::Forms::Button^ btnMulti;
	private: System::Windows::Forms::Label^ lbTimeMulty;
	private: System::Windows::Forms::DataGridView^ dgvCriterial;
	private: System::Windows::Forms::PictureBox^ pbProcess;
	private: System::Windows::Forms::TabPage^ tbpMain;
	private: System::Windows::Forms::Panel^ panel1;
	private: System::Windows::Forms::GroupBox^ groupBox3;
	private: System::Windows::Forms::Label^ lbFormatII;
	private: System::Windows::Forms::Label^ lbIIFormat;

	public: System::Windows::Forms::Label^ lbSNR;
	private:
	private: System::Windows::Forms::Label^ label10;
	public:
	public: System::Windows::Forms::Label^ lbNoise;
	private:
	private: System::Windows::Forms::Label^ label7;
	public:
	private: System::Windows::Forms::Label^ lbFormatTI;
	private: System::Windows::Forms::Label^ lbTIFormat;

	private: System::Windows::Forms::Label^ lbSizeII;
	private: System::Windows::Forms::Label^ lbSizeTI;
	private: System::Windows::Forms::Label^ lbIISize;
	private: System::Windows::Forms::Label^ lbTISize;



	private: System::Windows::Forms::GroupBox^ groupBox2;
	private: System::Windows::Forms::PictureBox^ pbII;
	private: System::Windows::Forms::GroupBox^ groupBox1;
	public: System::Windows::Forms::PictureBox^ pbTI;
	private:
	private: System::Windows::Forms::MenuStrip^ menuStrip1;
	public:
	private: System::Windows::Forms::ToolStripMenuItem^ изображениеToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ tstrmChageTI;
	private: System::Windows::Forms::ToolStripMenuItem^ tstrmChageII;
	private: System::Windows::Forms::ToolStripSeparator^ toolStripSeparator1;
	private: System::Windows::Forms::ToolStripMenuItem^ tstrmClose;
	private: System::Windows::Forms::ToolStripMenuItem^ шумToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ tstrmAddNoise;
	private: System::Windows::Forms::ToolStripMenuItem^ tstrmRemoveNoise;
	private: System::Windows::Forms::TabControl^ tbpAll;
	private: System::Windows::Forms::ColorDialog^ colorDialog1;
	private: System::Windows::Forms::UserControl^ clipping;
	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->openFileDialog1 = (gcnew System::Windows::Forms::OpenFileDialog());
			this->tbpView = (gcnew System::Windows::Forms::TabPage());
			this->gbTypeOfCalculator = (gcnew System::Windows::Forms::GroupBox());
			this->rbSingle = (gcnew System::Windows::Forms::RadioButton());
			this->rbCPU = (gcnew System::Windows::Forms::RadioButton());
			this->rbGPU = (gcnew System::Windows::Forms::RadioButton());
			this->panel3 = (gcnew System::Windows::Forms::Panel());
			this->btnFind = (gcnew System::Windows::Forms::Button());
			this->tbY = (gcnew System::Windows::Forms::TextBox());
			this->label16 = (gcnew System::Windows::Forms::Label());
			this->tbX = (gcnew System::Windows::Forms::TextBox());
			this->label15 = (gcnew System::Windows::Forms::Label());
			this->panel2 = (gcnew System::Windows::Forms::Panel());
			this->gbAll = (gcnew System::Windows::Forms::GroupBox());
			this->lbCFAll = (gcnew System::Windows::Forms::Label());
			this->panel4 = (gcnew System::Windows::Forms::Panel());
			this->pnColorAll = (gcnew System::Windows::Forms::Panel());
			this->label13 = (gcnew System::Windows::Forms::Label());
			this->lbResultAll = (gcnew System::Windows::Forms::Label());
			this->btnAll = (gcnew System::Windows::Forms::Button());
			this->lbTimeAll = (gcnew System::Windows::Forms::Label());
			this->gbMultistart = (gcnew System::Windows::Forms::GroupBox());
			this->lbCFMulti = (gcnew System::Windows::Forms::Label());
			this->panel6 = (gcnew System::Windows::Forms::Panel());
			this->pnColorMulti = (gcnew System::Windows::Forms::Panel());
			this->label14 = (gcnew System::Windows::Forms::Label());
			this->groupBox4 = (gcnew System::Windows::Forms::GroupBox());
			this->btnDetals = (gcnew System::Windows::Forms::Button());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->tbCountPoints = (gcnew System::Windows::Forms::TextBox());
			this->lbResultMulti = (gcnew System::Windows::Forms::Label());
			this->btnMulti = (gcnew System::Windows::Forms::Button());
			this->lbTimeMulty = (gcnew System::Windows::Forms::Label());
			this->dgvCriterial = (gcnew System::Windows::Forms::DataGridView());
			this->pbProcess = (gcnew System::Windows::Forms::PictureBox());
			this->tbpMain = (gcnew System::Windows::Forms::TabPage());
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->groupBox3 = (gcnew System::Windows::Forms::GroupBox());
			this->lbFormatII = (gcnew System::Windows::Forms::Label());
			this->lbIIFormat = (gcnew System::Windows::Forms::Label());
			this->lbSNR = (gcnew System::Windows::Forms::Label());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->lbNoise = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->lbFormatTI = (gcnew System::Windows::Forms::Label());
			this->lbTIFormat = (gcnew System::Windows::Forms::Label());
			this->lbSizeII = (gcnew System::Windows::Forms::Label());
			this->lbSizeTI = (gcnew System::Windows::Forms::Label());
			this->lbIISize = (gcnew System::Windows::Forms::Label());
			this->lbTISize = (gcnew System::Windows::Forms::Label());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->pbII = (gcnew System::Windows::Forms::PictureBox());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->pbTI = (gcnew System::Windows::Forms::PictureBox());
			this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
			this->изображениеToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->tstrmChageTI = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->tstrmChageII = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->toolStripSeparator1 = (gcnew System::Windows::Forms::ToolStripSeparator());
			this->tstrmClose = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->шумToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->tstrmAddNoise = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->tstrmRemoveNoise = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->tbpAll = (gcnew System::Windows::Forms::TabControl());
			this->colorDialog1 = (gcnew System::Windows::Forms::ColorDialog());
			this->tbpView->SuspendLayout();
			this->gbTypeOfCalculator->SuspendLayout();
			this->panel3->SuspendLayout();
			this->gbAll->SuspendLayout();
			this->panel4->SuspendLayout();
			this->gbMultistart->SuspendLayout();
			this->panel6->SuspendLayout();
			this->groupBox4->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgvCriterial))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbProcess))->BeginInit();
			this->tbpMain->SuspendLayout();
			this->groupBox3->SuspendLayout();
			this->groupBox2->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbII))->BeginInit();
			this->groupBox1->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbTI))->BeginInit();
			this->menuStrip1->SuspendLayout();
			this->tbpAll->SuspendLayout();
			this->SuspendLayout();
			// 
			// openFileDialog1
			// 
			this->openFileDialog1->FileName = L"openFileDialog1";
			// 
			// tbpView
			// 
			this->tbpView->BackColor = System::Drawing::Color::Silver;
			this->tbpView->Controls->Add(this->gbTypeOfCalculator);
			this->tbpView->Controls->Add(this->panel3);
			this->tbpView->Controls->Add(this->panel2);
			this->tbpView->Controls->Add(this->gbAll);
			this->tbpView->Controls->Add(this->gbMultistart);
			this->tbpView->Controls->Add(this->dgvCriterial);
			this->tbpView->Controls->Add(this->pbProcess);
			this->tbpView->Location = System::Drawing::Point(4, 29);
			this->tbpView->Name = L"tbpView";
			this->tbpView->Padding = System::Windows::Forms::Padding(3);
			this->tbpView->Size = System::Drawing::Size(1074, 674);
			this->tbpView->TabIndex = 1;
			this->tbpView->Text = L"Обзор";
			// 
			// gbTypeOfCalculator
			// 
			this->gbTypeOfCalculator->BackColor = System::Drawing::Color::LightGray;
			this->gbTypeOfCalculator->Controls->Add(this->rbSingle);
			this->gbTypeOfCalculator->Controls->Add(this->rbCPU);
			this->gbTypeOfCalculator->Controls->Add(this->rbGPU);
			this->gbTypeOfCalculator->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->gbTypeOfCalculator->Location = System::Drawing::Point(35, 32);
			this->gbTypeOfCalculator->Name = L"gbTypeOfCalculator";
			this->gbTypeOfCalculator->Size = System::Drawing::Size(373, 72);
			this->gbTypeOfCalculator->TabIndex = 16;
			this->gbTypeOfCalculator->TabStop = false;
			this->gbTypeOfCalculator->Text = L"Тип вычислителя";
			// 
			// rbSingle
			// 
			this->rbSingle->AutoSize = true;
			this->rbSingle->Location = System::Drawing::Point(13, 28);
			this->rbSingle->Name = L"rbSingle";
			this->rbSingle->Size = System::Drawing::Size(126, 23);
			this->rbSingle->TabIndex = 22;
			this->rbSingle->TabStop = true;
			this->rbSingle->Text = L"Однопоточное";
			this->rbSingle->UseVisualStyleBackColor = true;
			this->rbSingle->CheckedChanged += gcnew System::EventHandler(this, &FormMain::rb_CheckedChanged);
			// 
			// rbCPU
			// 
			this->rbCPU->AutoSize = true;
			this->rbCPU->Location = System::Drawing::Point(188, 28);
			this->rbCPU->Name = L"rbCPU";
			this->rbCPU->Size = System::Drawing::Size(57, 23);
			this->rbCPU->TabIndex = 20;
			this->rbCPU->TabStop = true;
			this->rbCPU->Text = L"CPU";
			this->rbCPU->UseVisualStyleBackColor = true;
			this->rbCPU->CheckedChanged += gcnew System::EventHandler(this, &FormMain::rb_CheckedChanged);
			// 
			// rbGPU
			// 
			this->rbGPU->AutoSize = true;
			this->rbGPU->Location = System::Drawing::Point(300, 28);
			this->rbGPU->Name = L"rbGPU";
			this->rbGPU->Size = System::Drawing::Size(58, 23);
			this->rbGPU->TabIndex = 21;
			this->rbGPU->TabStop = true;
			this->rbGPU->Text = L"GPU";
			this->rbGPU->UseVisualStyleBackColor = true;
			this->rbGPU->CheckedChanged += gcnew System::EventHandler(this, &FormMain::rb_CheckedChanged);
			// 
			// panel3
			// 
			this->panel3->BackColor = System::Drawing::Color::DarkGray;
			this->panel3->Controls->Add(this->btnFind);
			this->panel3->Controls->Add(this->tbY);
			this->panel3->Controls->Add(this->label16);
			this->panel3->Controls->Add(this->tbX);
			this->panel3->Controls->Add(this->label15);
			this->panel3->Location = System::Drawing::Point(446, 375);
			this->panel3->Name = L"panel3";
			this->panel3->Size = System::Drawing::Size(367, 46);
			this->panel3->TabIndex = 19;
			// 
			// btnFind
			// 
			this->btnFind->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->btnFind->Location = System::Drawing::Point(243, 5);
			this->btnFind->Name = L"btnFind";
			this->btnFind->Size = System::Drawing::Size(103, 36);
			this->btnFind->TabIndex = 11;
			this->btnFind->Text = L"Найти";
			this->btnFind->UseVisualStyleBackColor = true;
			// 
			// tbY
			// 
			this->tbY->Location = System::Drawing::Point(38, 10);
			this->tbY->Name = L"tbY";
			this->tbY->Size = System::Drawing::Size(63, 27);
			this->tbY->TabIndex = 9;
			// 
			// label16
			// 
			this->label16->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->label16->Location = System::Drawing::Point(119, 10);
			this->label16->Name = L"label16";
			this->label16->Size = System::Drawing::Size(23, 23);
			this->label16->TabIndex = 20;
			this->label16->Text = L"Y:";
			// 
			// tbX
			// 
			this->tbX->Location = System::Drawing::Point(143, 10);
			this->tbX->Name = L"tbX";
			this->tbX->Size = System::Drawing::Size(63, 27);
			this->tbX->TabIndex = 19;
			// 
			// label15
			// 
			this->label15->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->label15->Location = System::Drawing::Point(13, 10);
			this->label15->Name = L"label15";
			this->label15->Size = System::Drawing::Size(23, 23);
			this->label15->TabIndex = 10;
			this->label15->Text = L"X:";
			// 
			// panel2
			// 
			this->panel2->BackColor = System::Drawing::Color::DarkGray;
			this->panel2->Location = System::Drawing::Point(477, 32);
			this->panel2->Name = L"panel2";
			this->panel2->Size = System::Drawing::Size(44, 298);
			this->panel2->TabIndex = 18;
			// 
			// gbAll
			// 
			this->gbAll->BackColor = System::Drawing::Color::LightGray;
			this->gbAll->Controls->Add(this->lbCFAll);
			this->gbAll->Controls->Add(this->panel4);
			this->gbAll->Controls->Add(this->label13);
			this->gbAll->Controls->Add(this->lbResultAll);
			this->gbAll->Controls->Add(this->btnAll);
			this->gbAll->Controls->Add(this->lbTimeAll);
			this->gbAll->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->gbAll->Location = System::Drawing::Point(35, 129);
			this->gbAll->Name = L"gbAll";
			this->gbAll->Size = System::Drawing::Size(373, 201);
			this->gbAll->TabIndex = 15;
			this->gbAll->TabStop = false;
			this->gbAll->Text = L"Полный перебор";
			// 
			// lbCFAll
			// 
			this->lbCFAll->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbCFAll->Location = System::Drawing::Point(9, 66);
			this->lbCFAll->Name = L"lbCFAll";
			this->lbCFAll->Size = System::Drawing::Size(334, 23);
			this->lbCFAll->TabIndex = 12;
			this->lbCFAll->Text = L"Количество вычислений ЦФ:";
			// 
			// panel4
			// 
			this->panel4->BackColor = System::Drawing::Color::DarkGray;
			this->panel4->Controls->Add(this->pnColorAll);
			this->panel4->Location = System::Drawing::Point(72, 135);
			this->panel4->Name = L"panel4";
			this->panel4->Size = System::Drawing::Size(30, 30);
			this->panel4->TabIndex = 9;
			// 
			// pnColorAll
			// 
			this->pnColorAll->BackColor = System::Drawing::Color::DarkBlue;
			this->pnColorAll->Location = System::Drawing::Point(3, 3);
			this->pnColorAll->Name = L"pnColorAll";
			this->pnColorAll->Size = System::Drawing::Size(24, 24);
			this->pnColorAll->TabIndex = 8;
			this->pnColorAll->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &FormMain::pnColor_MouseClick);
			// 
			// label13
			// 
			this->label13->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->label13->Location = System::Drawing::Point(9, 139);
			this->label13->Name = L"label13";
			this->label13->Size = System::Drawing::Size(48, 23);
			this->label13->TabIndex = 7;
			this->label13->Text = L"Цвет:";
			// 
			// lbResultAll
			// 
			this->lbResultAll->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbResultAll->Location = System::Drawing::Point(9, 98);
			this->lbResultAll->Name = L"lbResultAll";
			this->lbResultAll->Size = System::Drawing::Size(334, 23);
			this->lbResultAll->TabIndex = 6;
			this->lbResultAll->Text = L"Результат:";
			// 
			// btnAll
			// 
			this->btnAll->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->btnAll->Location = System::Drawing::Point(240, 135);
			this->btnAll->Name = L"btnAll";
			this->btnAll->Size = System::Drawing::Size(103, 36);
			this->btnAll->TabIndex = 3;
			this->btnAll->Text = L"Вычислить";
			this->btnAll->UseVisualStyleBackColor = true;
			this->btnAll->Click += gcnew System::EventHandler(this, &FormMain::btnAll_Click);
			// 
			// lbTimeAll
			// 
			this->lbTimeAll->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbTimeAll->Location = System::Drawing::Point(9, 33);
			this->lbTimeAll->Name = L"lbTimeAll";
			this->lbTimeAll->Size = System::Drawing::Size(334, 23);
			this->lbTimeAll->TabIndex = 2;
			this->lbTimeAll->Text = L"Время:";
			// 
			// gbMultistart
			// 
			this->gbMultistart->BackColor = System::Drawing::Color::LightGray;
			this->gbMultistart->Controls->Add(this->lbCFMulti);
			this->gbMultistart->Controls->Add(this->panel6);
			this->gbMultistart->Controls->Add(this->label14);
			this->gbMultistart->Controls->Add(this->groupBox4);
			this->gbMultistart->Controls->Add(this->lbResultMulti);
			this->gbMultistart->Controls->Add(this->btnMulti);
			this->gbMultistart->Controls->Add(this->lbTimeMulty);
			this->gbMultistart->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->gbMultistart->Location = System::Drawing::Point(35, 357);
			this->gbMultistart->Name = L"gbMultistart";
			this->gbMultistart->Size = System::Drawing::Size(373, 294);
			this->gbMultistart->TabIndex = 14;
			this->gbMultistart->TabStop = false;
			this->gbMultistart->Text = L"Мультистарт";
			// 
			// lbCFMulti
			// 
			this->lbCFMulti->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbCFMulti->Location = System::Drawing::Point(9, 164);
			this->lbCFMulti->Name = L"lbCFMulti";
			this->lbCFMulti->Size = System::Drawing::Size(334, 23);
			this->lbCFMulti->TabIndex = 11;
			this->lbCFMulti->Text = L"Количество вычислений ЦФ:";
			// 
			// panel6
			// 
			this->panel6->BackColor = System::Drawing::Color::DarkGray;
			this->panel6->Controls->Add(this->pnColorMulti);
			this->panel6->Location = System::Drawing::Point(72, 234);
			this->panel6->Name = L"panel6";
			this->panel6->Size = System::Drawing::Size(30, 30);
			this->panel6->TabIndex = 10;
			// 
			// pnColorMulti
			// 
			this->pnColorMulti->BackColor = System::Drawing::Color::Red;
			this->pnColorMulti->Location = System::Drawing::Point(3, 3);
			this->pnColorMulti->Name = L"pnColorMulti";
			this->pnColorMulti->Size = System::Drawing::Size(24, 24);
			this->pnColorMulti->TabIndex = 8;
			this->pnColorMulti->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &FormMain::pnColor_MouseClick);
			// 
			// label14
			// 
			this->label14->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->label14->Location = System::Drawing::Point(9, 241);
			this->label14->Name = L"label14";
			this->label14->Size = System::Drawing::Size(48, 23);
			this->label14->TabIndex = 10;
			this->label14->Text = L"Цвет:";
			// 
			// groupBox4
			// 
			this->groupBox4->BackColor = System::Drawing::Color::Silver;
			this->groupBox4->Controls->Add(this->btnDetals);
			this->groupBox4->Controls->Add(this->label3);
			this->groupBox4->Controls->Add(this->tbCountPoints);
			this->groupBox4->Location = System::Drawing::Point(16, 35);
			this->groupBox4->Name = L"groupBox4";
			this->groupBox4->Size = System::Drawing::Size(345, 79);
			this->groupBox4->TabIndex = 9;
			this->groupBox4->TabStop = false;
			this->groupBox4->Text = L"Параметры";
			// 
			// btnDetals
			// 
			this->btnDetals->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->btnDetals->Location = System::Drawing::Point(224, 29);
			this->btnDetals->Name = L"btnDetals";
			this->btnDetals->Size = System::Drawing::Size(103, 36);
			this->btnDetals->TabIndex = 12;
			this->btnDetals->Text = L"Детали...";
			this->btnDetals->UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this->label3->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->label3->Location = System::Drawing::Point(38, 33);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(61, 23);
			this->label3->TabIndex = 7;
			this->label3->Text = L"Броски:";
			// 
			// tbCountPoints
			// 
			this->tbCountPoints->Location = System::Drawing::Point(105, 33);
			this->tbCountPoints->Name = L"tbCountPoints";
			this->tbCountPoints->Size = System::Drawing::Size(100, 25);
			this->tbCountPoints->TabIndex = 6;
			// 
			// lbResultMulti
			// 
			this->lbResultMulti->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbResultMulti->Location = System::Drawing::Point(9, 198);
			this->lbResultMulti->Name = L"lbResultMulti";
			this->lbResultMulti->Size = System::Drawing::Size(334, 23);
			this->lbResultMulti->TabIndex = 5;
			this->lbResultMulti->Text = L"Результат:";
			// 
			// btnMulti
			// 
			this->btnMulti->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->btnMulti->Location = System::Drawing::Point(240, 234);
			this->btnMulti->Name = L"btnMulti";
			this->btnMulti->Size = System::Drawing::Size(103, 36);
			this->btnMulti->TabIndex = 3;
			this->btnMulti->Text = L"Вычислить";
			this->btnMulti->UseVisualStyleBackColor = true;
			this->btnMulti->Click += gcnew System::EventHandler(this, &FormMain::btnMulti_Click);
			// 
			// lbTimeMulty
			// 
			this->lbTimeMulty->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbTimeMulty->Location = System::Drawing::Point(9, 131);
			this->lbTimeMulty->Name = L"lbTimeMulty";
			this->lbTimeMulty->Size = System::Drawing::Size(334, 23);
			this->lbTimeMulty->TabIndex = 2;
			this->lbTimeMulty->Text = L"Время:";
			// 
			// dgvCriterial
			// 
			this->dgvCriterial->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dgvCriterial->Location = System::Drawing::Point(446, 421);
			this->dgvCriterial->Name = L"dgvCriterial";
			this->dgvCriterial->RowHeadersWidth = 51;
			this->dgvCriterial->RowTemplate->Height = 24;
			this->dgvCriterial->Size = System::Drawing::Size(613, 230);
			this->dgvCriterial->TabIndex = 4;
			// 
			// pbProcess
			// 
			this->pbProcess->BackColor = System::Drawing::Color::Transparent;
			this->pbProcess->Location = System::Drawing::Point(522, 32);
			this->pbProcess->Name = L"pbProcess";
			this->pbProcess->Size = System::Drawing::Size(455, 300);
			this->pbProcess->TabIndex = 6;
			this->pbProcess->TabStop = false;
			// 
			// tbpMain
			// 
			this->tbpMain->BackColor = System::Drawing::Color::Silver;
			this->tbpMain->Controls->Add(this->panel1);
			this->tbpMain->Controls->Add(this->groupBox3);
			this->tbpMain->Controls->Add(this->groupBox2);
			this->tbpMain->Controls->Add(this->groupBox1);
			this->tbpMain->Controls->Add(this->menuStrip1);
			this->tbpMain->Location = System::Drawing::Point(4, 29);
			this->tbpMain->Name = L"tbpMain";
			this->tbpMain->Padding = System::Windows::Forms::Padding(3);
			this->tbpMain->Size = System::Drawing::Size(1074, 674);
			this->tbpMain->TabIndex = 0;
			this->tbpMain->Text = L"Главная";
			// 
			// panel1
			// 
			this->panel1->BackColor = System::Drawing::Color::Silver;
			this->panel1->Location = System::Drawing::Point(16, 412);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(47, 90);
			this->panel1->TabIndex = 11;
			// 
			// groupBox3
			// 
			this->groupBox3->BackColor = System::Drawing::Color::Silver;
			this->groupBox3->Controls->Add(this->lbFormatII);
			this->groupBox3->Controls->Add(this->lbIIFormat);
			this->groupBox3->Controls->Add(this->lbSNR);
			this->groupBox3->Controls->Add(this->label10);
			this->groupBox3->Controls->Add(this->lbNoise);
			this->groupBox3->Controls->Add(this->label7);
			this->groupBox3->Controls->Add(this->lbFormatTI);
			this->groupBox3->Controls->Add(this->lbTIFormat);
			this->groupBox3->Controls->Add(this->lbSizeII);
			this->groupBox3->Controls->Add(this->lbSizeTI);
			this->groupBox3->Controls->Add(this->lbIISize);
			this->groupBox3->Controls->Add(this->lbTISize);
			this->groupBox3->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->groupBox3->Location = System::Drawing::Point(41, 542);
			this->groupBox3->Name = L"groupBox3";
			this->groupBox3->Size = System::Drawing::Size(848, 96);
			this->groupBox3->TabIndex = 10;
			this->groupBox3->TabStop = false;
			this->groupBox3->Text = L"Сведения";
			// 
			// lbFormatII
			// 
			this->lbFormatII->AutoSize = true;
			this->lbFormatII->Location = System::Drawing::Point(325, 63);
			this->lbFormatII->Name = L"lbFormatII";
			this->lbFormatII->Size = System::Drawing::Size(0, 19);
			this->lbFormatII->TabIndex = 11;
			// 
			// lbIIFormat
			// 
			this->lbIIFormat->AutoSize = true;
			this->lbIIFormat->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbIIFormat->Location = System::Drawing::Point(251, 62);
			this->lbIIFormat->Name = L"lbIIFormat";
			this->lbIIFormat->Size = System::Drawing::Size(86, 19);
			this->lbIIFormat->TabIndex = 10;
			this->lbIIFormat->Text = L"Формат ЭИ:";
			// 
			// lbSNR
			// 
			this->lbSNR->AutoSize = true;
			this->lbSNR->Location = System::Drawing::Point(544, 63);
			this->lbSNR->Name = L"lbSNR";
			this->lbSNR->Size = System::Drawing::Size(15, 19);
			this->lbSNR->TabIndex = 9;
			this->lbSNR->Text = L"-";
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->label10->Location = System::Drawing::Point(492, 63);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(46, 19);
			this->label10->TabIndex = 8;
			this->label10->Text = L"ОСШ:";
			// 
			// lbNoise
			// 
			this->lbNoise->AutoSize = true;
			this->lbNoise->Location = System::Drawing::Point(613, 32);
			this->lbNoise->Name = L"lbNoise";
			this->lbNoise->Size = System::Drawing::Size(87, 19);
			this->lbNoise->TabIndex = 7;
			this->lbNoise->Text = L"Отсутствует";
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->label7->Location = System::Drawing::Point(492, 32);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(115, 19);
			this->label7->TabIndex = 6;
			this->label7->Text = L"Зашумленность:";
			// 
			// lbFormatTI
			// 
			this->lbFormatTI->AutoSize = true;
			this->lbFormatTI->Location = System::Drawing::Point(325, 32);
			this->lbFormatTI->Name = L"lbFormatTI";
			this->lbFormatTI->Size = System::Drawing::Size(0, 19);
			this->lbFormatTI->TabIndex = 5;
			// 
			// lbTIFormat
			// 
			this->lbTIFormat->AutoSize = true;
			this->lbTIFormat->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbTIFormat->Location = System::Drawing::Point(251, 32);
			this->lbTIFormat->Name = L"lbTIFormat";
			this->lbTIFormat->Size = System::Drawing::Size(85, 19);
			this->lbTIFormat->TabIndex = 4;
			this->lbTIFormat->Text = L"Формат ТИ:";
			// 
			// lbSizeII
			// 
			this->lbSizeII->AutoSize = true;
			this->lbSizeII->Location = System::Drawing::Point(146, 62);
			this->lbSizeII->Name = L"lbSizeII";
			this->lbSizeII->Size = System::Drawing::Size(0, 19);
			this->lbSizeII->TabIndex = 3;
			// 
			// lbSizeTI
			// 
			this->lbSizeTI->AutoSize = true;
			this->lbSizeTI->Location = System::Drawing::Point(146, 32);
			this->lbSizeTI->Name = L"lbSizeTI";
			this->lbSizeTI->Size = System::Drawing::Size(0, 19);
			this->lbSizeTI->TabIndex = 2;
			// 
			// lbIISize
			// 
			this->lbIISize->AutoSize = true;
			this->lbIISize->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbIISize->Location = System::Drawing::Point(23, 63);
			this->lbIISize->Name = L"lbIISize";
			this->lbIISize->Size = System::Drawing::Size(118, 19);
			this->lbIISize->TabIndex = 1;
			this->lbIISize->Text = L"Размерность ЭИ:";
			// 
			// lbTISize
			// 
			this->lbTISize->AutoSize = true;
			this->lbTISize->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F));
			this->lbTISize->Location = System::Drawing::Point(23, 32);
			this->lbTISize->Name = L"lbTISize";
			this->lbTISize->Size = System::Drawing::Size(117, 19);
			this->lbTISize->TabIndex = 0;
			this->lbTISize->Text = L"Размерность ТИ:";
			// 
			// groupBox2
			// 
			this->groupBox2->BackColor = System::Drawing::Color::LightGray;
			this->groupBox2->Controls->Add(this->pbII);
			this->groupBox2->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->groupBox2->Location = System::Drawing::Point(763, 49);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Size = System::Drawing::Size(250, 453);
			this->groupBox2->TabIndex = 9;
			this->groupBox2->TabStop = false;
			this->groupBox2->Text = L"Эталонное изображение";
			// 
			// pbII
			// 
			this->pbII->ErrorImage = nullptr;
			this->pbII->Location = System::Drawing::Point(35, 115);
			this->pbII->Name = L"pbII";
			this->pbII->Size = System::Drawing::Size(171, 139);
			this->pbII->SizeMode = System::Windows::Forms::PictureBoxSizeMode::AutoSize;
			this->pbII->TabIndex = 0;
			this->pbII->TabStop = false;
			// 
			// groupBox1
			// 
			this->groupBox1->BackColor = System::Drawing::Color::LightGray;
			this->groupBox1->Controls->Add(this->pbTI);
			this->groupBox1->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 7.8F, System::Drawing::FontStyle::Bold));
			this->groupBox1->Location = System::Drawing::Point(30, 49);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(681, 453);
			this->groupBox1->TabIndex = 8;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Текущее изображение";
			// 
			// pbTI
			// 
			this->pbTI->ErrorImage = nullptr;
			this->pbTI->Location = System::Drawing::Point(65, 24);
			this->pbTI->Name = L"pbTI";
			this->pbTI->Size = System::Drawing::Size(600, 400);
			this->pbTI->SizeMode = System::Windows::Forms::PictureBoxSizeMode::AutoSize;
			this->pbTI->TabIndex = 1;
			this->pbTI->TabStop = false;
			// 
			// menuStrip1
			// 
			this->menuStrip1->BackColor = System::Drawing::Color::LightGray;
			this->menuStrip1->ImageScalingSize = System::Drawing::Size(20, 20);
			this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {
				this->изображениеToolStripMenuItem,
					this->шумToolStripMenuItem
			});
			this->menuStrip1->Location = System::Drawing::Point(3, 3);
			this->menuStrip1->Name = L"menuStrip1";
			this->menuStrip1->Size = System::Drawing::Size(1068, 28);
			this->menuStrip1->TabIndex = 7;
			this->menuStrip1->Text = L"menuStrip1";
			// 
			// изображениеToolStripMenuItem
			// 
			this->изображениеToolStripMenuItem->BackColor = System::Drawing::Color::Gainsboro;
			this->изображениеToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(4) {
				this->tstrmChageTI,
					this->tstrmChageII, this->toolStripSeparator1, this->tstrmClose
			});
			this->изображениеToolStripMenuItem->Name = L"изображениеToolStripMenuItem";
			this->изображениеToolStripMenuItem->Size = System::Drawing::Size(121, 24);
			this->изображениеToolStripMenuItem->Text = L"Изображения";
			// 
			// tstrmChageTI
			// 
			this->tstrmChageTI->Name = L"tstrmChageTI";
			this->tstrmChageTI->Size = System::Drawing::Size(176, 26);
			this->tstrmChageTI->Text = L"Выбрать ТИ";
			this->tstrmChageTI->Click += gcnew System::EventHandler(this, &FormMain::tstrmChageTI_Click);
			// 
			// tstrmChageII
			// 
			this->tstrmChageII->Name = L"tstrmChageII";
			this->tstrmChageII->Size = System::Drawing::Size(176, 26);
			this->tstrmChageII->Text = L"Выбрать ЭИ";
			this->tstrmChageII->Click += gcnew System::EventHandler(this, &FormMain::tstrmChageII_Click);
			// 
			// toolStripSeparator1
			// 
			this->toolStripSeparator1->Name = L"toolStripSeparator1";
			this->toolStripSeparator1->Size = System::Drawing::Size(173, 6);
			// 
			// tstrmClose
			// 
			this->tstrmClose->Name = L"tstrmClose";
			this->tstrmClose->Size = System::Drawing::Size(176, 26);
			this->tstrmClose->Text = L"Выход";
			this->tstrmClose->Click += gcnew System::EventHandler(this, &FormMain::tstrmClose_Click_1);
			// 
			// шумToolStripMenuItem
			// 
			this->шумToolStripMenuItem->BackColor = System::Drawing::Color::Gainsboro;
			this->шумToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {
				this->tstrmAddNoise,
					this->tstrmRemoveNoise
			});
			this->шумToolStripMenuItem->Name = L"шумToolStripMenuItem";
			this->шумToolStripMenuItem->Size = System::Drawing::Size(55, 24);
			this->шумToolStripMenuItem->Text = L"Шум";
			// 
			// tstrmAddNoise
			// 
			this->tstrmAddNoise->Name = L"tstrmAddNoise";
			this->tstrmAddNoise->Size = System::Drawing::Size(196, 26);
			this->tstrmAddNoise->Text = L"Наложить шум";
			this->tstrmAddNoise->Click += gcnew System::EventHandler(this, &FormMain::tstrmAddNoise_Click);
			// 
			// tstrmRemoveNoise
			// 
			this->tstrmRemoveNoise->Name = L"tstrmRemoveNoise";
			this->tstrmRemoveNoise->Size = System::Drawing::Size(196, 26);
			this->tstrmRemoveNoise->Text = L"Убрать шум";
			// 
			// tbpAll
			// 
			this->tbpAll->Controls->Add(this->tbpMain);
			this->tbpAll->Controls->Add(this->tbpView);
			this->tbpAll->Font = (gcnew System::Drawing::Font(L"Segoe UI Semibold", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->tbpAll->Location = System::Drawing::Point(3, 0);
			this->tbpAll->Name = L"tbpAll";
			this->tbpAll->SelectedIndex = 0;
			this->tbpAll->Size = System::Drawing::Size(1082, 707);
			this->tbpAll->TabIndex = 6;
			// 
			// FormMain
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1088, 706);
			this->Controls->Add(this->tbpAll);
			this->Name = L"FormMain";
			this->Text = L"FormMain";
			this->Load += gcnew System::EventHandler(this, &FormMain::FormMain_Load);
			this->Click += gcnew System::EventHandler(this, &FormMain::tstrmClose_Click);
			this->tbpView->ResumeLayout(false);
			this->gbTypeOfCalculator->ResumeLayout(false);
			this->gbTypeOfCalculator->PerformLayout();
			this->panel3->ResumeLayout(false);
			this->panel3->PerformLayout();
			this->gbAll->ResumeLayout(false);
			this->panel4->ResumeLayout(false);
			this->gbMultistart->ResumeLayout(false);
			this->panel6->ResumeLayout(false);
			this->groupBox4->ResumeLayout(false);
			this->groupBox4->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dgvCriterial))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbProcess))->EndInit();
			this->tbpMain->ResumeLayout(false);
			this->tbpMain->PerformLayout();
			this->groupBox3->ResumeLayout(false);
			this->groupBox3->PerformLayout();
			this->groupBox2->ResumeLayout(false);
			this->groupBox2->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbII))->EndInit();
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pbTI))->EndInit();
			this->menuStrip1->ResumeLayout(false);
			this->menuStrip1->PerformLayout();
			this->tbpAll->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion

	private:
		FMainManager* mainManager;
		Gdiplus::Bitmap* FtiWithoutNoise;
		int K, L, M, N;
		img* Fti;
		img* Fii;
		int typeOfCalculator = 0;

		System::Void tstrmAddNoise_Click(System::Object^ sender, System::EventArgs^ e)
		{
			FormNoise^ fNoise = gcnew FormNoise();
			fNoise->Show();
		}

		System::Void tstrmClose_Click(System::Object^ sender, System::EventArgs^ e)
		{
			this->Close();
		}

		System::Void tstrmChageTI_Click(System::Object^ sender, System::EventArgs^ e)
		{
			Fti = ChooseImage(pbTI, Fti);
			Fti = mainManager->ConvertToBlackAndWhite(Fti);
			lbTISize->Text = "Размерность TИ: " + (pbTI->Width).ToString() + "x" + (pbTI->Height).ToString();
			lbTIFormat->Text = "Формат TИ: bmp";
			changeImage(pbTI, Fti);
		}

		System::Void tstrmChageII_Click(System::Object^ sender, System::EventArgs^ e)
		{
			Fii = ChooseImage(pbII, Fii);
			Fii = mainManager->ConvertToBlackAndWhite(Fii);
			lbIISize->Text = "Размерность ЭИ: " + (pbII->Width).ToString() + "x" + (pbII->Height).ToString();
			lbIIFormat->Text = "Формат ЭИ: bmp";
			changeImage(pbII, Fii);
		}



		System::Void btnAll_Click(System::Object^ sender, System::EventArgs^ e)
		{
			if (Fii == 0 || Fti == 0)
			{
				GenerationError("Не загружено изображение!");
				return;
			}
			TotallyOverkill* overKill = new TotallyOverkill(Fii, Fti);
			CriterionFunction* CF = (mainManager->StartMetodImageCombiner(Fii, Fti, (ImageCombiner*)overKill, 0, typeOfCalculator));
			changeImage(pbTI, mainManager->SelectAreaWhereImagesMatches(Fti, Fii, mainManager->pointMax, exportThisColor(pnColorAll->BackColor)));
			img* CFimage = new img();
			CFimage->Height = Fti->Height - Fii->Height;
			CFimage->Width = Fti->Width - Fii->Width;
			changeImage(pbProcess, mainManager->DrawFCriteroin(CFimage, ((ImageCombiner*)overKill)->CF->getFcriterion()), CFimage->Width, CFimage->Height);
			lbResultAll->Text = msclr::interop::marshal_as<String^>(mainManager->infoMetodResult);
		}

		System::Void btnMulti_Click(System::Object^ sender, System::EventArgs^ e)
		{
			if (Fii == 0 || Fti == 0)
			{
				GenerationError("Не загружено изображение!");
				return;
			}
			int countPoints = 0;
			try {
				countPoints = std::stoi((char*)(void*)System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(tbCountPoints->Text));
			}
			catch (std::invalid_argument e) {
				GenerationError("Число бросков не указано или указано не корректно");
				return;
			}
			Multistart* multi = new Multistart(Fii, Fti);
			CriterionFunction* CF = (mainManager->StartMetodImageCombiner(Fii, Fti, (ImageCombiner*)multi, countPoints, typeOfCalculator));
			changeImage(pbTI, mainManager->SelectAreaWhereImagesMatches(Fti, Fii, mainManager->pointMax, exportThisColor(pnColorMulti->BackColor)));
			img* CFimage = new img();
			CFimage->Height = Fti->Height - Fii->Height;
			CFimage->Width = Fti->Width - Fii->Width;
			changeImage(pbProcess, mainManager->DrawFCriteroin(CFimage, ((ImageCombiner*)multi)->CF->getFcriterion()), CFimage->Width, CFimage->Height);
			lbResultMulti->Text = msclr::interop::marshal_as<String^>(mainManager->infoMetodResult);
		}

		void StartMetodImageCombiner(ImageCombiner* combiner, int param, Gdiplus::Color color)
		{
			//	CriterionFunction* CF = mainManager->StartMetodImageCombiner(Fti, Fii, combiner, param);
				//FillTableCriterionFunction(CF);
			//	pbProcess->Image = mainManager->ShowProcess(CF);
			//	pbTI.Image = mainManager.SelectAreaWhereImagesMatches((Bitmap)pbTI.Image, (Bitmap)pbII.Image, mainManager.pointMax, color);
			//
		}

		Gdiplus::Color exportThisColor(System::Drawing::Color colorThis)
		{
			Gdiplus::Color exportColor(colorThis.R, colorThis.G, colorThis.B);
			return exportColor;
		}
		System::String^ importCharToString(char* ch)
		{
			char* chr = ch;
			System::String^ str;
			for (int i = 0;chr[i] != '\0';i++)
			{
				str += wchar_t(ch[i]);
			}
			return str;
		}

		System::Void FormMain_Load(System::Object^ sender, System::EventArgs^ e)
		{
			mainManager = new FMainManager();
			rbSingle->Checked = true;
			//  ConfigureSpecialButtons();
		}

		/*
		void StartMetodImageCombiner(ImageCombiner combiner, int param, Color color)
		{
			CriterionFunction CF = mainManager->StartMetodImageCombiner(Fti, Fii, combiner, param);
			FillTableCriterionFunction(CF);
			pbProcess.Image = mainManager.ShowProcess(CF);
			pbTI.Image = mainManager.SelectAreaWhereImagesMatches((Bitmap)pbTI.Image, (Bitmap)pbII.Image, mainManager.pointMax, color);
		}*/

		void GenerationError(String^ infoAboutError)
		{
			MessageBox::Show(infoAboutError);
		}


#pragma region Service


		void FillTableCriterionFunction(CriterionFunction* CF)
		{
			//		dgvCriterial->ColumnCount = CF;
			dgvCriterial->RowCount = K - N;
			//		for (int y = 0; y < L - M; y++)
			//			for (int x = 0; x < K - N; x++)
							//dgvCriterial.Rows[x].Cells[y].Value = CF.Fcriterion[y, x].ToString();
		}




		void changeImage(PictureBox^ pb, img* image)
		{
			System::Drawing::Bitmap^ bitmap = gcnew System::Drawing::Bitmap(pb->Image);
			for (int j = 0; j < image->Height; j++)
			{
				for (int i = 0; i < image->Width; i++)
				{
					bitmap->SetPixel(i, j, System::Drawing::Color::FromArgb(image->Image[j * image->Width + i]));
				}
			}
			pb->Image = bitmap;
		}


		void changeImage(PictureBox^ pb, img* image, int width, int height)
		{
			System::Drawing::Bitmap^ bitmap = gcnew System::Drawing::Bitmap(width, height);
			for (int j = 0; j < image->Height; j++)
			{
				for (int i = 0; i < image->Width; i++)
				{
					bitmap->SetPixel(i, j, System::Drawing::Color::FromArgb(image->Image[j * image->Width + i]));
				}
			}
			pb->Image = bitmap;
		}

		img* ChooseImage(PictureBox^ pb, img* image)
		{
			openFileDialog1->Filter = "Images (bmp, jpg, jpeg) | * .jpg;*.bmp;*.jpeg";
			openFileDialog1->Title = "Select image file";
			if (openFileDialog1->ShowDialog() == System::Windows::Forms::DialogResult::OK)
			{
				pb->Image = System::Drawing::Bitmap::FromFile(openFileDialog1->FileName);
			}
			image = new img();
			image->Width = pb->Image->Width;
			image->Height = pb->Image->Height;
			image->Image = new unsigned[image->Width * image->Height];
			System::Drawing::Bitmap^ bitmap = gcnew System::Drawing::Bitmap(pb->Image);
			for (int j = 0; j < image->Height; j++)
			{
				for (int i = 0; i < image->Width; i++)
				{
					image->Image[j * image->Width + i] = bitmap->GetPixel(i, j).ToArgb();
				}
			}
			return image;
		}


#pragma endregion

	private:
		System::Void tstrmClose_Click_1(System::Object^ sender, System::EventArgs^ e)
		{
			this->Close();
		}

		System::Void pnColor_MouseClick(System::Object^ sender, System::Windows::Forms::MouseEventArgs^ e)
		{
			if (colorDialog1->ShowDialog() == System::Windows::Forms::DialogResult::Cancel)
				return;
			((Panel^)(sender))->BackColor = colorDialog1->Color;
		}

		System::Void rb_CheckedChanged(System::Object^ sender, System::EventArgs^ e)
		{
			if (((RadioButton^)sender)->Checked)
			{
				typeOfCalculator = gbTypeOfCalculator->Controls->IndexOf((System::Windows::Forms::Control^)sender);
			}
		}

		
	};
}



