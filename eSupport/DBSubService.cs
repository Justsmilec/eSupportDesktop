using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSupport.Model;
using MySql.Data.MySqlClient;

namespace eSupport
{
    class DBSubService
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBSubService()
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
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
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

        //Insert statement
        public void Insert(SubServiceModel subservice)
        {
            string query = "INSERT INTO subService_table (name,department,cost,time_required) VALUES('" + subservice.name + "','" + subservice.department_name + "'," + subservice.cost + "," + subservice.time_required + ")";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<SubServiceModel> getSubServices(string department_name)
        {
            string query = "SELECT * FROM subService_table where department = '"+department_name+"'";
            List<SubServiceModel> list = new List<SubServiceModel>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    SubServiceModel service = new SubServiceModel(rdr["name"].ToString(),rdr["department"].ToString(),int.Parse(rdr["cost"].ToString()),int.Parse(rdr["time_required"].ToString()));
                    list.Add(service);
                }
                this.CloseConnection();
                return list;
            }
            else
            {
                return null;
            }
        }

        public SubServiceModel getSubService(string name,string department)
        {
            string query = "SELECT * FROM subService_table where name = '" + name + "' AND department = '"+department+"'";
            SubServiceModel list = null;
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    SubServiceModel service = new SubServiceModel(rdr["name"].ToString(), rdr["department"].ToString(), int.Parse(rdr["cost"].ToString()), int.Parse(rdr["time_required"].ToString()));
                    list = service;
                }
                this.CloseConnection();
                return list;
            }
            else
            {
                return null;
            }
        }


        //Update Subservice
        public void updateSubService(string name, string department,SubServiceModel service)
        {


            string query = "UPDATE subservice_table SET name = '" + service.name + "',cost = '"+service.cost+"',time_required = '"+service.time_required+"'" +
                " WHERE name = '" + name + "' AND department = '"+department+"'";

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        //Count statement
        public int Count(string name)
        {
            string query = "SELECT Count(*) FROM subservice_table where name= '" + name + "'";
            int Count = -1;

            //Open Connection
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
        public void Delete(string selected,string department)
        {
            string query = "Delete from subservice_table where name = '" + selected + "' AND department = '"+department+"'";
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

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
