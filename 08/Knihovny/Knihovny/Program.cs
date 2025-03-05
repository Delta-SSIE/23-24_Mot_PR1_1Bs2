namespace Knihovny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi název knihovny.");
            string nazevK = Console.ReadLine();
            Console.WriteLine("Zadej mi lokaci knihovny.");
            string lokaceK = Console.ReadLine();

            Knihovna moje_knihovna = new Knihovna(nazevK,lokaceK);

            //menu
            while(true)
            {
                Console.Clear();
                Console.WriteLine($"{moje_knihovna.Nazev} v lokaci: {moje_knihovna.Lokace}");
                Console.WriteLine("Pro přidání knihy (1) a pro výpis (2)");
                int vyber = int.Parse(Console.ReadLine());

                switch(vyber)
                {
                    case 1:
                        moje_knihovna.PridejKnihu();
                        break;
                    case 2:
                        Console.WriteLine("Zadej mi jméno autora");
                        string autor = Console.ReadLine();
                        Console.WriteLine(moje_knihovna.VyhledejPresAutor(autor));
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
