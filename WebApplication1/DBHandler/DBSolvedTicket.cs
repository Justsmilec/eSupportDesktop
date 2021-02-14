using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DBHandler
{
    public class DBSolvedTicket
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


        public List<SolvedTicketModel> getAllService()
        {
            string query = "SELECT * FROM solvedticket_table";
            List<SolvedTicketModel> list = new List<SolvedTicketModel>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["department_name"].ToString());
                    SolvedTicketModel solved = new SolvedTicketModel
                    {
                        SolvedTicket = JsonConvert.DeserializeObject<Ticket>(rdr["ticket"].ToString()),
                        Documentation = rdr["documentation"].ToString()

                    };
                    list.Add(solved);
                }

                return list;
            }
            else
            {
                return null;
            }
        }


        public List<SolvedTicketModel> getAllServiceFromNameAndSearch(string name,string searchedStr)
        {
            string[] listofSearchedStr = searchedStr.Split(" ");
            List<string> finalListofStr = new List<string>();
            for(int i = 0;i<listofSearchedStr.Length;i++)
            {
                if(listofSearchedStr[i].Length > 2)
                {
                    finalListofStr.Add(listofSearchedStr[i]);
                }
            }
            string query = "SELECT * FROM solvedticket_table";
            List<SolvedTicketModel> list = new List<SolvedTicketModel>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    //Console.WriteLine(rdr["department_name"].ToString());
                    SolvedTicketModel solved = new SolvedTicketModel
                    {
                        SolvedTicket = JsonConvert.DeserializeObject<Ticket>(rdr["ticket"].ToString()),
                        Documentation = rdr["documentation"].ToString()
                       
                    };
                    if(searchedStr == "")
                    {
                        if (solved.SolvedTicket.Department == name)
                            list.Add(solved);
                    }
                    else
                    {
                        if (solved.SolvedTicket.Department == name)
                        {
                            for(int i = 0;i<finalListofStr.Count();i++)
                            {
                                if(solved.SolvedTicket.Description.Contains(finalListofStr[i]))
                                {
                                    list.Add(solved);
                                    break;
                                }
                            }
                        }
                    }
                    
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


        public Boolean isSolved(string Id)
        {
            List<SolvedTicketModel> solvedTicket = getAllService();
            
            for(int i = 0;i<solvedTicket.Count();i++)
            {
                if(solvedTicket[i].SolvedTicket.ClientModel.ClientID == Id.ToUpper())
                {
                    return true;
                }

            }
            return false;
            
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
