using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MycloudStoreApp1
{
    class DBConnection
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public DBConnection()
        {
            Initialize();

        }
        public void Initialize()
        {
            server = "localhost";
            database = "zastitaDatabase";
            uid = "root";
            password = "";
            string conncetionString;
            conncetionString = "SERVER=" + server + ";"  + "DATABASE=" + database + ";" + "UID=" + uid
                + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(conncetionString);

        }
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.Write("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }


        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }
    }
}
