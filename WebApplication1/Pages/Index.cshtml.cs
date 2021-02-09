
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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string msg { get; set; }
        public List<DepartmentModel> DepartmenModels { get; set; }
        public void OnGet()
        {
            msg = "Adem";
            DepartmenModels = getAllDepartmentList();
        }
        private List<DepartmentModel> getAllDepartmentList()
        {
            DBService1 dbService = new DBService1();
            return dbService.getAllService();
        }
        public void OnGetMenu1()
        {
            msg = "Adem Menu1";
        }
        public void OnPost()
        {
            msg = "Adem is OnPost";
        }
    }
}
