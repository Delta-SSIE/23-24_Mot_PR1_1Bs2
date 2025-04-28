using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakce_uvod
{
    //Abstraktvní třída - nelze z ní vytvářet objekty, pouze z ní mohou jiné třídy odvozovat
    abstract class Zvire
    {
        public string name { get; set; }
        public int age { get; set; }

        public virtual void IdentifySelf()
        {
            Console.WriteLine($"{name} : {age}");
        }

        public void MakeSound()
        {

        }
    }
}
