namespace Hippodrome
{
    partial class FormRacing
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
            this.lb1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdDate = new System.Windows.Forms.Button();
            this.btnRacingIns = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHorse = new System.Windows.Forms.ComboBox();
            this.btnHorse = new System.Windows.Forms.Button();
            this.dgvHorseInRacing = new System.Windows.Forms.DataGridView();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racing2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horse2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jockey2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRacing = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSee = new System.Windows.Forms.Button();
            this.btnUpdRacing = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorseInRacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacing)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(264, 35);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(68, 13);
            this.lb1.TabIndex = 24;
            this.lb1.Text = "Расписание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Участники";
            // 
            // btnUpdDate
            // 
            this.btnUpdDate.Location = new System.Drawing.Point(398, 339);
            this.btnUpdDate.Name = "btnUpdDate";
            this.btnUpdDate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdDate.TabIndex = 22;
            this.btnUpdDate.Text = "Изменить";
            this.btnUpdDate.UseVisualStyleBackColor = true;
            this.btnUpdDate.Click += new System.EventHandler(this.btnUpdDate_Click);
            // 
            // btnRacingIns
            // 
            this.btnRacingIns.Location = new System.Drawing.Point(204, 388);
            this.btnRacingIns.Name = "btnRacingIns";
            this.btnRacingIns.Size = new System.Drawing.Size(194, 23);
            this.btnRacingIns.TabIndex = 23;
            this.btnRacingIns.Text = "Регистрация";
            this.btnRacingIns.UseVisualStyleBackColor = true;
            this.btnRacingIns.Click += new System.EventHandler(this.btnRacingIns_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "До";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "С";
            // 
            // dtIn
            // 
            this.dtIn.Location = new System.Drawing.Point(113, 342);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(110, 20);
            this.dtIn.TabIndex = 19;
            // 
            // dtOut
            // 
            this.dtOut.Location = new System.Drawing.Point(267, 342);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(110, 20);
            this.dtOut.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Изменить время пребывания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Просмотр событий для:";
            // 
            // cbHorse
            // 
            this.cbHorse.FormattingEnabled = true;
            this.cbHorse.Location = new System.Drawing.Point(256, 280);
            this.cbHorse.Name = "cbHorse";
            this.cbHorse.Size = new System.Drawing.Size(121, 21);
            this.cbHorse.TabIndex = 15;
            // 
            // btnHorse
            // 
            this.btnHorse.Location = new System.Drawing.Point(398, 278);
            this.btnHorse.Name = "btnHorse";
            this.btnHorse.Size = new System.Drawing.Size(75, 23);
            this.btnHorse.TabIndex = 14;
            this.btnHorse.Text = "Выбрать";
            this.btnHorse.UseVisualStyleBackColor = true;
            this.btnHorse.Click += new System.EventHandler(this.btnHorse_Click);
            // 
            // dgvHorseInRacing
            // 
            this.dgvHorseInRacing.AllowUserToAddRows = false;
            this.dgvHorseInRacing.AllowUserToDeleteRows = false;
            this.dgvHorseInRacing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHorseInRacing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorseInRacing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id2,
            this.racing2,
            this.horse2,
            this.jockey2,
            this.place2});
            this.dgvHorseInRacing.Location = new System.Drawing.Point(609, 51);
            this.dgvHorseInRacing.Name = "dgvHorseInRacing";
            this.dgvHorseInRacing.ReadOnly = true;
            this.dgvHorseInRacing.Size = new System.Drawing.Size(491, 371);
            this.dgvHorseInRacing.TabIndex = 13;
            // 
            // id2
            // 
            this.id2.HeaderText = "Номер";
            this.id2.Name = "id2";
            this.id2.ReadOnly = true;
            this.id2.Visible = false;
            this.id2.Width = 66;
            // 
            // racing2
            // 
            this.racing2.HeaderText = "Скачки";
            this.racing2.Name = "racing2";
            this.racing2.ReadOnly = true;
            this.racing2.Width = 68;
            // 
            // horse2
            // 
            this.horse2.HeaderText = "Лошадь";
            this.horse2.Name = "horse2";
            this.horse2.ReadOnly = true;
            this.horse2.Width = 72;
            // 
            // jockey2
            // 
            this.jockey2.HeaderText = "Жокей";
            this.jockey2.Name = "jockey2";
            this.jockey2.ReadOnly = true;
            this.jockey2.Width = 67;
            // 
            // place2
            // 
            this.place2.HeaderText = "Место";
            this.place2.Name = "place2";
            this.place2.ReadOnly = true;
            this.place2.Width = 64;
            // 
            // dgvRacing
            // 
            this.dgvRacing.AllowUserToAddRows = false;
            this.dgvRacing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRacing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.typeR,
            this.gender,
            this.breed,
            this.age,
            this.date,
            this.time,
            this.money,
            this.count,
            this.Chk});
            this.dgvRacing.Location = new System.Drawing.Point(23, 51);
            this.dgvRacing.Name = "dgvRacing";
            this.dgvRacing.Size = new System.Drawing.Size(550, 198);
            this.dgvRacing.TabIndex = 12;
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 43;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 82;
            // 
            // typeR
            // 
            this.typeR.HeaderText = "Дистанция";
            this.typeR.Name = "typeR";
            this.typeR.ReadOnly = true;
            this.typeR.Width = 88;
            // 
            // gender
            // 
            this.gender.HeaderText = "Пол";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 52;
            // 
            // breed
            // 
            this.breed.HeaderText = "Порода";
            this.breed.Name = "breed";
            this.breed.ReadOnly = true;
            this.breed.Width = 70;
            // 
            // age
            // 
            this.age.HeaderText = "Начальный возраст";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 122;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 58;
            // 
            // time
            // 
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 65;
            // 
            // money
            // 
            this.money.HeaderText = "Призовой фонд";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            this.money.Width = 102;
            // 
            // count
            // 
            this.count.HeaderText = "Кол-во участников";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 115;
            // 
            // Chk
            // 
            this.Chk.HeaderText = "Выбор";
            this.Chk.Name = "Chk";
            this.Chk.Width = 46;
            // 
            // btnSee
            // 
            this.btnSee.Location = new System.Drawing.Point(857, 22);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(75, 23);
            this.btnSee.TabIndex = 26;
            this.btnSee.Text = "Обзор";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // btnUpdRacing
            // 
            this.btnUpdRacing.Location = new System.Drawing.Point(23, 255);
            this.btnUpdRacing.Name = "btnUpdRacing";
            this.btnUpdRacing.Size = new System.Drawing.Size(59, 23);
            this.btnUpdRacing.TabIndex = 27;
            this.btnUpdRacing.Text = "Сброс";
            this.btnUpdRacing.UseVisualStyleBackColor = true;
            this.btnUpdRacing.Click += new System.EventHandler(this.btnUpdRacing_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.Location = new System.Drawing.Point(528, 399);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(75, 23);
            this.btnDlt.TabIndex = 28;
            this.btnDlt.Text = "Удалить";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // FormRacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.btnUpdRacing);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdDate);
            this.Controls.Add(this.btnRacingIns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtIn);
            this.Controls.Add(this.dtOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHorse);
            this.Controls.Add(this.btnHorse);
            this.Controls.Add(this.dgvHorseInRacing);
            this.Controls.Add(this.dgvRacing);
            this.Name = "FormRacing";
            this.Text = "Racing";
            this.Controls.SetChildIndex(this.dgvRacing, 0);
            this.Controls.SetChildIndex(this.dgvHorseInRacing, 0);
            this.Controls.SetChildIndex(this.btnHorse, 0);
            this.Controls.SetChildIndex(this.cbHorse, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtOut, 0);
            this.Controls.SetChildIndex(this.dtIn, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnRacingIns, 0);
            this.Controls.SetChildIndex(this.btnUpdDate, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lb1, 0);
            this.Controls.SetChildIndex(this.btnSee, 0);
            this.Controls.SetChildIndex(this.btnUpdRacing, 0);
            this.Controls.SetChildIndex(this.btnDlt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorseInRacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdDate;
        private System.Windows.Forms.Button btnRacingIns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.DateTimePicker dtOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHorse;
        private System.Windows.Forms.Button btnHorse;
        private System.Windows.Forms.DataGridView dgvHorseInRacing;
        private System.Windows.Forms.DataGridView dgvRacing;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Button btnUpdRacing;
        private System.Windows.Forms.Button btnDlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn racing2;
        private System.Windows.Forms.DataGridViewTextBoxColumn horse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jockey2;
        private System.Windows.Forms.DataGridViewTextBoxColumn place2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeR;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn breed;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
    }
}