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
    class Service
    {
        public static string connectionString
        { get  => connectionString;
           set => connectionString = ConfigurationManager.ConnectionStrings ["IConnectionString"].ConnectionString; }

      


        public void ComboxIns(ComboBox box, string guery, string text, string value)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd_SQL = new SqlCommand(guery, connection);
            cmd_SQL.Parameters.Add("@id", SqlDbType.Int).Value = Client.Id;
            connection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter bd = new SqlDataAdapter(cmd_SQL);
            try   {  bd.Fill(table);  }
            catch {  cmd_SQL.Parameters.Clear();   }
            box.DataSource = table;
            box.DisplayMember = text;
            box.ValueMember = value;
            connection.Close();

        }



    }
}
