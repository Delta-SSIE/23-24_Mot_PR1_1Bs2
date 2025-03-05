using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovny
{
    internal class Autor
    {
        public string Jmeno;
        public int RokNar;

        public Autor(string jmeno_autor)
        {
            Jmeno = jmeno_autor;
            Console.WriteLine("Zadej mi jeho rok narození");
            RokNar = int.Parse(Console.ReadLine());
        }
    }
}
