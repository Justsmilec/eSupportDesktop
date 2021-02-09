using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSupport.Model
{
    class Ticket
    {
        public string Department { get; set; }
        public string Service { get; set; }
        public string Description { get; set; }
        public Boolean Priority { get; set; }
        public Boolean Guarantee { get; set; }
        public ClientModel ClientModel { get; set; }
        public Boolean Finished { get; set; }
        public DateTime OpenedDate { get; set; }
        public string Status { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
