using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hippodrome.Services;

namespace Hippodrome.Tables
{
    class RateService  : Service
    {
        public int typeR { get; set; }

        public DataTable RateLook(int type, int racing)
        {
            string guery = "";
            switch (type)
            {
                //победитель
                case 1:
                    guery = (@"SELECT     Коэффициент.Номер, Лошадь.Имя, Коэффициент.Победитель
                FROM Коэффициент INNER JOIN
                     [Участники скачек] ON Коэффициент.Номер = [Участники скачек].Номер INNER JOIN
                      Лошадь ON[Участники скачек].Лошадь = Лошадь.[Чип-номер]
                       WHERE [Участники скачек].Скачки=@racing");
                    break;
                //Не первая
                case 2:
                    guery = (@" SELECT  Коэффициент.Номер, Лошадь.Имя, Коэффициент.[Не призер]
                      FROM Коэффициент INNER JOIN
                      [Участники скачек] ON Коэффициент.Номер = [Участники скачек].Номер INNER JOIN
                      Лошадь ON [Участники скачек].Лошадь = Лошадь.[Чип-номер]
                      WHERE [Участники скачек].Скачки=@racing");
                    break;
                //Призовое место
                case 3:
                    guery = (@"SELECT Коэффициент.Номер, Лошадь.Имя, Коэффициент.Призер
                      FROM  Коэффициент INNER JOIN
                      [Участники скачек] ON Коэффициент.Номер = [Участники скачек].Номер INNER JOIN
                      Лошадь ON [Участники скачек].Лошадь = Лошадь.[Чип-номер]
                      WHERE [Участники скачек].Скачки=@racing");
                    break;
                //Победитель и призер
                case 4:
                    guery = (@" SELECT Коэффициент.Номер, Лошадь.Имя , Коэффициент.[Победитель+], Коэффициент.[Призер+] 
                      FROM  Коэффициент INNER JOIN
                      [Участники скачек] ON Коэффициент.Номер = [Участники скачек].Номер INNER JOIN
                      Лошадь ON [Участники скачек].Лошадь = Лошадь.[Чип-номер]
                      WHERE [Участники скачек].Скачки=@racing");
                    break;
                //3 победителя
                default:
                    guery = (@"SELECT Коэффициент.Номер, Лошадь.Имя , Коэффициент.Победители
                      FROM Коэффициент INNER JOIN
                      [Участники скачек] ON Коэффициент.Номер = [Участники скачек].Номер INNER JOIN
                      Лошадь ON [Участники скачек].Лошадь = Лошадь.[Чип-номер]
                      WHERE [Участники скачек].Скачки=@racing");
                    break;

            }
    
           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd_SQL = new SqlCommand(guery, connection);
            cmd_SQL.Parameters.Add("@racing", SqlDbType.Int).Value = racing;
      
            cmd_SQL.ExecuteNonQuery();
            DataTable rate = new DataTable();
            SqlDataAdapter bd = new SqlDataAdapter(cmd_SQL);
            bd.Fill(rate);
            connection.Close();

        
            return rate;
            

        }
        public void InsRate( int racing, decimal money, string horse, int type)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ins_rate";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@klient", SqlDbType.Int).Value = Client.Id;
            cmd.Parameters.Add("@racing", SqlDbType.Int).Value = racing;
            cmd.Parameters.Add("@money", SqlDbType.Money).Value = money;
            cmd.Parameters.Add("@horse", SqlDbType.NChar, 10).Value = horse;
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            cmd.ExecuteNonQuery();
            connection.Close();


        }

        public void RateInfo( RichTextBox info, int rate )
        {
            
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string guery = @"SELECT Описание FROM [Тип ставки] WHERE  Номер =@id";
            SqlCommand cmd_SQL = new SqlCommand(guery, connection);
            cmd_SQL.Parameters.Add("@id", SqlDbType.Int).Value = rate;

            SqlDataReader rdr_SQL = cmd_SQL.ExecuteReader();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            while (rdr_SQL.Read())
            {
                string text = rdr_SQL.GetString(0);

                info.Text = text;
            }

            rdr_SQL.Close();

            connection.Close();
        }

        public void RateCoefficientLook(DataGridView table, int racing, int rate)
        {
            table.Rows.Clear();
            while ((table.Columns.Count) != 4)
            { table.Columns.Remove(table.Columns[(table.Columns.Count - 1)]); }
            table.Columns[1].HeaderText = "Победитель";
            DataTable tableRate = RateLook(rate, racing);
            DataTableReader rdr = tableRate.CreateDataReader();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            if (rate == 4)
            {
                table.Columns[1].HeaderText = "Победитель";

                DataGridViewTextBoxColumn columnH2 = new DataGridViewTextBoxColumn();
                columnH2.HeaderText = "Призер";
                columnH2.Name = "name2";
                columnH2.ReadOnly = true;
                table.Columns.Add(columnH2);


                DataGridViewTextBoxColumn columnk2 = new DataGridViewTextBoxColumn();
                columnk2.HeaderText = "Коэффициент";
                columnk2.Name = "k2";
                columnk2.ReadOnly = true;
                table.Columns.Add(columnk2);

                DataGridViewCheckBoxColumn column2 = new DataGridViewCheckBoxColumn();
                column2.HeaderText = "";
                column2.Name = "ch2";
                table.Columns.Add(column2);
                while (rdr.Read())
                {
                    int id = rdr.GetInt32(0);
                    string name = rdr.GetString(1);
                    decimal k = rdr.GetDecimal(2);
                    bool ch1 = false;
                    decimal k2 = rdr.GetDecimal(3);
                    bool ch2 = false;
                    table.Rows.Add(id, name, k, ch1, name, k2, ch2);

                }
            }
            else
            {
                if (rate == 1) table.Columns[1].HeaderText = "Победитель";
                if (rate == 2) table.Columns[1].HeaderText = "Не первая";
                if (rate == 3) table.Columns[1].HeaderText = "Призер";
                if (rate == 5) table.Columns[1].HeaderText = "Финалисты";
                while (rdr.Read())
                {
                    int id = rdr.GetInt32(0);
                    string name = rdr.GetString(1);
                    decimal k = rdr.GetDecimal(2);
                    bool сh1 = false;
                    table.Rows.Add(id, name, k, сh1);

                }
            }
            rdr.Close();
        }

        public void RateClientLook(DataGridView table)
        {
            table.Rows.Clear();
            
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string guery = @"SELECT   [Расписание скачек].[Название скачек],  [Тип ставки].Название, Лошадь.Имя, Ставка.Сумма, Ставка.Состояние
                      FROM         Ставка INNER JOIN
                      [Тип ставки] ON Ставка.[Вид ставки] = [Тип ставки].Номер INNER JOIN
                      [Участники скачек] ON Ставка.Лошадь = [Участники скачек].Номер INNER JOIN
                      Лошадь ON [Участники скачек].Лошадь = Лошадь.[Чип-номер] INNER JOIN
                      [Расписание скачек] ON [Участники скачек].Скачки = [Расписание скачек].Номер
                      WHERE     Ставка.Клиент =@id";
            SqlCommand cmd_SQL = new SqlCommand(guery, connection);
            cmd_SQL.Parameters.Add("@id", SqlDbType.Int).Value = Client.Id;

            SqlDataReader rdr_SQL = cmd_SQL.ExecuteReader();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            int status = 2;
            while (rdr_SQL.Read())
            {
                string nameR = rdr_SQL.GetString(0);
                string type = rdr_SQL.GetString(1);
                string horse = rdr_SQL.GetString(2);
                decimal sum = rdr_SQL.GetDecimal(3);
                try { status = rdr_SQL.GetInt16(4); }
                catch { status = 2; }
                table.Rows.Add(nameR, horse, type, sum);
                if (status == 0)
                {
                    table.Rows[table.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Tomato; 
                }
                if (status == 1)
                {
                    table.Rows[table.Rows.Count - 1].DefaultCellStyle.BackColor = Color.YellowGreen; ;
                }
            }

            rdr_SQL.Close();
            connection.Close();
        }



















































    }
}
