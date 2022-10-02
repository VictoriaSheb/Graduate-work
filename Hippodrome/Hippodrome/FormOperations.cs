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
    public partial class FormOperations : FormMainClient
    {
        public FormOperations()
        {
            InitializeComponent();
            cbRacing_Load();
            dtgOperationsReport_Load();
        }



        private void cbRacing_Load()
        {
            string guery = (@"SELECT Номер, [Название скачек] FROM [Расписание скачек] 
            WHERE  not exists (SELECT Скачки FROM Ставка INNER JOIN [Участники скачек]  ON 
            Ставка.Лошадь=[Участники скачек].Номер
            WHERE (Место is not null) and [Расписание скачек].Номер=Скачки )
            and 
            (([Расписание скачек].[Количество участников])=
            (SELECT COUNT(Номер) FROM [Участники скачек] WHERE Скачки=[Расписание скачек].Номер )) ");

            RateService rate = new RateService();
            rate.ComboxIns(cbRacing, guery, "Название скачек", "Номер");
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            ClientService client = new ClientService();
            client.ClientBalance();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string error = null;
            ClientService client = new ClientService();
            try
            {
                Convert.ToInt32(mtbAdd.Text);
               
            }

            catch { error = "Введите сумму";  errorProvider1.SetError(mtbAdd, error); }

            if (error is null)
            { client.ClientAdd(Convert.ToDecimal(mtbAdd.Text)); }

            
        }

        private void btnWithD_Click(object sender, EventArgs e)
        {
            ClientService client = new ClientService();

            string error = null;
            try
            {
                Convert.ToInt32(mtdWithD.Text);
                
            }
            catch { error = "Введите сумму";  errorProvider1.SetError(mtdWithD, error); }
            if (error is null)
            { client.ClientWithD(Convert.ToDecimal(mtdWithD.Text)); }
        }

        private void btnUpdRacing_Click(object sender, EventArgs e)
        {
            HorseService racing = new HorseService();
            racing.HorseUpdRacing(Convert.ToInt32(cbRacing.SelectedValue));
        }

        private void dtgOperationsReport_Load()
        {
            ClientService client = new ClientService();
            client.ClientOperationsReport(dtgOperationsReport);
        }


        private void btnUpd_Click(object sender, EventArgs e)
        {    
            dtgOperationsReport.Rows.Clear();
            dtgOperationsReport_Load();
        }
    }
}
