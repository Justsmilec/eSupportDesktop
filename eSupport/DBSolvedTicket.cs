using eSupport.Model;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSupport
{
    class DBSolvedTicket
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBSolvedTicket()
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
        public void Insert(Ticket ticket,string documentation,string description,Fatura fatura)
        {

            //insert into DB
            string query = "INSERT INTO solvedticket_table (ticket,documentation,description,fatura) VALUES('" + JsonConvert.SerializeObject(ticket) + "', '"+documentation+ "', '" + description + "','" + JsonConvert.SerializeObject(fatura) + "')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        public List<List<string>> numberOfSolvedTicketPerDepartment()
        {
            DBService dBService = new DBService();
            List<Service> listofDepartments = new List<Service>();
            listofDepartments = dBService.getAllService();
            List<List<string>> listToReturn = new List<List<string>>();

            string query = "SELECT ticket FROM solvedticket_table";
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();
                List<Ticket> listofTicket = new List<Ticket>();
                while (rdr.Read())
                {
                    //DateTime date = Convert.ToDateTime(rdr["openedDateTime"].ToString());
                    Ticket ticket = JsonConvert.DeserializeObject<Ticket>(rdr["ticket"].ToString());
                    listofTicket.Add(ticket);
                }
                int count = 0;
                for (int i = 0 ; i < listofDepartments.Count(); i++)
                {

                    count = 0;
                    for (int j = 0; j < listofTicket.Count(); j++)
                    {

                        //System.Diagnostics.Debug.WriteLine("---:: " + dateToday.Day + " -- " + last7Days[j].Day);

                        if (listofDepartments[i].name == listofTicket[j].Department)
                        {
                            count++;

                            listofTicket.Remove(listofTicket[j]);
                            --j;
                        }
                    }
                    List<string> sublist = new List<string>();
                    sublist.Add(listofDepartments[i].name);
                    sublist.Add(count.ToString());
                    listToReturn.Add(sublist);
                }
                this.CloseConnection();
            }
            else
            {
                return null;
            }
            return listToReturn;
        }

        //Count statement

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
