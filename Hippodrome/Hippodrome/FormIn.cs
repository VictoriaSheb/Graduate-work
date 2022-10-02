using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippodrome.Services;

namespace Hippodrome
{
    public partial class FormIn : Form
    {
        public FormIn()
        {
            InitializeComponent();
        }


        private void btnIn_Click(object sender, EventArgs e)
        {
            string error = null;
            errorProvider1.Clear();
            ClientService client = new ClientService();
            if (string.IsNullOrEmpty(tbName.Text))
            { error = "Не указано имя пользователя"; errorProvider1.SetError(tbName, error); }
            if (string.IsNullOrEmpty(tbPass.Text))
            { error = "Не указан пароль"; errorProvider1.SetError(tbPass, error); }
            if (error is null)
            {
                int result = client.ClientUpd(tbName.Text, tbPass.Text);
                string res = Convert.ToString(result) ;
                if (result <= 0)
                { error = "Не верное имя пользователя или пароль"; errorProvider1.SetError(tbName, error); }
                else
                {
                    Hide();
                    FormHorse formC = new FormHorse();
                    formC.ShowDialog();
                    this.Close();
                }
            }

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
