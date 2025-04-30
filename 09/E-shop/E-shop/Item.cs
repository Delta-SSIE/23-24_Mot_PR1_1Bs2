using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shop
{
    internal class Item :IDisplay
    {
        public string name { get; set; }
        public int price { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{name}, price {price}");
        }
    }
}
