using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class ClientPageModel : PageModel
    {
        public string device_id { get; set; }
        public string client_name { get; set; }
        public void OnGet()
        {
            client_name = HttpContext.Request.Query["name"].ToString();
            device_id = HttpContext.Request.Query["deviceId"].ToString();

        }

    }
}
