using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hippodrome
{
    public partial class FormMainClient : Form
    {
        public FormMainClient()
        {
            InitializeComponent();
        }
        
        private void скачкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormRacing racing = new FormRacing();
            racing.ShowDialog();
            this.Close();

        }

        private void ставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormRate rate = new FormRate();
            rate.ShowDialog();
            this.Close();
        }

        private void лошадиToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Hide();
            FormHorse formC = new FormHorse();
             formC.ShowDialog();
             this.Close();
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormOperations formO = new FormOperations();
            formO.ShowDialog();
            this.Close();
        }
    }
}
