using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.DBHandler;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class RegisterModel : PageModel
    {
                    DBClient dBClient = new DBClient();
        ClientModel clientModel;

        public string msg { get; set; }
        public void OnGet()
        {
            msg = "Demii";
        }
        public void OnPost()
        {
            msg = Request.Form["username"];
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string phonenumber = Request.Form["phonenumber"];
            string password = Request.Form["pass"];
            registerToDB(name, email, phonenumber, password);


        }

        public IActionResult OnPostLogin()
        {
            string email = Request.Form["email"];
            string device_id = Request.Form["pass"];
            Helper.EnteredDeviceID = device_id;
            if(login(email, device_id))
            {
                ClientModel loggedinClient = dBClient.SelectFromEmailAndId(email,device_id);
            string id = dBClient.returnClientId(loggedinClient.ClientName, loggedinClient.ClientEmail);
                return RedirectToPage("ClientPage","User",new { deviceId=device_id,name=loggedinClient.ClientName});

            }
            else
            {
                return Page();
            }


        }
        private void registerToDB(string name,string email,string phonenumber,string password)
        {
            clientModel = new ClientModel
            {
                ClientName = name,
                ClientEmail = email,
                ClientPhonenumber = phonenumber,
                ClientID = password
            };
            if(dBClient.Count(email,phonenumber) == 0)
            {
                dBClient.Insert(clientModel);
                
            }

        }

        public Boolean login(string email,string password)
        {
            if (dBClient.ClientExist(email, password) == 1)
            {
                return true;
            }
            else
                return false;
        }
    }
}
