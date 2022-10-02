using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippodrome.Services;

namespace Hippodrome
{
    public partial class FormClientIns : Form
    {
        public FormClientIns()
        {
            InitializeComponent();
        }
 

        private void btnOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            string error = null;
            errorProvider1.Clear();
            ClientService ins = new ClientService();
            if (string.IsNullOrEmpty(tbName.Text))
            { error = "Не указано имя пользователя"; errorProvider1.SetError(tbName, error); }
            if (!tbTel.MaskCompleted)
            { error = "Не указан номер"; errorProvider1.SetError(tbTel, error); }


            if (string.IsNullOrEmpty(tbEmail.Text))
            { error = "Не указана почта"; errorProvider1.SetError(tbEmail, error); }
            else
            {
                if ((!tbEmail.Text.Contains('@')) || (!tbEmail.Text.Contains('.')))
                { error = "Не верно указана почта"; errorProvider1.SetError(tbEmail, error); }
            }

            if ((string.IsNullOrEmpty(tbPass.Text)) || (tbPass.Text != tbPass2.Text))
            {
                tbPass.Clear();
                tbPass2.Clear();
                error = "Не верно указан пароль"; errorProvider1.SetError(tbPass, error);
            }

            if (error is null)
            {
                ins.ClientIns(tbName.Text, tbTel.Text, tbEmail.Text, tbPass.Text);
                Close();
            }


        }
    }
}
