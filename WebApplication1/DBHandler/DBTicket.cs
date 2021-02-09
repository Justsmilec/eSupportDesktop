using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DBHandler
{
    public class DBTicket
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBTicket()
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

        public void Insert(Ticket ticket)
        {
            string query = "INSERT INTO Ticket_table (department,service,description,priority,guarantee,clientModel,finished,openedDateTime,finishDate) " +
                "VALUES('" + ticket.Department+ "','" + ticket.Service + "','" + ticket.Description + "','" + Convert.ToInt32(ticket.Priority)  + "'" +
                ",'" + Convert.ToInt32(ticket.Guarantee) + "','" + JsonConvert.SerializeObject(ticket.ClientModel) + "','" + Convert.ToInt32(ticket.Finished) + "','" + ticket.OpenedDate.ToString() + "','" + ticket.FinishDate.ToString() + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public List<Ticket> getAllService()
        {
            string query = "SELECT * FROM department_table";
            List<Ticket> list = new List<Ticket>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr["department_name"].ToString());
                    Ticket ticket = new Ticket
                    {
                        //DepartmentName = rdr["department_name"].ToString()
                    };
                    list.Add(ticket);
                }

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
