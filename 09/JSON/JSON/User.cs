using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    internal class User
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string ip_adress { get; set; }

        public string IdentifySelf()
        {
            return $"{first_name} {last_name}, {email}";
        }
    }
}
