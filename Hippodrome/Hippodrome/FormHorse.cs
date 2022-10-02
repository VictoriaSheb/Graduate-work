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
using Hippodrome.Tables;

namespace Hippodrome
{
    public partial class FormHorse :  FormMainClient
    {


        public FormHorse()
        {
            InitializeComponent();
            HorseService horse = new HorseService();
            horse.HorsesLook(dgvHorses);
            cbBreed_Load();
            cbGender_Load();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HorseService horse = new HorseService();
            string error = null;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(tbName.Text))
            { error = "Не указано имя"; errorProvider1.SetError(tbName, error); }
            if (string.IsNullOrEmpty(tbId.Text))
            { error = "Не указан Чип-номер"; errorProvider1.SetError(tbId, error); }

            if (string.IsNullOrEmpty(Convert.ToString(cbBreed.SelectedValue)))
            { error = "Не указана порода"; errorProvider1.SetError(cbBreed, error); }

            if (string.IsNullOrEmpty(cbGender.Text))
            { error = "Не указан пол"; errorProvider1.SetError(cbGender, error); }
            if (string.IsNullOrEmpty(nudAge.Text))
            { error = "Не указан возраст"; errorProvider1.SetError(nudAge, error); }
            
            if ((dtpIn.Value) <= DateTime.Now)
            { error = "Не верно указана дата"; errorProvider1.SetError(dtpIn, error); }

            if ((dtpOut.Value) <= DateTime.Now)
            { error = "Не верно указана дата"; errorProvider1.SetError(dtpOut, error); }

            if (error is null)
            { horse.HorseIns(tbId.Text, tbName.Text, tbF.Text, tbM.Text, Convert.ToString(cbBreed.SelectedValue), cbGender.Text, Convert.ToInt16(nudAge.Value),
             dtpIn.Value, dtpOut.Value); }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            dgvHorses.Rows.Clear();
            HorseService horse = new HorseService();
            horse.HorsesLook(dgvHorses);
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            HorseService horse = new HorseService();
            bool del = false;
            foreach (DataGridViewRow Row in dgvHorses.Rows)
            {
                if (object.Equals(Row.Cells["Chk"].Value, true))
                {
                    Row.Cells["Chk"].Value = true;
                    horse.HorseDlt(Convert.ToString(Row.Cells["id"].Value));
                    del = true;
                }
            }
            if (!string.IsNullOrEmpty(tbId.Text))
            {
                horse.HorseDlt(tbId.Text);
                tbId.Clear();
                del = true;
            }
            if (del == false)
            { errorProvider1.SetError(tbId, "Нечего удалять, укажите чип-номер или выберите лошадей из таблицы"); }
        }

        
        private void cbBreed_Load()
        {
            HorseService horse = new HorseService();
            horse.ComboxIns(cbBreed, (@"SELECT Номер, Название FROM Порода WHERE Номер<>10"), "Название", "Номер");
        }

        private void cbGender_Load()
        {
            cbGender.Items.Add("кобыла");
            cbGender.Items.Add("жеребец");
            cbGender.Items.Add("мерин");
        }

    }
}
