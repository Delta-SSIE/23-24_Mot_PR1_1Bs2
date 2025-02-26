using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvod_OOP_sam
{
    enum Sex
    {
        Man,
        Woman,
        Other
    }
    internal class Human
    {
        public string name;
        public Sex sex;
        public int age;
        public bool life = true;

        //Konstruktor (metoda, která se zavolá při každém vytvoření objektu ze třídy Human)
        public Human(string n, Sex s, int a)
        {
            //Načte hodnoty z parametrů do konkrétních vlastností u objektu
            this.name = n;
            this.sex = s;
            this.age = a;
        }


        public string Introduction()
        {
            return $"Hello, I'm {name} and I'm {age} years old!";
        }

        public void Kill()
        {
            life = false;
        }


    }
}
