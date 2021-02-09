using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DBHandler
{
    public class DBClient
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBClient()
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
        public void Insert(ClientModel clientModel)
        {
            string query = "INSERT INTO Client_table (client_name,client_email,client_phonenumber,client_deviceId) " +
                "VALUES('" + clientModel.ClientName + "','" + clientModel.ClientEmail + "','" + clientModel.ClientPhonenumber + "','" + clientModel.ClientID + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public string returnClientId(string name,string email)
        {
            string clientId = "";
            string query = "SELECT id FROM Client_table where client_email= '"+email+"' AND client_name ='"+name+"'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    clientId = rdr["id"].ToString();
                }
                return clientId;
            }
            else
            {
                return clientId;

            }
        }

        public List<ClientModel> getAllService()
        {
            string query = "SELECT * FROM department_table";
            List<ClientModel> list = new List<ClientModel>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr["department_name"].ToString());
                   
                }

                return list;
            }
            else
            {
                return null;
            }
        }

        public ClientModel SelectFromEmailAndId(string email,string device_id)
        {
            string query = "SELECT * FROM Client_table where client_email = '"+email+ "' AND client_deviceId = '" + device_id + "'";
            ClientModel client = new ClientModel();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["department_name"].ToString());
                    client = new ClientModel
                    {
                        ClientName = rdr["client_name"].ToString(),
                        ClientEmail = rdr["client_email"].ToString(),
                        ClientID = rdr["client_deviceId"].ToString(),
                        ClientPhonenumber = rdr["client_phonenumber"].ToString(),
                        TicketList = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket_list"].ToString())

                    };
                }

                return client;
            }
            else
            {
                return null;
            }
        }

        public ClientModel SelectFromDeviceId(string device_id)
        {
            string query = "SELECT * FROM Client_table where client_deviceId = '" + device_id + "'";
            ClientModel client = new ClientModel();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["department_name"].ToString());
                    client = new ClientModel
                    {
                        ClientName = rdr["client_name"].ToString(),
                        ClientEmail = rdr["client_email"].ToString(),
                        ClientID = rdr["client_deviceId"].ToString(),
                        ClientPhonenumber = rdr["client_phonenumber"].ToString(),
                        TicketList = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket_list"].ToString())

                    };
                }
                //System.Diagnostics.Debug.WriteLine("0---- : " + DeviceIdParam + "-- " + HttpContext.Request.Query["clientname"].ToString());

                return client;
            }
            else
            {
                return null;
            }
        }
        public ClientModel SelectFromNameId(string email,string id)
        {
            string query = "SELECT * FROM Client_table where client_email = '" + email + "' AND id = '"+id+"'";
            ClientModel client = new ClientModel();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["department_name"].ToString());
                    client = new ClientModel
                    {
                        ClientName = rdr["client_name"].ToString(),
                        ClientEmail = rdr["client_email"].ToString(),
                        ClientID = rdr["client_password"].ToString(),
                        ClientPhonenumber = rdr["client_phonenumber"].ToString()

                    };
                }

                return client;
            }
            else
            {
                return null;
            }
        }
        //Count statement
        public int Count(string email, string device_id)
        {
            string query = "SELECT Count(*) FROM Client_table where client_email= '" + email + "' AND client_deviceId='" + device_id + "'";
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
        public int ClientExist(string email, string device_id)
        {
            string query = "SELECT Count(*) FROM Client_table where client_email= '" + email + "' AND client_deviceId='" + device_id + "'";
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
