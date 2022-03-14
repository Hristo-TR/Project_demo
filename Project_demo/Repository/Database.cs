using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project_demo.Repository
{
    internal class Database
    {
        static String dbInfo = "server=localhost;userid=root;password=;database=project_demo";
        public static MySqlConnection GetConnection()
        {
            MySqlConnection db = new MySqlConnection(dbInfo);
            return db;
        }
    }
}
