using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovny
{
    internal class Kniha
    {
        public string Nazev;
        public int RokVyd;
        public Autor AutorK;

        public Kniha(string nazev, Autor autor, string jmeno_autor)
        {
            Nazev = nazev;
            Console.WriteLine("Zadej mi rok vydání knihy");
            RokVyd = int.Parse(Console.ReadLine());
            //Pokud konstruktor dostal v parametru autor objekt a né hodnotu null, tak rovnou doplní objekt do dané proměnné
            //V případě hodnoty null se vytvoří nový objekt Autor
            if(autor != null)
            {
                AutorK = autor;
            } else
            {
                AutorK = new Autor(jmeno_autor);
            }
            
        }
    }
}
