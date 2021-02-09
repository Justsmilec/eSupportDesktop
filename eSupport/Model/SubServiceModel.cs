using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSupport.Model
{
  
    class SubServiceModel
    {
        public string name;
        public string department_name;
        public Department department;
        public int cost;
        public int time_required;

        public SubServiceModel(string name, string department_name, int cost, int time)
        {
            this.name = name;
            this.department_name = department_name;
            this.cost = cost;
            this.time_required = time;
        }


      
    }
}
