using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippodrome.Tables;

namespace Hippodrome.Services
{
    class HorseService : Service
    {
       
        public void HorseIns(  string id, string name , string father, string mother ,string breed , string gender ,int age ,
                                                        DateTime dateIn , DateTime dateOut)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ins_horse";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@klient", SqlDbType.Int).Value = Client.Id  ;
            cmd.Parameters.Add("@chip", SqlDbType.NChar, 10).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NChar, 10).Value = name;
            cmd.Parameters.Add("@chipF", SqlDbType.NChar, 10).Value = father;
            cmd.Parameters.Add("@chipM", SqlDbType.NChar, 10).Value = mother;
            cmd.Parameters.Add("@breed", SqlDbType.SmallInt, 10).Value = breed;
            cmd.Parameters.Add("@gender", SqlDbType.NChar, 10).Value = gender;
            cmd.Parameters.Add("@age", SqlDbType.SmallInt, 10).Value = age;
            cmd.Parameters.Add("@target", SqlDbType.SmallInt, 10).Value = 0;
            cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = dateIn;
            cmd.Parameters.Add("@endDate", SqlDbType.Date).Value =dateOut;
            MessageBox.Show(father);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void HorseDlt(string id)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dlt_horse";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@horse", SqlDbType.NChar, 10).Value = id;
            cmd.Parameters.Add("@klient", SqlDbType.Int).Value = Client.Id;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void HorseAvR(string id)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "available_racing";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@horse", SqlDbType.NChar, 10).Value = id;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void HorseUpdData(string id, DateTime dateIn, DateTime dateOut)
        {
           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "upd_date_horse";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@klient", SqlDbType.Int).Value = Client.Id;
            cmd.Parameters.Add("@horse", SqlDbType.NChar, 10).Value = id;
            cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = dateIn;
            cmd.Parameters.Add("@endDate", SqlDbType.Date).Value = dateOut;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void HorseInsRacing(string horse, int id)
        {
           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ins_racing";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@racing", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@horse", SqlDbType.NChar, 10).Value = horse;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void HorseDltRacing(string horse, int id)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dlt_rating";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@racing", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@horse", SqlDbType.NChar, 10).Value = horse;
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        public void HorseUpdRacing(int racing)
        {
           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "upd_racing";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@racing", SqlDbType.Int).Value = racing;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void HorsesLook(DataGridView table)
        {
           
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string guery = @"SELECT [Чип-номер], Имя, (select Имя From Лошадь  WHERE [Чип-номер]=(SELECT Отец From Лошадь WHERE Отец=any(SELECT [Чип-номер] From Лошадь))), 
		                Мать, Порода.Название, Пол, Возраст, [Дата прибытия], [Дата отъезда]   
                        FROM  Лошадь INNER JOIN
                        Порода ON Лошадь.Порода = Порода.Номер    WHERE Клиент=@id and Отец is not null and Мать is  null  
                        UNION
                        SELECT [Чип-номер], Имя, Отец ,Мать, 
                        Порода.Название, Пол, Возраст, [Дата прибытия], [Дата отъезда]   
                        FROM  Лошадь INNER JOIN
                        Порода ON Лошадь.Порода = Порода.Номер WHERE Клиент=@id and Отец is  null and Мать is  null                      
                        UNION
                        SELECT [Чип-номер], Имя, Отец, (select Имя From Лошадь  WHERE [Чип-номер]=(SELECT Мать From Лошадь WHERE Мать=any(SELECT [Чип-номер] From Лошадь)))
		                , Порода.Название, Пол, Возраст, [Дата прибытия], [Дата отъезда]   
                        FROM  Лошадь INNER JOIN
                        Порода ON Лошадь.Порода = Порода.Номер    WHERE Клиент=@id and Отец is  null and Мать is not null
                        UNION
                        SELECT [Чип-номер], Имя, (select Имя From Лошадь  WHERE [Чип-номер]=(SELECT Отец From Лошадь WHERE Отец=any(SELECT [Чип-номер] From Лошадь))), (select Имя From Лошадь  WHERE [Чип-номер]=(SELECT Мать From Лошадь WHERE Мать=any(SELECT [Чип-номер] From Лошадь)))
		                , Порода.Название, Пол, Возраст, [Дата прибытия], [Дата отъезда]   
                        FROM  Лошадь INNER JOIN
                        Порода ON Лошадь.Порода = Порода.Номер    WHERE Клиент=@id and Отец is not null and Мать is not null";
            SqlCommand cmd_SQL = new SqlCommand(guery, connection);
            cmd_SQL.Parameters.Add("@id", SqlDbType.Int).Value = Client.Id;

            SqlDataReader rdr_SQL = cmd_SQL.ExecuteReader();
            string mother = "-";
            string father = "-";
            string dateIn = "-";
            string dateOut = "-";
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

            while (rdr_SQL.Read())
            {
                string id = rdr_SQL.GetString(0);
                string name = rdr_SQL.GetString(1);
                try { father = rdr_SQL.GetString(2); } catch { father = "-"; }
                try { mother = rdr_SQL.GetString(3); } catch { mother = "-"; }
                string breed = rdr_SQL.GetString(4);
                string gender = rdr_SQL.GetString(5);
                int age = rdr_SQL.GetInt16(6);

                try { dateIn = (rdr_SQL.GetDateTime(7)).ToString("dd-MM-yyyy"); } catch { dateIn = "-"; }
                try { dateOut = (rdr_SQL.GetDateTime(8)).ToString("dd-MM-yyyy"); } catch { dateOut = "-"; }
                bool Chk = false;
                table.Rows.Add(id, name, father, mother, breed, gender, age, dateIn, dateOut, Chk);

            }
        }


        public void AvailableRacingLook(DataGridView table, string horse)
        {
            table.Rows.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "available_racing";

            cmd.Parameters.Add("@horse", SqlDbType.NChar, 10).Value = horse;

            cmd.ExecuteNonQuery();
            SqlDataReader rdr_SQL = cmd.ExecuteReader();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

            while (rdr_SQL.Read())
            {
                int id = rdr_SQL.GetInt32(0);
                string typeR = rdr_SQL.GetString(1);
                string gender = rdr_SQL.GetString(2);
                string date = (rdr_SQL.GetDateTime(3)).ToString("dd-MM-yyyy");
                TimeSpan time = (rdr_SQL.GetTimeSpan(4));
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


      

    }
}
