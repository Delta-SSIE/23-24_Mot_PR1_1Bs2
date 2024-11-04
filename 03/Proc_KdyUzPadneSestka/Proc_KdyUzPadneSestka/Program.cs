using System.Runtime.Intrinsics.Arm;

namespace Proc_KdyUzPadneSestka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random kostka = new Random();
            /* LEVEL1
            char odp = ' ';
            int pocet_hodu = 0;

            do
            {
                pocet_hodu = 1;
                while(kostka.Next(1,7) != 6)
                {
                    pocet_hodu++;
                }
                Console.WriteLine("K hození šestky bylo potřeba {0} hodů",pocet_hodu);
                Console.WriteLine("Chceš házet znovu, pokud ne stiskni 'n'!");
                odp = Console.ReadKey().KeyChar;
            } while (odp != 'n');
            */

            //LEVEL 2
            int pocet_hodu = 0;
            double celkem_hodu = 0;
            double pocet_kol = 0;
            int nejvyssi_pocet_hodu = 0;

            do
            {
                pocet_hodu = 1;
                celkem_hodu++;
                while (kostka.Next(1, 7) != 6)
                {
                    pocet_hodu++;
                    celkem_hodu++;
                }
                if (nejvyssi_pocet_hodu < pocet_hodu)
                {
                    nejvyssi_pocet_hodu = pocet_hodu;
                }
                pocet_kol++;
            } while (pocet_kol < 1000);

            Console.WriteLine($"Počet kol byl: {pocet_kol}\nPočet hodů celkově byl: {celkem_hodu}\nPrůměrný počet hodů na hod šestky je {celkem_hodu/pocet_kol}\nNejvyšší počet hodů pro hození šestky je {nejvyssi_pocet_hodu}");
        }
    }
}
