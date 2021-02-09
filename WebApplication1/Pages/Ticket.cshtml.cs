using GSF.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBHandler;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public DBService1 dBService1 = new DBService1();
        public DBSolvedTicket dBSolvedTicket = new DBSolvedTicket();
        public List<SolvedTicketModel> listOfSolvedTicket { get; set; }
        public List<DepartmentModel> ListOfAllDevices { get; set; }
        public string SelectedDevice { get; set; }
        public string SearchedString { get; set; }
        public string msg { get; set; }
        public void OnGet()
        {
            listOfSolvedTicket = dBSolvedTicket.getAllService();
            ListOfAllDevices = dBService1.getAllService();
        }

        public IActionResult OnPostOnSearch()
        {
            this.SelectedDevice = Request.Form["deviceSearch"];
            this.SearchedString = Request.Form["search"];
            System.Diagnostics.Debug.WriteLine("---Device Search : " + this.SelectedDevice);
            System.Diagnostics.Debug.WriteLine("---Device Search : " + this.SearchedString);
            listOfSolvedTicket = dBSolvedTicket.getAllServiceFromNameAndSearch(this.SelectedDevice,this.SearchedString);
            ListOfAllDevices = dBService1.getAllService();
            return Page();

        }
        public FileResult OnPostDownloadFile(string ticket)
        {
            listOfSolvedTicket = dBSolvedTicket.getAllService();
            string tex = HttpContext.Request.Query["doc"].ToString();
            System.Diagnostics.Debug.WriteLine("---: "+ tex);
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\User.WINDOWS-VCRGH5N\Desktop\eSupport\eSupport\Documentation\"+tex.Substring(1)+"");
            string fileName = ""+ tex.Substring(1) + "";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);



        }

        byte[] GetFile(string s)
        {
            System.IO.FileStream fs = System.IO.File.OpenRead(s);
            byte[] data = new byte[fs.Length];
            int br = fs.Read(data, 0, data.Length);
            if (br != fs.Length)
                throw new System.IO.IOException(s);
            return data;
        }
    }
}
