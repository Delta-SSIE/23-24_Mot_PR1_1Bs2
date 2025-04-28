using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_Uvod
{
    //Dědí z třídy Human
    internal class Teacher : Human
    {
        public int cabinet_number { get; set; }
        public string[] subjects { get; set; }

        public void List_Subjects()
        {
            //V rámci výpisu se využívá vlastnost objektu, kterou mu definuje třída rodičovská
            Console.WriteLine($"Teacher {name}:");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{subjects[i]}");
            }
        }
        //Pro objekty z třídy Teacher se metoda PredstavSe() definovaná ve třídě Human, přepíše
        public override void PredstavSe()
        {
            Console.WriteLine($"Hi, my name is {name}. This is my email {email}. I am teacher and my cabinet number is {cabinet_number}.");
        }
    }
}
