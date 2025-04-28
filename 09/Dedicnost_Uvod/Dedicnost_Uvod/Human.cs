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

        //Přidání slova virtual jsem řekl, že je možné tuto metodu alteranovat v jakékoliv dědičné třídě
        public virtual void PredstavSe()
        {
            Console.WriteLine($"Hi, my name is {name}. This is my email {email}.");
        }
    }
}
