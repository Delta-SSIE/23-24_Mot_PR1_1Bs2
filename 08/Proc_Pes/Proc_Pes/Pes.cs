using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proc_Pes
{
    internal class Pes
    {
        //Veřejené datové položky
        public string Jmeno;
        public int Nohy;
        public bool JeOckovany;

        //Veřejná metoda
        public string PredstavSe()
        {
            //pomocná proměnná pro definici zda je či není očkovaný
            string ockovani = (JeOckovany) ? "jsem" : "nejsem";
            return $"Já jsem pes, jmenuju se {Jmeno}, mám {Nohy} nohy a {ockovani} očkovaný";
        }
    }
}
