namespace Proc_Svah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zde je použijte a zavolejte na ně výpis
            VypisPole(Svah(8)); //až bude hotovo, odkomentujte si
            VypisPole(SikmySvah(5)); //až bude hotovo, odkomentujte si

            //zde jsou volání pro level 3
            //VypisPole(Svah(4, "jih"));
            //VypisPole(Svah(4, "zapad"));
        }

        public static int[,] Svah(int strana)
        {
            int[,] svah = new int[strana,strana];

            for (int i = 0; i < svah.GetLength(0); i++) //Vnější cyklus po řádcích
            {
                for (int j = 0; j < svah.GetLength(1); j++) //Vnitřní po sloupcích
                {
                    svah[i, j] = j;
                    //j se při průchodu řádkem zvyšuje s každým sloupcem o 1
                }
            }

            return svah;
        }

        public static int[,] SikmySvah(int strana)
        {
            int[,] svah = new int[strana, strana];

            for (int i = 0; i < svah.GetLength(0); i++) //Vnější cyklus po řádcích
            {
                for (int j = 0; j < svah.GetLength(1); j++) //Vnitřní po sloupcích
                {
                    svah[i, j] = j+i;
                    //j na každém řádku je 0 a s každým sloupcem se zvyšuje o 1.
                    //i na první řádku je 0 a s přechodem na každý další řádek se o 1 zvýší.
                    /*
                     * i+j = 0+0=0 i+j 0+1=1
                     * i+j = 1+0=1 i+j 1+1=2
                    */
                }
            }

            return svah;
        }



        public static void VypisPole(int[,] pole)
        {
            //do kódu této metody nezasahujte
            for (int y = 0; y < pole.GetLength(0); y++)
            {
                for (int x = 0; x < pole.GetLength(1); x++)
                {
                    Console.Write(pole[y, x]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
