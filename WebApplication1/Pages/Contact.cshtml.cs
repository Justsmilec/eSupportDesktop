using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AE.Net.Mail;
using WebApplication1.DBHandler;

namespace WebApplication1.Pages
{
    public class ContactModel : PageModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string deviceID { get; set; }
        public string message { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            name = Request.Form["name"];
            email = Request.Form["email"];
            deviceID = Request.Form["deviceId"];
            message = Request.Form["message"];
            Thread thread = new Thread(() => emailWorkerHandler(name, email, deviceID, message));//call thread for email handler
            thread.Start();
           
        }

        public void emailWorkerHandler(string name,string email,string deviceID,string message)
        {
            this.sendEmail(name, email, deviceID, message);
            this.readEmail();
        }
        public void sendEmail(string name,string email,string Id,string message)
        {
           
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add("ademcani773@gmail.com");
                mail.From = new MailAddress(email, "Client", System.Text.Encoding.UTF8);
                mail.Subject = "Kerkese per indetifikim ID= '"+Id+"'";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = message;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = System.Net.Mail.MailPriority.High;
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
           
        }
        public void sendEmailToClient(string name, string email, string Id, string message)
        {

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("ademcani773@gmail.com", "eSupport", System.Text.Encoding.UTF8);
            mail.Subject = "Kerkese per indetifikim ID= " + Id;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = message;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = System.Net.Mail.MailPriority.High;
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
        }

        public void readEmail()
        {
            ImapClient IC = new ImapClient("imap.gmail.com","ademcani773@gmail.com","12345elb",AuthMethods.Login,993,true);
            IC.SelectMailbox("INBOX");
            var count = IC.GetMessageCount();

            var Email = IC.GetMessage(count-1);
            string sender = Email.From.Address;
            string ID;
            System.Diagnostics.Debug.WriteLine("==:: " + sender);
            string subject = Email.Subject;
            ID = betweenStrings(subject, "'", "'");
            System.Diagnostics.Debug.WriteLine("==::-- " + ID);
            string message = "";
            //if excist or not
            if(new DBDeviceList().isFound(ID) == 0)
            {
                message = "Device me ID = " + ID + " nuk ekziston ne list. Ju lutem kontrolloni perseri numrin serial! Faleminderit!";
            }
            else
            {
                if(new DBSolvedTicket().isSolved(ID))
                {
                    message = "Device me ID = " + ID + " eshte tashme ceshtje e zgjidhur! Faleminderit!";

                }
                else
                {
                    message = "Device me ID = " + ID + " eshte akoma ne shqyrtim! Faleminderit!";
                }
            }
            this.sendEmailToClient("Name", sender, ID, message);

        }

        public static string betweenStrings(String text, String start, String end)
        {
            int p1 = text.IndexOf(start) + start.Length;
            int p2 = text.IndexOf(end, p1);

            if (end == "") return (text.Substring(p1));
            else return text.Substring(p1, p2 - p1);
        }
    }
}
