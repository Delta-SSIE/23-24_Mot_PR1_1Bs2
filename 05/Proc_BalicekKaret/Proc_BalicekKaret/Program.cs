namespace Proc_BalicekKaret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] barvy = { "Kule", "Žaludy", "Listy", "Srdce" };
            string[] vysky = { "Sedma", "Osma", "Devítka", "Desítka", "Spodek", "Svršek", "Král", "Eso" };
            string[] balicek = new string[32];

            for (int i = 0; i < barvy.Length; i++)
            {
                for (int j = 0; j < vysky.Length; j++)
                {
                    balicek[j+(i*8)] = barvy[i] + " - " + vysky[j]; 
                }
               
            }
            foreach (string karta in balicek)
            {
                Console.WriteLine(karta);
            }
            Console.WriteLine();

            //Náhodná karta z balíčku
            Random gen = new Random();
            Console.WriteLine(balicek[gen.Next(0,32)]);
            Console.WriteLine();

            //Náhodné generování 10 karet, které nejsou stejné!
            string[] ruka = new string[10];
            for (int i = 0; i < ruka.Length; i++)
            {
                bool kontrola = false;
                string vybrana_karta = "";
                while (!kontrola)
                {
                    vybrana_karta = balicek[gen.Next(0, 32)];
                    foreach (string karta in ruka)
                    {
                        if(karta == vybrana_karta)
                        {
                            kontrola = true;
                        }
                    }
                    if(kontrola == true)
                    {
                        kontrola = false;
                    } else
                    {
                        kontrola = true;
                    }
                }
                ruka[i] = vybrana_karta;

            }
            foreach (string karta in ruka)
            {
                Console.WriteLine(karta);
            }


        }
    }
}
