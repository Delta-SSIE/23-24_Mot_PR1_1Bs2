namespace Uvod_Slovnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace slovníku key-string a value-int
            Dictionary<string, int> dluznici = new Dictionary<string, int>();

            //přidání hodnot do slovníku
            dluznici.Add("Jarda", 1000);
            dluznici.Add("Pepa", 500);
            dluznici.Add("Lujza", 100);
            dluznici.Add("Ivana", 20);

            //procházení slovníkem

            //Procházení po klíčích
            foreach (string dluznik in dluznici.Keys)
            {
                Console.Write(dluznik + ", ");
            }
            //Procházení po hodnotách
            foreach (int dluh in dluznici.Values)
            {
                Console.Write(dluh + ", ");
            }
            Console.WriteLine();

            //Procházení po klíčích a hodnotách zároven
            //do zaznam se nahraje objekt klíče a hodnoty na daném prvku
            //s atributem Key (kde je hodnota klíče) a atributem Value (kde je hodnota hodnoty)
            foreach (KeyValuePair<string,int> zaznam in dluznici)
            {
                Console.WriteLine($"{zaznam.Key} mi dluží {zaznam.Value}");
            }


            //Zkusí najít hodnotu pro klíč "Lujza", pokud takový klíč najde jeho hodnota se uloží do proměnné dluh
            int castka = 0;
            dluznici.TryGetValue("Lujza", out castka);
            Console.WriteLine(castka);
            castka = 0;
            dluznici.TryGetValue("Petr", out castka);
            Console.WriteLine(castka);

            //Nastavení hodnoty na klíči
            dluznici["Ivana"] += 100;
            dluznici["Jarda"] = 0;
            foreach (KeyValuePair<string, int> zaznam in dluznici)
            {
                Console.WriteLine($"{zaznam.Key} mi dluží {zaznam.Value}");
            }

            //Smazaní záznamu ze slovníku podle klíče
            dluznici.Remove("Jarda");
            foreach (KeyValuePair<string, int> zaznam in dluznici)
            {
                Console.WriteLine($"{zaznam.Key} mi dluží {zaznam.Value}");
            }

            //Hledání záznamu

            //existence klíče
            Console.WriteLine(dluznici.ContainsKey("Lujza")); //true
            Console.WriteLine(dluznici.ContainsKey("Jarmila")); //false

            //existence hodnoty
            Console.WriteLine(dluznici.ContainsValue(1000)); //false
            Console.WriteLine(dluznici.ContainsValue(120)); //true

        }
    }
}
