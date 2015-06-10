using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Users
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public DateTime Birthday { get; set; }

        public string Gender { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        public override string ToString()
        {
            return "Employee: ID = " + ID + ", Name = " + Name + ".";
        }
    }
}
