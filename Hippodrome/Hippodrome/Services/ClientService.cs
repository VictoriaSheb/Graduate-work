using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Hippodrome.Tables;
using System.Windows.Forms;

namespace Hippodrome.Services
{
    class ClientService : Service
    {
        Client client;
        public void ClientIns(string name, string tel, string email, string pass)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ins_klient";
            cmd.Parameters.Add("@fio", SqlDbType.NChar, 60).Value = name;
            cmd.Parameters.Add("@telephone", SqlDbType.NChar, 15).Value = tel;
            cmd.Parameters.Add("@email", SqlDbType.NChar, 30).Value = email;
            cmd.Parameters.Add("@password", SqlDbType.NChar, 20).Value = pass;
            cmd.ExecuteNonQuery();
            this.client = new Client(name, tel, email, pass);
            connection.Close();
        }


        public int ClientUpd(string name, string pass)
        {
           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "upd_klient";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
                cmd.Parameters.Add("@fio", SqlDbType.NChar, 60).Value = name;
                cmd.Parameters.Add("@password", SqlDbType.NChar, 20).Value = pass;
                int str = cmd.ExecuteNonQuery();
            if (str > 0)
            ClientIdentity(name,  pass);
            connection.Close();
            return str;
        }

        public void ClientIdentity(string name, string pass)
        {
            Client.Name = name;
            Client.Password = pass;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Номер, [Номер телефона], Email, Баланс FROM Клиент WHERE ФИО=@name and Пароль=@pass";
            cmd.Parameters.Add("@name", SqlDbType.NChar, 60).Value = name;
            cmd.Parameters.Add("@pass", SqlDbType.NChar, 20).Value = pass;

            SqlDataReader rdr_SQL = cmd.ExecuteReader();
            while (rdr_SQL.Read())
            {
                Client.Id = rdr_SQL.GetInt32(0);
                Client.Telephone = rdr_SQL.GetString(1);
                Client.Email = rdr_SQL.GetString(2);
                Client.Money = rdr_SQL.GetDecimal(3);
            }
            rdr_SQL.Close();
            connection.Close();

        }


        public void ClientBalance()
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "balance_klient";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Client.Id;
            int str = cmd.ExecuteNonQuery();

        }

        public void ClientAdd(decimal money)
        {
           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "add_money_klient";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Client.Id;
            cmd.Parameters.Add("@money", SqlDbType.Money).Value = money;
            int str = cmd.ExecuteNonQuery();

        }

        public void ClientWithD(decimal money)
        {
           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "withdray_money_klient";
            connection.InfoMessage += delegate (object sender, SqlInfoMessageEventArgs e)
            { MessageBox.Show(Convert.ToString(e.Message)); };
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Client.Id;
            cmd.Parameters.Add("@money", SqlDbType.Money).Value = money;
            int str = cmd.ExecuteNonQuery();

        }

        public void ClientOperationsReport(DataGridView table)
        {
            table.Rows.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string guery = @"SELECT  Описание, Сумма FROM [Денежные операции]  WHERE Клиент =@id";
            SqlCommand cmd_SQL = new SqlCommand(guery, connection);
            cmd_SQL.Parameters.Add("@id", SqlDbType.Int).Value = Client.Id;
            SqlDataReader rdr_SQL = cmd_SQL.ExecuteReader();
            while (rdr_SQL.Read())
            {
                string description = rdr_SQL.GetString(0);
                decimal money = rdr_SQL.GetDecimal(1);
                table.Rows.Add(description, money);
            }

            rdr_SQL.Close();
            connection.Close();
        }


    }
}
