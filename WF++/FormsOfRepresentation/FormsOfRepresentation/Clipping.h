#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;


namespace FormsOfRepresentation {

	/// <summary>
	/// —водка дл€ Clipping
	/// </summary>
	public ref class Clipping : public System::Windows::Forms::UserControl
	{
	public:
		Clipping()
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
		~Clipping()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ btnCut;
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
		void InitializeComponent()
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Clipping::typeid));
			this->btnCut = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// btnCut
			// 
			this->btnCut->BackColor = System::Drawing::Color::WhiteSmoke;
			this->btnCut->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"btnCut.Image")));
			this->btnCut->Location = System::Drawing::Point(0, 1);
			this->btnCut->Margin = System::Windows::Forms::Padding(0);
			this->btnCut->Name = L"btnCut";
			this->btnCut->Size = System::Drawing::Size(42, 43);
			this->btnCut->TabIndex = 15;
			this->btnCut->UseVisualStyleBackColor = false;
			this->btnCut->Click += gcnew System::EventHandler(this, &Clipping::btnCut_Click_1);
			// 
			// Clipping
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->Controls->Add(this->btnCut);
			this->Name = L"Clipping";
			this->Size = System::Drawing::Size(43, 44);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: 
		PictureBox^ pbSelectionArea;
		PictureBox^ pbReceiver;
		PictureBox^ pbParent;


		int begin_x;
		int begin_y; // оординаты картинки на исходном pictureBox.
		bool resize = false; //Ёта специальна€ переменна€ уберегающа€ от случайных нажатий мышкой по изображению.
		bool cut = false;

		void ConfigureClipping(PictureBox^ pbParent, PictureBox^ pbReceiver)
		{
			this->pbReceiver = pbReceiver;
			this->pbParent = pbParent;
			pbSelectionArea = gcnew PictureBox();
			pbSelectionArea->Parent = pbParent;
			pbSelectionArea->BackColor = System::Drawing::Color::Transparent;
			pbSelectionArea->SizeMode = PictureBoxSizeMode::AutoSize;
		//pbSelectionArea->BorderStyle = BorderStyle;
			pbSelectionArea->Visible = false;
			pbParent->MouseUp += gcnew System::Windows::Forms::MouseEventHandler(this, &Clipping::parent_MouseUp);
			pbParent->MouseDown += gcnew System::Windows::Forms::MouseEventHandler(this, &Clipping::parent_MouseDown);
			pbParent->MouseMove += gcnew System::Windows::Forms::MouseEventHandler(this, &Clipping::parent_MouseMove);
		}


		System::Void btnCut_Click(System::Object^ sender, System::EventArgs^ e) 
		{
			System::Drawing::Image^ img = (pbParent->Image);
			if (img->Width != 0)
				cut = true;
		}

		/*t System::Windows::Forms::MouseEventHandler MouseUp
    „лен System::Windows::Forms::Control
*/
		System::Void parent_MouseUp(System::Object^ sender, System::Windows::Forms::MouseEventArgs^ e)
		{
			if (cut)
			{
				pbSelectionArea->Width = 0;
				pbSelectionArea->Height = 0;
				pbSelectionArea->Visible = false;
				if (resize == true)
				{
					if ((e->X > begin_x + 10) && (e->Y > begin_y + 10))
					{
						System::Drawing::Rectangle rec(begin_x, begin_y, e->X - begin_x, e->Y - begin_y);
						pbReceiver->Image = Copy(pbParent->Image, rec);
						//ChangeImageReceiver ? .Invoke(pbReceiver);
						cut = false;
					}
				}
				resize = false;
			}
		}

		System::Void parent_MouseDown(System::Object^ sender, System::Windows::Forms::MouseEventArgs^ e)
		{
			if (cut)
			{
				if (e->Button == System::Windows::Forms::MouseButtons::Left)
				{
					begin_x = e->X;
					begin_y = e->Y;
					pbSelectionArea->Left = e->X;
					pbSelectionArea->Top = e->Y;
					pbSelectionArea->Width = 0;
					pbSelectionArea->Height = 0;
					pbSelectionArea->Visible = true;
					resize = true;
				}
			}
		}

		System::Void parent_MouseMove(System::Object^ sender, System::Windows::Forms::MouseEventArgs^ e)
		{
			if (cut)
			{
				Cursor->Current = Cursors::Cross;
				if (e->Button == System::Windows::Forms::MouseButtons::Left)
				{
					pbSelectionArea->Width = e->X - begin_x;
					pbSelectionArea->Height = e->Y - begin_y;
				}
			}
		}

		System::Drawing::Image^ Copy(System::Drawing::Image^ srcBitmap, System::Drawing::Rectangle section)
		{
			System::Drawing::Bitmap^ img = gcnew System::Drawing::Bitmap(section.Width, section.Height);
		
			System::Drawing::Graphics^ g = System::Drawing::Graphics::FromImage(img);
			g->DrawImage(srcBitmap, 0, 0, section, GraphicsUnit::Pixel);
			return img;
		}
	

private: System::Void btnCut_Click_1(System::Object^ sender, System::EventArgs^ e) {
}
};
}
