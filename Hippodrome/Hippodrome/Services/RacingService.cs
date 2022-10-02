using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippodrome.Services;

namespace Hippodrome.Tables
{
    class RacingService : Service
    {
        public void RacingLook(DataGridView table)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string guery = @"SELECT     [Расписание скачек].Номер, [Расписание скачек].Дата, [Расписание скачек].Время, [Тип скачек].Название, [Расписание скачек].Пол, Порода.Название AS Порода, 
                      [Расписание скачек].Возраст, [Расписание скачек].[Название скачек], [Расписание скачек].[Призовой фонд], [Расписание скачек].[Количество участников]
                      FROM         [Расписание скачек] INNER JOIN
                      Порода ON [Расписание скачек].Порода = Порода.Номер INNER JOIN
                      [Тип скачек] ON [Расписание скачек].[Тип дистанции] = [Тип скачек].Номер";
            SqlCommand cmd_SQL = new SqlCommand(guery, connection);

            SqlDataReader rdr_SQL = cmd_SQL.ExecuteReader();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

            while (rdr_SQL.Read())
            {
                int id = rdr_SQL.GetInt32(0);
                string date = (rdr_SQL.GetDateTime(1)).ToString("dd-MM-yyyy");
                TimeSpan time = (rdr_SQL.GetTimeSpan(2));
                string typeR = rdr_SQL.GetString(3);
                string gender = rdr_SQL.GetString(4);
                string breed = rdr_SQL.GetString(5);
                int age = rdr_SQL.GetInt16(6);
                string name = rdr_SQL.GetString(7);
                decimal money = rdr_SQL.GetDecimal(8);
                int count = rdr_SQL.GetInt16(9);
                bool Chk = false;
                table.Rows.Add(id, name, typeR, gender, breed, age, date, time, money, count, Chk);
            }

            rdr_SQL.Close();

            connection.Close();

        }

        public void RacingHorseLook(DataGridView table, int racing)
        {
          
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string guery = @"SELECT     [Участники скачек].Номер, [Расписание скачек].[Название скачек], Лошадь.Имя, Персонал.ФИО, Место
                      FROM         [Участники скачек] INNER JOIN
                      [Расписание скачек] ON [Участники скачек].Скачки = [Расписание скачек].Номер INNER JOIN
                      Персонал ON [Участники скачек].Жокей = Персонал.Номер INNER JOIN
                      Лошадь ON [Участники скачек].Лошадь = Лошадь.[Чип-номер] WHERE [Расписание скачек].Номер=@id";
            SqlCommand cmd_SQL = new SqlCommand(guery, connection);
            cmd_SQL.Parameters.Add("@id", SqlDbType.Int).Value = racing;
            SqlDataReader rdr_SQL = cmd_SQL.ExecuteReader();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            string place2 = "-";
            while (rdr_SQL.Read())
            {
                int id2 = rdr_SQL.GetInt32(0);
                string racing2 = rdr_SQL.GetString(1);
                string horse2 = rdr_SQL.GetString(2);
                string jockey2 = rdr_SQL.GetString(3);
                try { place2 = Convert.ToString(rdr_SQL.GetInt32(4)); }
                catch { }
                table.Rows.Add(id2, racing2, horse2, jockey2, place2);

            }
        }

        public void RacingForRateLook(ComboBox boxRacing)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string guery = (@"SELECT Номер, [Название скачек] FROM [Расписание скачек] 
            WHERE  not exists (SELECT Скачки FROM Ставка INNER JOIN [Участники скачек]  ON 
            Ставка.Лошадь=[Участники скачек].Номер
            WHERE (Клиент=@id or (Место is not null)) and [Расписание скачек].Номер=Скачки )
            and 
            (([Расписание скачек].[Количество участников])=
            (SELECT COUNT(Номер) FROM [Участники скачек] WHERE Скачки=[Расписание скачек].Номер )) ");

            SqlCommand cmd_SQL = new SqlCommand(guery, connection);
            cmd_SQL.Parameters.Add("@id", SqlDbType.Int).Value = Client.Id;
            DataTable racing = new DataTable();
            SqlDataAdapter bd = new SqlDataAdapter(cmd_SQL);
            bd.Fill(racing);
            boxRacing.DataSource = racing;
            boxRacing.DisplayMember = "Название скачек";
            boxRacing.ValueMember = "Номер";
            connection.Close();

        }






    }

}



