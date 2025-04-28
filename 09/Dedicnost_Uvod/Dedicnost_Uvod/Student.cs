using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_Uvod
{
    //nastavení, že Student dědí vše z třídy Human
    internal class Student : Human
    {
        public string grade { get; set; }
    }
}
