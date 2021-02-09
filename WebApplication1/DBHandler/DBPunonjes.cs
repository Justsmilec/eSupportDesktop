using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DBHandler
{
    public class DBPunonjes
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBPunonjes()
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
       

        public List<Punonjes> getAllService()
        {
            string query = "SELECT * FROM Punonjes_table";
            List<Punonjes> list = new List<Punonjes>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Ticket ticketModel = JsonConvert.DeserializeObject<TicketModel>(rdr["ticket"].ToString());
                    Punonjes punonjesModel = new Punonjes
                    {
                        name = rdr["name"].ToString(),
                        email = rdr["email"].ToString(),
                        phonenumber = rdr["phonenumber"].ToString(),
                        department = rdr["department"].ToString(),
                        level = rdr["level"].ToString(),
                        TicketModel = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket"].ToString())


                };
                    list.Add(punonjesModel);
                }
                this.CloseConnection();
                return list;
            }
            else
            {
                return null;
            }
        }


        public List<Punonjes> getAllPunonjesPerDepartment(string department)
        {
            string query = "SELECT * FROM Punonjes_table where department = '"+department+"'";
            List<Punonjes> list = new List<Punonjes>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Ticket ticketModel = JsonConvert.DeserializeObject<TicketModel>(rdr["ticket"].ToString());
                    Punonjes punonjesModel = new Punonjes
                    {
                        name = rdr["name"].ToString(),
                        email = rdr["email"].ToString(),
                        phonenumber = rdr["phonenumber"].ToString(),
                        department = rdr["department"].ToString(),
                        level = rdr["level"].ToString(),
                        TicketModel = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket"].ToString())


                    };
                    list.Add(punonjesModel);
                }
                this.CloseConnection();
                return list;
            }
            else
            {
                return null;
            }
        }

        public List<Punonjes> getFreePunonjes()
        {
            string nullstring = "null";
            string query = "SELECT * FROM Punonjes_table";
            List<Punonjes> list = new List<Punonjes>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                List<Ticket> ticketList = new List<Ticket>();
                while (rdr.Read())
                {
                    //ticketList.Add()
                    var ticketModel = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket"].ToString());
                    if(ticketModel == null)
                    {
                        Punonjes punonjesModel = new Punonjes
                        {
                            name = rdr["name"].ToString(),
                            email = rdr["email"].ToString(),
                            phonenumber = rdr["phonenumber"].ToString(),
                            department = rdr["department"].ToString(),
                            level = rdr["level"].ToString(),
                            TicketModel = null


                        };
                        list.Add(punonjesModel);
                    }
                }
                this.CloseConnection();
                return list;
            }
            else
            {
                return null;
            }
        }



        public List<Punonjes> getFreePunonjesPerDepartment(string department)
        {
            string nullstring = "null";
            string query = "SELECT * FROM Punonjes_table where department = '"+department+"'";
            List<Punonjes> list = new List<Punonjes>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                List<Ticket> ticketList = new List<Ticket>();
                while (rdr.Read())
                {
                    //ticketList.Add()
                    var ticketModel = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket"].ToString());
                    if (ticketModel == null)
                    {
                        Punonjes punonjesModel = new Punonjes
                        {
                            name = rdr["name"].ToString(),
                            email = rdr["email"].ToString(),
                            phonenumber = rdr["phonenumber"].ToString(),
                            department = rdr["department"].ToString(),
                            level = rdr["level"].ToString(),
                            TicketModel = null


                        };
                        list.Add(punonjesModel);
                    }
                }
                this.CloseConnection();
                return list;
            }
            else
            {
                return null;
            }
        }
        //Update punonjes_table to delegate ticket
        public void delegateTicket(string name,string email,string department,Ticket ticket)
        {


            System.Diagnostics.Debug.WriteLine(JsonConvert.SerializeObject(ticket));
            List<Ticket> list = new List<Ticket>();
            List<Ticket> listTest = new List<Ticket>();
            listTest = getAllTicketPerPunonjes(name,email);
            if (listTest == null)
            {
                list.Add(ticket);

            }
            else
            {
                list = listTest;
                list.Add(ticket);
            }
            string query = "UPDATE Punonjes_table SET ticket = '"+ JsonConvert.SerializeObject(list) + "' WHERE name = '"+name+"' AND email = '"+email+"' AND department = '"+department+"'";

            if (this.OpenConnection() == true)
            {
                System.Diagnostics.Debug.WriteLine(name + "--" + department + "--" + email);

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }



        public List<Ticket> getAllTicketPerPunonjes(string name, string email)
        {
            string query = "SELECT ticket FROM Punonjes_table where name = '" + name + "' AND email = '" + email + "'";
            List<Ticket> list = new List<Ticket>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    List<Ticket> ticketModel = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket"].ToString());
                    list = ticketModel;
                }
                this.CloseConnection();
                return list;
            }
            else
            {
                return null;
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
        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete(string selected)
        {
            string query = "Delete from department_table where department_name = '" + selected + "'";

            //List<Service> list = new List<Service>();
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
