using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSupport
{
    class DBDevice
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBDevice()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "esupport";
            uid = "root";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connected");
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        break;

                    case 1045:
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

       
        public Boolean  isGuarantee(string deviceId)
        {
            Boolean isGuarant = false;
            string query = "SELECT guarantee FROM device_table where deviceId = '"+deviceId+"'";
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string gr = rdr["guarantee"].ToString();
                    if (gr == "1")
                        isGuarant = true;
                }
                this.CloseConnection();
                return isGuarant;
            }
            else
            {
                return isGuarant;
            }
        }
        //Count statement
        public int Count(string name, string email, string password)
        {
            string query = "SELECT Count(*) FROM admintable where name= '" + name + "' AND email='" + email + "' AND password='" + password + "'";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public int Count(string name)
        {
            string query = "SELECT Count(*) FROM department_table where department_name= '" + name + "'";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
        //Update statement
        public void Update()
        {
        }

        //Delete statement
      
        

    }
}
