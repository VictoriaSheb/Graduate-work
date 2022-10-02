namespace Hippodrome
{
    partial class FormRate
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
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.cbRacing = new System.Windows.Forms.ComboBox();
            this.btnLook = new System.Windows.Forms.Button();
            this.dtgRateCoefficient = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btIns = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btView = new System.Windows.Forms.Button();
            this.dtgRateClient = new System.Windows.Forms.DataGridView();
            this.nameR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtbSum = new System.Windows.Forms.MaskedTextBox();
            this.btnUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRateCoefficient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRateClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRate
            // 
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Location = new System.Drawing.Point(156, 55);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(121, 21);
            this.cbRate.TabIndex = 1;
            // 
            // cbRacing
            // 
            this.cbRacing.FormattingEnabled = true;
            this.cbRacing.Location = new System.Drawing.Point(29, 55);
            this.cbRacing.Name = "cbRacing";
            this.cbRacing.Size = new System.Drawing.Size(121, 21);
            this.cbRacing.TabIndex = 1;
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(301, 53);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(75, 23);
            this.btnLook.TabIndex = 2;
            this.btnLook.Text = "Обзор";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // dtgRateCoefficient
            // 
            this.dtgRateCoefficient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgRateCoefficient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRateCoefficient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.k,
            this.ch1});
            this.dtgRateCoefficient.Location = new System.Drawing.Point(12, 97);
            this.dtgRateCoefficient.Name = "dtgRateCoefficient";
            this.dtgRateCoefficient.Size = new System.Drawing.Size(430, 354);
            this.dtgRateCoefficient.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "№";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Лошадь";
            this.name.Name = "name";
            this.name.Width = 72;
            // 
            // k
            // 
            this.k.HeaderText = "Коэффициент";
            this.k.Name = "k";
            this.k.Width = 102;
            // 
            // ch1
            // 
            this.ch1.HeaderText = "";
            this.ch1.Name = "ch1";
            this.ch1.Width = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Скачки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ставка";
            // 
            // btIns
            // 
            this.btIns.Location = new System.Drawing.Point(503, 331);
            this.btIns.Name = "btIns";
            this.btIns.Size = new System.Drawing.Size(75, 23);
            this.btIns.TabIndex = 6;
            this.btIns.Text = "Оплатить";
            this.btIns.UseVisualStyleBackColor = true;
            this.btIns.Click += new System.EventHandler(this.btIns_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма";
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(367, 457);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 23);
            this.btView.TabIndex = 6;
            this.btView.Text = "Выбрать";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // dtgRateClient
            // 
            this.dtgRateClient.AllowUserToAddRows = false;
            this.dtgRateClient.AllowUserToDeleteRows = false;
            this.dtgRateClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRateClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameR,
            this.horse,
            this.type,
            this.sum});
            this.dtgRateClient.Location = new System.Drawing.Point(486, 55);
            this.dtgRateClient.Name = "dtgRateClient";
            this.dtgRateClient.ReadOnly = true;
            this.dtgRateClient.Size = new System.Drawing.Size(409, 187);
            this.dtgRateClient.TabIndex = 9;
            // 
            // nameR
            // 
            this.nameR.HeaderText = "Скачки";
            this.nameR.Name = "nameR";
            this.nameR.ReadOnly = true;
            // 
            // horse
            // 
            this.horse.HeaderText = "Лошадь";
            this.horse.Name = "horse";
            this.horse.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Тип ставки";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(472, 411);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(432, 69);
            this.rtbInfo.TabIndex = 10;
            this.rtbInfo.Text = "";
            // 
            // rtbShow
            // 
            this.rtbShow.Location = new System.Drawing.Point(692, 284);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(192, 96);
            this.rtbShow.TabIndex = 11;
            this.rtbShow.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mtbSum
            // 
            this.mtbSum.Location = new System.Drawing.Point(569, 295);
            this.mtbSum.Mask = "0000000";
            this.mtbSum.Name = "mtbSum";
            this.mtbSum.Size = new System.Drawing.Size(93, 20);
            this.mtbSum.TabIndex = 12;
            this.mtbSum.ValidatingType = typeof(int);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(820, 26);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 13;
            this.btnUpd.Text = "Обновить";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // FormRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(929, 492);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.mtbSum);
            this.Controls.Add(this.rtbShow);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.dtgRateClient);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btIns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgRateCoefficient);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.cbRacing);
            this.Controls.Add(this.cbRate);
            this.Name = "FormRate";
            this.Text = "Rate";
            this.Controls.SetChildIndex(this.cbRate, 0);
            this.Controls.SetChildIndex(this.cbRacing, 0);
            this.Controls.SetChildIndex(this.btnLook, 0);
            this.Controls.SetChildIndex(this.dtgRateCoefficient, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btIns, 0);
            this.Controls.SetChildIndex(this.btView, 0);
            this.Controls.SetChildIndex(this.dtgRateClient, 0);
            this.Controls.SetChildIndex(this.rtbInfo, 0);
            this.Controls.SetChildIndex(this.rtbShow, 0);
            this.Controls.SetChildIndex(this.mtbSum, 0);
            this.Controls.SetChildIndex(this.btnUpd, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRateCoefficient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRateClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.ComboBox cbRacing;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.DataGridView dtgRateCoefficient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btIns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn k;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ch1;
        private System.Windows.Forms.DataGridView dtgRateClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameR;
        private System.Windows.Forms.DataGridViewTextBoxColumn horse;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtbSum;
        private System.Windows.Forms.Button btnUpd;
    }
}