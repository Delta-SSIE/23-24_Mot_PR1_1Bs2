using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozovýPark
{
    internal class Prodejce
    {
        public string Jmeno { get; set; }
        public int[] IndexyAut { get; set; }

        //konstruktor
        public Prodejce (string name)
        {
            Jmeno = name;
            IndexyAut = new int[0];
        }

        //metoda
        public void VypisAuta(Vozidlo[] auta)
        {
            for (int i = 0; i < IndexyAut.Length; i++)
            {
                auta[IndexyAut[i]].VypisInfo();
            }
        }
    }
}
