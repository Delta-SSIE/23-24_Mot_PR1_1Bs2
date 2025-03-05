using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovny
{
    internal class Knihovna
    {
        public string Nazev;
        public string Lokace;
        public Kniha[] Knihy;
        public Autor[] Autori;

        //konstruktor
        public Knihovna(string n, string l)
        {
            Nazev = n;
            Lokace = l;
            Knihy = new Kniha[0];
            Autori = new Autor[0];
        }

        //Metoda pridani knihy
        public void PridejKnihu()
        {
            bool existence = false;
            Console.WriteLine("Zadej mi název knihy");
            string nazev = Console.ReadLine();

            //Kontrola zda existuje takový titul
            for (int i = 0; i < Knihy.Length; i++)
            {
                if (Knihy[i].Nazev == nazev)
                {
                    existence = true;
                    Console.WriteLine("Daná kniha již existuje");
                }
            }

            //Pokud neexistuje, tak se přidává
            if(!existence)
            {
                //pomocná proměnná pro připadné nalezení autora, co již v knihovně existuje
                Autor objekt_autor = null;
                //dotaz na autora
                Console.WriteLine("Zadej mi autora");
                string autor = Console.ReadLine();
                for (int i = 0; i < Autori.Length; i++)
                {
                    if (Autori[i].Jmeno == autor)
                    {
                        //naplnění pomocné proměnné objektem Autor z pole Autori
                        objekt_autor = Autori[i];
                    }
                }

                //Zvětšení pole o 1
                Array.Resize(ref Knihy, Knihy.Length + 1);
                //přidání prvku na nový index
                Knihy[Knihy.Length - 1] = new Kniha(nazev, objekt_autor, autor);
            }
   
        }

        public void PridejAutor()
        {
            //Pomocná pro existenci autora
            bool existenceAutor = false;

           //Průchod pole Autori
           for (int i = 0; i < Autori.Length; i++)
           {
                //kontrolujeme, jestli nová přidáná kniha nemá autora, kterého již máme zaznamenaného v poli Autori
                if (Autori[i] == Knihy[Knihy.Length-1].AutorK)
                {
                    //nalezený autor, co již existuje
                    existenceAutor = true;
                }
           }

           if(!existenceAutor)
            {
                Array.Resize(ref Autori, Autori.Length + 1);
                //Dole pole Autori jsme pridali na nový index objekt AutorK z vlastnosti poslední pridané knihy (objekt) v poli Knihy
                Autori[Autori.Length - 1] = Knihy[Knihy.Length - 1].AutorK;
            }
            
        }

        //Metoda na výpis knih, co mají jednoho autora
        public string VyhledejPresAutor(string jmenoA)
        {
            string pomoc = "";
            //Průchod polem Knihy, kde jsou uložené objekty z třídy Kniha
            for (int i = 0; i < Knihy.Length; i++)
            {
                //Podmínka -- Pokud na procházeném indexu pole Knihy je objekt, který má vlastnost AutorK, což je objekt z třídy Autor, tak pokud tento objekt má vlastnost Jmeno rovnou parametru
                if (Knihy[i].AutorK.Jmeno == jmenoA)
                {
                    //Do pomocné proměnné přidáme vlastnost Nazev na procházeném prvku v poli
                    pomoc += Knihy[i].Nazev + ", ";
                }
            }
            return pomoc;
        }
    }
}
