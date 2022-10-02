using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Hippodrome.Tables
{
    class Client
    {
        
        public static string Name { get; set; }
        public static string Telephone { get; set; }
        public static string Email { get; set; }
        public static decimal Money { get; set; }
        public static string Password { get; set; }
        public static int Id { get; set; }

        public Client(string name, string tel, string email, string pass)
        {
            Name = name;
            Telephone = tel;
            Email = email;
            Password = pass;
            Money = 0;
        }
        
      
    }
}
