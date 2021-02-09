using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSupport
{
    class DBTicket
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

       //Return number of opened ticket for everyday of a week
       public List<int> numberOfTicketLastWeek(DateTime dateToday)
        {
            List<int> listToReturn = new List<int>();

            string query = "SELECT openedDateTime FROM ticket_table";
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();
                List<DateTime> last7Days = new List<DateTime>();
                while (rdr.Read())
                {
                    DateTime date = Convert.ToDateTime(rdr["openedDateTime"].ToString());

                    if ((dateToday - date).Days <= 7)
                    {
                        last7Days.Add(date);
                    }
                }
                int count = 0;
                for(int i = 7;i>=0;i--)
                {

                    count = 0;
                    for(int j = 0;j<last7Days.Count();j++)
                    {

                        System.Diagnostics.Debug.WriteLine("---:: " + dateToday.Day + " -- " + last7Days[j].Day);

                        if ((dateToday.Day-last7Days[j].Day) == i)
                        {
                            count++;
                        }
                    }

                    listToReturn.Add(count);


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
