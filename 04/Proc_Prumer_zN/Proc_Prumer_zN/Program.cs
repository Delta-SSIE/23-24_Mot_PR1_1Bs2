namespace Proc_Prumer_zN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pocet_cisel = 0;
            float soucet = 0;
            Console.WriteLine("Zadej mi počet čísel, kolik jich budeme načítat!");
            while (!float.TryParse(Console.ReadLine(), out pocet_cisel))
            {
                Console.WriteLine("Zadej pouze číslo!");
            }

            for (int i = 1; i <= pocet_cisel; i++)
            {
                float cislo = 0;
                do
                {
                    Console.WriteLine("Zadej mi {0}.čislo", i);
                } while (!float.TryParse(Console.ReadLine(), out cislo));
                soucet += cislo;
            }

            Console.WriteLine($"Průměr ze zadaných čísel je {soucet/pocet_cisel}");
        }
    }
}
