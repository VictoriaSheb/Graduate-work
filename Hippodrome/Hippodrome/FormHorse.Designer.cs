namespace Hippodrome
{
    partial class FormHorse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvHorses = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.father = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbF = new System.Windows.Forms.TextBox();
            this.cbBreed = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpIn = new System.Windows.Forms.DateTimePicker();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorses
            // 
            this.dgvHorses.AllowUserToAddRows = false;
            this.dgvHorses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHorses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.father,
            this.mother,
            this.breed,
            this.gender,
            this.age,
            this.dateIn,
            this.dateOut,
            this.Chk});
            this.dgvHorses.Location = new System.Drawing.Point(12, 243);
            this.dgvHorses.Name = "dgvHorses";
            this.dgvHorses.Size = new System.Drawing.Size(776, 195);
            this.dgvHorses.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Чип-номер";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 87;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 54;
            // 
            // father
            // 
            this.father.HeaderText = "Отец";
            this.father.Name = "father";
            this.father.ReadOnly = true;
            this.father.Width = 57;
            // 
            // mother
            // 
            this.mother.HeaderText = "Мать";
            this.mother.Name = "mother";
            this.mother.ReadOnly = true;
            this.mother.Width = 58;
            // 
            // breed
            // 
            this.breed.HeaderText = "Порода";
            this.breed.Name = "breed";
            this.breed.ReadOnly = true;
            this.breed.Width = 70;
            // 
            // gender
            // 
            this.gender.HeaderText = "Пол";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 52;
            // 
            // age
            // 
            this.age.HeaderText = "Возраст";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 74;
            // 
            // dateIn
            // 
            this.dateIn.HeaderText = "Дата прибытия";
            this.dateIn.Name = "dateIn";
            this.dateIn.ReadOnly = true;
            this.dateIn.Width = 101;
            // 
            // dateOut
            // 
            this.dateOut.HeaderText = "Дата отъезда";
            this.dateOut.Name = "dateOut";
            this.dateOut.ReadOnly = true;
            this.dateOut.Width = 95;
            // 
            // Chk
            // 
            this.Chk.HeaderText = "Выбрать";
            this.Chk.Name = "Chk";
            this.Chk.Width = 57;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(104, 59);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(105, 20);
            this.tbId.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(333, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(105, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(104, 142);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(105, 20);
            this.tbM.TabIndex = 2;
            // 
            // tbF
            // 
            this.tbF.Location = new System.Drawing.Point(104, 100);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(105, 20);
            this.tbF.TabIndex = 2;
            // 
            // cbBreed
            // 
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.Location = new System.Drawing.Point(333, 144);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(159, 21);
            this.cbBreed.TabIndex = 4;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(333, 97);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(105, 21);
            this.cbGender.TabIndex = 4;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(625, 66);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(105, 20);
            this.nudAge.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(359, 196);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 11;
            this.btnUpd.Text = "Обновить";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.Location = new System.Drawing.Point(502, 196);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(75, 23);
            this.btnDlt.TabIndex = 12;
            this.btnDlt.Text = "Удалить";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Порода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Чип-номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Отец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Мать";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Пол";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Возраст";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Дата прибытия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Дата отъезда";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtpIn
            // 
            this.dtpIn.Location = new System.Drawing.Point(625, 110);
            this.dtpIn.Name = "dtpIn";
            this.dtpIn.Size = new System.Drawing.Size(111, 20);
            this.dtpIn.TabIndex = 15;
            // 
            // dtpOut
            // 
            this.dtpOut.Location = new System.Drawing.Point(625, 155);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.Size = new System.Drawing.Size(111, 20);
            this.dtpOut.TabIndex = 16;
            // 
            // FormHorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpOut);
            this.Controls.Add(this.dtpIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbBreed);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.dgvHorses);
            this.Name = "FormHorse";
            this.Text = " ";
            this.Controls.SetChildIndex(this.dgvHorses, 0);
            this.Controls.SetChildIndex(this.tbId, 0);
            this.Controls.SetChildIndex(this.tbName, 0);
            this.Controls.SetChildIndex(this.tbM, 0);
            this.Controls.SetChildIndex(this.tbF, 0);
            this.Controls.SetChildIndex(this.cbBreed, 0);
            this.Controls.SetChildIndex(this.cbGender, 0);
            this.Controls.SetChildIndex(this.nudAge, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnUpd, 0);
            this.Controls.SetChildIndex(this.btnDlt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtpIn, 0);
            this.Controls.SetChildIndex(this.dtpOut, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorses;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbF;
        private System.Windows.Forms.ComboBox cbBreed;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpIn;
        private System.Windows.Forms.DateTimePicker dtpOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn father;
        private System.Windows.Forms.DataGridViewTextBoxColumn mother;
        private System.Windows.Forms.DataGridViewTextBoxColumn breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
    }
}