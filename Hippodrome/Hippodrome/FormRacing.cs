using System;
using System.CodeDom.Compiler;
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
    public partial class FormRacing : FormMainClient
    {
        public FormRacing()
        {
            InitializeComponent();
            RacingService racing = new RacingService();
            racing.RacingLook(dgvRacing);
            cbHorse_Load();
        }




        private void cbHorse_Load()
        {
            HorseService horse = new HorseService();
            horse.ComboxIns(cbHorse, (@"SELECT [Чип-номер], Имя FROM Лошадь WHERE Клиент=@id"), "Имя", "Чип-номер");
        }
        



        private void btnSee_Click(object sender, EventArgs e)
        {
            dgvHorseInRacing.Rows.Clear();
            RacingService racing = new RacingService();
            foreach (DataGridViewRow Row in dgvRacing.Rows)
            {
                if (object.Equals(Row.Cells["Chk"].Value, true))
                {
                    Row.Cells["Chk"].Value = true;
                    racing.RacingHorseLook(dgvHorseInRacing, (Convert.ToInt32(Row.Cells["id"].Value)));
                }
            }
        }

        


        private void btnHorse_Click(object sender, EventArgs e)
        {
            HorseService horse = new HorseService();
            horse.AvailableRacingLook(dgvRacing, Convert.ToString(cbHorse.SelectedValue));
        }





        private void btnUpdRacing_Click(object sender, EventArgs e)
        {
            dgvRacing.Rows.Clear();
            RacingService racing = new RacingService();
            racing.RacingLook(dgvRacing);
        }




        private void btnUpdDate_Click(object sender, EventArgs e)
        {
            if ((dtIn.Value > DateTime.Now) && (dtOut.Value > DateTime.Now))
            {
                HorseService horse = new HorseService();
                horse.HorseUpdData(Convert.ToString(cbHorse.SelectedValue), dtIn.Value, dtOut.Value);
            }
            else { MessageBox.Show("Не допустимая дата"); }
        }





        private void btnRacingIns_Click(object sender, EventArgs e)
        {
            HorseService horse = new HorseService();
            foreach (DataGridViewRow Row in dgvRacing.Rows)
            {
                if (object.Equals(Row.Cells["Chk"].Value, true))
                {
                    Row.Cells["Chk"].Value = true;
                     horse.HorseInsRacing(Convert.ToString(cbHorse.SelectedValue),(Convert.ToInt32(Row.Cells["id"].Value)));
                }
            }
        }




        private void btnDlt_Click(object sender, EventArgs e)
        {
            HorseService horse = new HorseService();
            foreach (DataGridViewRow Row in dgvRacing.Rows)
            {
                if (object.Equals(Row.Cells["Chk"].Value, true))
                {
                    Row.Cells["Chk"].Value = true;
                    horse.HorseDltRacing(Convert.ToString(cbHorse.SelectedValue), (Convert.ToInt32(Row.Cells["id"].Value)));
                }
            }
        }
    }
}
