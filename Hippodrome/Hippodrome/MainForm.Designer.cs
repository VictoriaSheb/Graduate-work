namespace Hippodrome
{
    partial class MainForm
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
            this.btnOut = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(49, 166);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(141, 30);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Выход";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(53, 105);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(141, 30);
            this.btnBD.TabIndex = 2;
            this.btnBD.Text = "Регистрация";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(53, 46);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(141, 30);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "Вход";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 240);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btnOut);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnIn;
    }
}

