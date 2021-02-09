using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DBHandler
{
    public class DBDeviceList
    {


        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBDeviceList()
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
            connection.Close();
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

        //Insert Client to DB
        

        public DeviceListModel returnDevice(string deviceId)
        {
            DeviceListModel deviceListToReturn = new DeviceListModel();
            string query = "SELECT * FROM device_table where deviceId= '" + deviceId + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Boolean bo = false;
                    if(rdr["guarantee"].ToString() == "1")
                    {
                        bo = true;
                    }
                    DeviceListModel deviceListModel = new DeviceListModel
                    {
                        DeviceId = rdr["deviceId"].ToString(),
                        Guarantee = bo,
                        deviceName = rdr["deviceName"].ToString()
                    };
                    deviceListToReturn = deviceListModel;
                }
                return deviceListToReturn;

            }
            else
            {
                return null;

            }
        }

        
        //Count statement
        public int Count(string email, string phonenumber)
        {
            string query = "SELECT Count(*) FROM Client_table where client_email= '" + email + "' AND client_phonenumber='" + phonenumber + "'";
            int Count = -1;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Login check
        public int ClientExist(string email, string password)
        {
            string query = "SELECT Count(*) FROM Client_table where client_email= '" + email + "' AND client_password='" + password + "'";
            int Count = -1;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");
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
        public void Delete()
        {
        }

        //Select statement


        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
