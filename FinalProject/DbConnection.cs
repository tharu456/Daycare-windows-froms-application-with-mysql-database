using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class DbConnection
    {
            public static MySqlConnection MySqlServerConnection()
            {
                String connection_string = @"server=localhost;user id=root;database=daycaremanagementsystem";
                MySqlConnection connection = new MySqlConnection(connection_string);
                return connection;
            }
        
    }
}
