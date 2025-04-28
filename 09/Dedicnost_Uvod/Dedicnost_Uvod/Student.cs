using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dedicnost_Uvod
{
    //nastavení, že Student dědí vše z třídy Human
    internal class Student : Human
    {
        public string grade { get; set; }

        //Pro objekty z třídy Student se metoda PredstavSe() definovaná ve třídě Human, přepíše
        public override void PredstavSe()
        {
            Console.WriteLine($"Hi, my name is {name}. This is my email {email}. I am student in {grade}.");
        }
    }

    
}
