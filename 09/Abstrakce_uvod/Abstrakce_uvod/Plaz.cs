using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstrakce_uvod
{
    internal class Plaz : Zvire
    {
        public override void IdentifySelf()
        {
            Console.WriteLine($"{name} : {age} : PLAZ");
        }
    }
}
