namespace Hippodrome
{
    partial class FormOperations
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
            this.dtgOperationsReport = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnWithD = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.cbRacing = new System.Windows.Forms.ComboBox();
            this.btnUpdRacing = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.mtbAdd = new System.Windows.Forms.MaskedTextBox();
            this.mtdWithD = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperationsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOperationsReport
            // 
            this.dtgOperationsReport.AllowUserToAddRows = false;
            this.dtgOperationsReport.AllowUserToDeleteRows = false;
            this.dtgOperationsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgOperationsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOperationsReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.money});
            this.dtgOperationsReport.Location = new System.Drawing.Point(301, 73);
            this.dtgOperationsReport.Name = "dtgOperationsReport";
            this.dtgOperationsReport.ReadOnly = true;
            this.dtgOperationsReport.Size = new System.Drawing.Size(444, 332);
            this.dtgOperationsReport.TabIndex = 1;
            // 
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 82;
            // 
            // money
            // 
            this.money.HeaderText = "Сумма";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            this.money.Width = 66;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(128, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Положить деньги";
            this.btnAdd.UseCompatibleTextRendering = true;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnWithD
            // 
            this.btnWithD.Location = new System.Drawing.Point(128, 184);
            this.btnWithD.Name = "btnWithD";
            this.btnWithD.Size = new System.Drawing.Size(121, 23);
            this.btnWithD.TabIndex = 2;
            this.btnWithD.Text = "Снять деньги";
            this.btnWithD.UseVisualStyleBackColor = true;
            this.btnWithD.Click += new System.EventHandler(this.btnWithD_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(128, 83);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(121, 23);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.Text = "Баланс";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // cbRacing
            // 
            this.cbRacing.FormattingEnabled = true;
            this.cbRacing.Location = new System.Drawing.Point(78, 266);
            this.cbRacing.Name = "cbRacing";
            this.cbRacing.Size = new System.Drawing.Size(121, 21);
            this.cbRacing.TabIndex = 3;
            // 
            // btnUpdRacing
            // 
            this.btnUpdRacing.Location = new System.Drawing.Point(78, 293);
            this.btnUpdRacing.Name = "btnUpdRacing";
            this.btnUpdRacing.Size = new System.Drawing.Size(121, 84);
            this.btnUpdRacing.TabIndex = 4;
            this.btnUpdRacing.Text = "Генерация события";
            this.btnUpdRacing.UseVisualStyleBackColor = true;
            this.btnUpdRacing.Click += new System.EventHandler(this.btnUpdRacing_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(694, 30);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 5;
            this.btnUpd.Text = "Обновить";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // mtbAdd
            // 
            this.mtbAdd.Location = new System.Drawing.Point(22, 132);
            this.mtbAdd.Mask = "000000";
            this.mtbAdd.Name = "mtbAdd";
            this.mtbAdd.Size = new System.Drawing.Size(100, 20);
            this.mtbAdd.TabIndex = 6;
            this.mtbAdd.ValidatingType = typeof(int);
            // 
            // mtdWithD
            // 
            this.mtdWithD.Location = new System.Drawing.Point(22, 184);
            this.mtdWithD.Mask = "000000";
            this.mtdWithD.Name = "mtdWithD";
            this.mtdWithD.Size = new System.Drawing.Size(100, 20);
            this.mtdWithD.TabIndex = 6;
            this.mtdWithD.ValidatingType = typeof(int);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 420);
            this.Controls.Add(this.mtdWithD);
            this.Controls.Add(this.mtbAdd);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnUpdRacing);
            this.Controls.Add(this.cbRacing);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnWithD);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgOperationsReport);
            this.Name = "FormOperations";
            this.Text = "FormOperations";
            this.Controls.SetChildIndex(this.dtgOperationsReport, 0);
            this.Controls.SetChildIndex(this.btnAdd, 0);
            this.Controls.SetChildIndex(this.btnWithD, 0);
            this.Controls.SetChildIndex(this.btnBalance, 0);
            this.Controls.SetChildIndex(this.cbRacing, 0);
            this.Controls.SetChildIndex(this.btnUpdRacing, 0);
            this.Controls.SetChildIndex(this.btnUpd, 0);
            this.Controls.SetChildIndex(this.mtbAdd, 0);
            this.Controls.SetChildIndex(this.mtdWithD, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOperationsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOperationsReport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWithD;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.ComboBox cbRacing;
        private System.Windows.Forms.Button btnUpdRacing;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.MaskedTextBox mtbAdd;
        private System.Windows.Forms.MaskedTextBox mtdWithD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
    }
}