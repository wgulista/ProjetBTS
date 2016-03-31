using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ConnexionDll
{
    public class ConnexionSql
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public ConnexionSql()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            server = "";
            database = "";
            uid = "";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return (connection);
        }

        //open connection to database
        public void OpenConnection()
        {
            connection.Open();
        }

        //Close connection
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
