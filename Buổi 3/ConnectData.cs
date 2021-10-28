using System;
using MySql.Data.MySqlClient;

namespace MyConnection
{   
    public class ConnectData
    {
        public static MySqlConnection GetConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "QuanLyBanHang";
            string username = "root";
            string password = "";


            String connString = "Server=" + host + ";Database=" + database
                    + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
