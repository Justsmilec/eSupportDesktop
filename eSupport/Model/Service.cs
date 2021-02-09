using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSupport.Model
{
    class Service
    {
        public int id;
        public string name;
        public string description;

        public Service(string name,string desc)
        {
            this.name = name;
            this.description = desc;
        }
    }
}
