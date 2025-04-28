using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_Uvod
{
    internal class Human
    {
        public string name { get; set; }
        public string email { get; set; }
        public int age { get; set; }

        public void PredstavSe()
        {
            Console.WriteLine($"Hi, my name is {name}. This is my email {email}.");
        }
    }
}
