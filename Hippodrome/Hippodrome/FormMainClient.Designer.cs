namespace Hippodrome
{
    partial class FormMainClient
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.лошадиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скачкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лошадиToolStripMenuItem,
            this.скачкиToolStripMenuItem,
            this.ставкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // лошадиToolStripMenuItem
            // 
            this.лошадиToolStripMenuItem.Name = "лошадиToolStripMenuItem";
            this.лошадиToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.лошадиToolStripMenuItem.Text = "Лошади";
            this.лошадиToolStripMenuItem.Click += new System.EventHandler(this.лошадиToolStripMenuItem_Click);
            // 
            // скачкиToolStripMenuItem
            // 
            this.скачкиToolStripMenuItem.Name = "скачкиToolStripMenuItem";
            this.скачкиToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.скачкиToolStripMenuItem.Text = "Скачки";
            this.скачкиToolStripMenuItem.Click += new System.EventHandler(this.скачкиToolStripMenuItem_Click);
            // 
            // ставкиToolStripMenuItem
            // 
            this.ставкиToolStripMenuItem.Name = "ставкиToolStripMenuItem";
            this.ставкиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ставкиToolStripMenuItem.Text = "Ставки";
            this.ставкиToolStripMenuItem.Click += new System.EventHandler(this.ставкиToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.параметрыToolStripMenuItem.Text = "Операции";
            this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
            // 
            // FormMainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainClient";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem скачкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лошадиToolStripMenuItem;
    }
}