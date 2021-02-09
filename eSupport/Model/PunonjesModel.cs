using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSupport.Model
{
    class PunonjesModel
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        public string level { get; set; }
        public string department { get; set; }
        public string password { get; set; }
        public List<Ticket> TicketModel { get; set; }


    }
}
