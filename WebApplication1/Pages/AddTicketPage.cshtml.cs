using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WebApplication1.DBHandler;
using WebApplication1.Models;


namespace WebApplication1.Pages
{
    public class AddTicketPageModel : PageModel
    {
        DBSubService dBSubService = new DBSubService();
        DBClient dBClient = new DBClient();
        DBTicket dBTicket = new DBTicket();
        DBPunonjes dBPunonjes = new DBPunonjes();
        DBDeviceList dBDeviceList = new DBDeviceList();


        public string DepartmentModels { get; set; }
        public List<string> ServiceModels { get; set; }
        public string nameParam { get; set; }
        public string change { get; set; }
        public string selected { get; set; }
        public string DeviceIdParam { get; set; }


        public void OnGet()
        {
            DeviceIdParam = HttpContext.Request.Query["deviceId"].ToString();

            nameParam = HttpContext.Request.Query["clientname"].ToString();
            DepartmentModels = getDeviceList().deviceName;
            ServiceModels = dBSubService.getAllServiceFromDepartment(DepartmentModels);

        }
        private DeviceListModel getDeviceList()
        {
            DeviceIdParam = HttpContext.Request.Query["deviceId"].ToString();
            System.Diagnostics.Debug.WriteLine("0---- : "+ DeviceIdParam + "-- " + HttpContext.Request.Query["clientname"].ToString());
            return dBDeviceList.returnDevice(HttpContext.Request.Query["deviceId"].ToString());
        }
 

        public IActionResult OnPostInsertTicket()
        {
            selected = Request.Form["department"];
            Console.WriteLine(selected);
            //ServiceModels = dBSubService.getAllServiceFromDepartment(selected);
            string department = Request.Form["department"];
            string service = Request.Form["service"];
            string description = Request.Form["description"];
            string priority = Request.Form["priority"];
            Boolean isPriority = false;
            if (priority == "Priority")
                isPriority = true;
            Boolean guarantee = true;
            System.Diagnostics.Debug.WriteLine("--::: -- : "+ Helper.EnteredDeviceID);
            ClientModel clientModel = dBClient.SelectFromDeviceId(Helper.EnteredDeviceID);


            int days = dBSubService.serviceDays(department);
            Ticket OpenedTicket = new Ticket
            {
                Department = department,
                Service = service,
                Description = description,
                Priority = isPriority,
                Guarantee = guarantee,
                ClientModel = clientModel,
                OpenedDate = DateTime.Now,
                FinishDate = DateTime.Now.AddDays(days),
                Status = "Pending"
            };
          
                    dBTicket.Insert(OpenedTicket);
            this.sendEmail(OpenedTicket);

            //Delegate the ticket to a Punonjes who is free........
            /*
             * 
             * 
             */
            //Find all punonjes who have their Ticket field null
                int numberOfFreePunonjes = dBPunonjes.getFreePunonjes().Count();

                List<Punonjes> listOfFreePunonjes = dBPunonjes.getFreePunonjesPerDepartment(department);
                //get a random number between these and the one will be delegated for that ticket
                Random random = new Random();

                //Who are totally free
               /* if (numberOfFreePunonjes > 0)
                {
                    System.Diagnostics.Debug.WriteLine("entered here");
                    int randomNr = random.Next(numberOfFreePunonjes);  //between 0 and length
                    Punonjes delegatedPunonjes = listOfFreePunonjes[randomNr];
                    dBPunonjes.delegateTicket(delegatedPunonjes.name, delegatedPunonjes.email, delegatedPunonjes.department, OpenedTicket);
                }*/

                //else
                //{
                    List<Punonjes> listofAllPunonjes = dBPunonjes.getAllPunonjesPerDepartment(department);
                    List<int> listwithCount = new List<int>();
                    for(int i = 0;i< listofAllPunonjes.Count();i++)
                    {
                        System.Diagnostics.Debug.WriteLine("+++ -- : " + listofAllPunonjes[i].TicketModel.Count());
                        listwithCount.Add(listofAllPunonjes[i].TicketModel.Count());
                    }
                    int smallestNumber = listwithCount.Min();
                int index = listwithCount.IndexOf(smallestNumber);
                    System.Diagnostics.Debug.WriteLine("Smallest -- : " + smallestNumber +" Index: "+listwithCount.IndexOf(smallestNumber));
                    dBPunonjes.delegateTicket(listofAllPunonjes[index].name, listofAllPunonjes[index].email, listofAllPunonjes[index].department, OpenedTicket);


                    /*Nuk ka puntore te lire per momentin*/
                    //Store ticket on a table for later check and if its priority replace with one without priority
                //}
                return RedirectToPage("Index");
                
               
        }



        public void sendEmail(Ticket openedTicket)
        {
            
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add("ademcani773@gmail.com");
            mail.From = new MailAddress("ademcani773@gmail.com", "eSupport", System.Text.Encoding.UTF8);
            mail.Subject = "Kerkesa juaj per eSupport u mor ne konsiderate";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = "Pershendetje Z/Znj." + openedTicket.ClientModel.ClientName +" kerkesa juaj per eSupport eshte marre ne konsiderate\n" +
                "Dorezimi i krye me "+ openedTicket.OpenedDate.Date + " dhe kthimi me date " + openedTicket.FinishDate.Date +" \n" +

                " "+ openedTicket.Department +"/"+openedTicket.ClientModel.ClientID+". Faleminderit!!";
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("ademcani773@gmail.com", "12345elb");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
            }
            
            /*
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            MailAddress from = new MailAddress("ademcani773@gmail.com", "Adem Cani");
            MailAddress to = new MailAddress("ademcani773@gmail.com", "Adem Cani");
            MailMessage message = new MailMessage(from, to);
            message.Body = "This is a test e-mail message sent using gmail as a relay server ";
            message.Subject = "Gmail test email with SSL and Credentials";
            NetworkCredential myCreds = new NetworkCredential("ademcani773@gmail.com", "12345elb", "");
            client.Credentials = myCreds;
            client.UseDefaultCredentials = true;
            client.Send(message);*/
        }

      
    }
}
