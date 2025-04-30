using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shop
{
    internal class User : IDisplay
    {
        public string username { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public string type { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{username}, email: {email}, type: {type}");
        }
    }
}
