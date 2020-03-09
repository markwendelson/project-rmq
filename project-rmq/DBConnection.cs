using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace project_rmq
{
    public class DBConnection
    {
        public string db_server { get; set; }
        public string db_host { get; set; }
        public string db_name { get; set; }
        public string db_user { get; set; }
        public string db_password { get; set; }
        public int db_port { get; set; }

        public MySqlConnection MySqlConnect()
        {
            MySqlConnection cn = new MySqlConnection();
                
            cn.ConnectionString = "Server=" + db_host + ";" +
                "Port=" + db_port + ";" +
                "Database=" + db_name + ";" +
                "Uid=" + db_user + ";" +
                "Pwd=" + db_password + ";";
                        
            return cn;
        }

        public SqlConnection SqlConnect()
        {
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Server=" + db_host + "," + db_port + ";" +
                "Database=" + db_name + ";" +
                "User Id=" + db_user + ";" +
                "Password=" + db_password + ";";
            

            return cn;
        }
    }


}
