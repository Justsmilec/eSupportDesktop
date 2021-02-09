using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ClientModel
    {
        public string ClientName { get; set; }
        public string ClientPhonenumber { get; set; }
        public string ClientEmail { get; set; }
        public string ClientID { get; set; }
        public List<Ticket> TicketList { get; set; }


    }
}
