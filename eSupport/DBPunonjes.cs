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
    class DBPunonjes
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

        //Insert statement
        public void Insert(PunonjesModel punonjesModel)
        {
            Ticket ticketModel = null;
            //insert into DB
            string query = "INSERT INTO Punonjes_table (name,email,phonenumber,department,level,password,ticket) " +
                "VALUES('" + punonjesModel.name + "','" + punonjesModel.email + "','" + punonjesModel.phonenumber + "','" 
                + punonjesModel.department + "','" + punonjesModel.level + "','" + punonjesModel.password + "','" + JsonConvert.SerializeObject(ticketModel) + "')";

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

        public List<PunonjesModel> getAllService()
        {
            string query = "SELECT * FROM Punonjes_table";
            List<PunonjesModel> list = new List<PunonjesModel>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    List<Ticket> ticketModel = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket"].ToString());
                    PunonjesModel punonjesModel = new PunonjesModel
                    {
                        name = rdr["name"].ToString(),
                        email = rdr["email"].ToString(),
                        phonenumber = rdr["phonenumber"].ToString(),
                        department = rdr["department"].ToString(),
                        level = rdr["level"].ToString(),
                        TicketModel = ticketModel


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


       

        public void removedelegateTicket(string name,string email, Ticket ticket)
        {
            List<Ticket> list = new List<Ticket>();
            list = getAllTicketPerPunonjes(name);
            for(int i = 0;i<list.Count();i++)
            {
               if(JsonConvert.SerializeObject(ticket) == JsonConvert.SerializeObject(list[i]))
                {
                    list.RemoveAt(i);
                    break;
                    //System.Diagnostics.Debug.WriteLine("T: "+ JsonConvert.SerializeObject(ticket) );
                    //System.Diagnostics.Debug.WriteLine("Found");
                }
                  



            }
            list.Remove(ticket);
            System.Diagnostics.Debug.WriteLine("List after removing: "+ list.Count());


            string query = "UPDATE Punonjes_table SET ticket = '" + JsonConvert.SerializeObject(list) + "' WHERE name = '" + name + "' AND email = '"+email+"'";

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Update punonjes_table to delegate ticket
        public void delegateTicket(string name, Ticket ticket)
        {
            System.Diagnostics.Debug.WriteLine(JsonConvert.SerializeObject(ticket));
            List<Ticket> list = new List<Ticket>();
            List<Ticket> listTest = new List<Ticket>();
            listTest = getAllTicketPerPunonjes(name);
            if(listTest == null)
            {
                list.Add(ticket);

            }
            else
            {
                list = listTest;
                list.Add(ticket);
            }


            string query = "UPDATE Punonjes_table SET ticket = '" + JsonConvert.SerializeObject(list) + "' WHERE name = '" + name + "'";

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        //When a punonjes is deleted and there are ticket for that punonjes then all the ticket go to the left number of other punonjes
        public void ticketDistribution(string departmentname, List<Ticket> ticket)
        {
            System.Diagnostics.Debug.WriteLine(JsonConvert.SerializeObject(ticket));
            List<PunonjesModel> listOfPunonjesOnDepartment = new List<PunonjesModel>();
            listOfPunonjesOnDepartment = this.listOfPunonjesOnDepartment(departmentname);

            Random randomTicket = new Random();
                for (int i = 0; i < listOfPunonjesOnDepartment.Count(); i++)
                {
                    int random = randomTicket.Next(ticket.Count());
                    delegateTicket(listOfPunonjesOnDepartment[i].name, ticket[random]);
                    ticket.Remove(ticket[random]);
                    if (ticket.Count() == 0)
                        break;
                    if (i == listOfPunonjesOnDepartment.Count() - 1)
                        i = 0;
                }
            
            
        }

        //Update finish time by number of days
        public void appendTimeForTicket(int days,string name,Ticket ticket)
        {
            System.Diagnostics.Debug.WriteLine(JsonConvert.SerializeObject(ticket));
            List<Ticket> list = new List<Ticket>();
            List<Ticket> listTest = new List<Ticket>();
            listTest = getAllTicketPerPunonjes(name);
           
                list = listTest;
            int index = -1;
            for(int i = 0;i<list.Count();i++)
            {
                //System.Diagnostics.Debug.WriteLine("I1: " + JsonConvert.SerializeObject(list[i]).ToString());
                //System.Diagnostics.Debug.WriteLine("I1: " + JsonConvert.SerializeObject(ticket).ToString());

                if (JsonConvert.SerializeObject(list[i]).ToString() == JsonConvert.SerializeObject(ticket).ToString())
                {
                    index = i;
                    System.Diagnostics.Debug.WriteLine("Index of ticket: " + i);
                    break;

                }
                
                //System.Diagnostics.Debug.WriteLine("Index of ticket: " + list.IndexOf(ticket));

            }
            if(index >= 0)
            {
                list.RemoveAt(index);
                ticket.FinishDate = (ticket.FinishDate).AddDays(days);
                list.Insert(index, ticket);
            }



            string query = "UPDATE Punonjes_table SET ticket = '" + JsonConvert.SerializeObject(list) + "' WHERE name = '" + name + "'";

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }


        public void deleteTicket(string name,Ticket ticket)
        {
            System.Diagnostics.Debug.WriteLine(JsonConvert.SerializeObject(ticket));
            List<Ticket> list = new List<Ticket>();
            List<Ticket> listTest = new List<Ticket>();
            listTest = getAllTicketPerPunonjes(name);

            list = listTest;
            int index = -1;
            for (int i = 0; i < list.Count(); i++)
            {
                if (JsonConvert.SerializeObject(list[i]).ToString() == JsonConvert.SerializeObject(ticket).ToString())
                {
                    index = i;
                    System.Diagnostics.Debug.WriteLine("Index of ticket: " + i);
                    break;

                }

                //System.Diagnostics.Debug.WriteLine("Index of ticket: " + list.IndexOf(ticket));
            }
            if (index >= 0)
            {
                list.RemoveAt(index);
            }
            string query = "UPDATE Punonjes_table SET ticket = '" + JsonConvert.SerializeObject(list) + "' WHERE name = '" + name + "'";

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }


        public List<PunonjesModel> getFreePunonjes()
        {
            string query = "SELECT * FROM Punonjes_table where ticket = null";
            List<PunonjesModel> list = new List<PunonjesModel>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    List<Ticket> ticketModel = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket"].ToString());
                    PunonjesModel punonjesModel = new PunonjesModel
                    {
                        name = rdr["name"].ToString(),
                        email = rdr["email"].ToString(),
                        phonenumber = rdr["phonenumber"].ToString(),
                        department = rdr["department"].ToString(),
                        level = rdr["level"].ToString(),
                        TicketModel = ticketModel


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
        public string[] listOfPunonjesPerDepartment(string department)
        {
            string query = "SELECT name FROM Punonjes_table where department = '" + department + "'";
            List<string> list = new List<string>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    list.Add(rdr["name"].ToString());
                }
                this.CloseConnection();
                string[] listofString = new string[list.Count()];
                for(int i = 0;i<list.Count();i++)
                {
                    listofString[i] = list[i];
                }
                return listofString;
            }
            else
            {
                return null;
            }
        }

        public List<PunonjesModel> listOfPunonjesOnDepartment(string department)
        {
            string query = "SELECT * FROM Punonjes_table where department = '"+department+"'";
            List<PunonjesModel> list = new List<PunonjesModel>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    List<Ticket> ticketModel = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket"].ToString());
                    PunonjesModel punonjesModel = new PunonjesModel
                    {
                        name = rdr["name"].ToString(),
                        email = rdr["email"].ToString(),
                        phonenumber = rdr["phonenumber"].ToString(),
                        department = rdr["department"].ToString(),
                        level = rdr["level"].ToString(),
                        TicketModel = ticketModel


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

        public PunonjesModel returnPunonjes(string name,string email)
        {
            string query = "SELECT * FROM Punonjes_table where name = '" + name + "' AND email = '"+email+"'";
            PunonjesModel list = new PunonjesModel();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    List<Ticket> ticketModel = JsonConvert.DeserializeObject<List<Ticket>>(rdr["ticket"].ToString());
                    PunonjesModel punonjesModel = new PunonjesModel
                    {
                        name = rdr["name"].ToString(),
                        email = rdr["email"].ToString(),
                        phonenumber = rdr["phonenumber"].ToString(),
                        department = rdr["department"].ToString(),
                        level = rdr["level"].ToString(),
                        TicketModel = ticketModel


                    };
                    list =  punonjesModel;
                }
                this.CloseConnection();
                return list;
            }
            else
            {
                return null;
            }
        }
        public List<Ticket> getAllTicketPerPunonjes(string name,string email)
        {
            string query = "SELECT ticket FROM Punonjes_table where name = '"+name+"' AND email = '"+email+"'";
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
        public List<Ticket> getAllTicketPerPunonjes(string name)
        {
            string query = "SELECT * FROM Punonjes_table where name = '" + name + "'";
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

            List<Service> list = new List<Service>();
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

        }


        //Delete statement
        public void Delete(string selectedName,string selectedEmail)
        {
            string query = "Delete from punonjes_table where name = '" + selectedName + "' AND email = '"+selectedEmail+"'";

            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

        }



        public int CountifFound(string name, string email, string password)
        {
            string query = "SELECT Count(*) FROM punonjes_table where name= '" + name + "' AND email='" + email + "' AND password='" + CryptoHandler.EncodePasswordToBase64(password) + "'";
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
    }
}
