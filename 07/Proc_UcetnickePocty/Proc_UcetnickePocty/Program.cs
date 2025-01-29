namespace Proc_UcetnickePocty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] cisla = {
            {1, 0, 10, 4, 7},
            {2, 2, 3, 4, 2},
            {6, 5, 4, 3, 2}
        };

            Ucetni(cisla);
            Console.WriteLine();


            int[,] cisla2 = {
            {1, 0, 10, 4},
            {2, 2, 3, 4},
            {6, 5, 4, 3},
            {12, 0, 0, -1}
        };
            Ucetni(cisla2);

        }

        public static void Ucetni(int[,] poleCisel)
        {
            int pocitadlo = 0;
            for (int i = 0; i < poleCisel.GetLength(0); i++) //Vnější cyklus po řádcích
            {
                for (int j = 0; j < poleCisel.GetLength(1); j++) //Vnitřní cyklus po sloupcích
                {
                    Console.Write(poleCisel[i,j] + " ");
                    pocitadlo += poleCisel[i, j]; //přičtení hodnoty v sloupci
                }
                Console.Write("| " + pocitadlo); //vypis součtu hodnot na řádku
                pocitadlo = 0;
                Console.WriteLine();
            }
            int max = 0;
            Console.WriteLine("--------------------");
            for (int i = 0; i < poleCisel.GetLength(1); i++) //Vnější cyklus po sloupcích
            {
                for (int j = 0; j < poleCisel.GetLength(0); j++) //Vnitřní cyklus po řádcích
                {
                    pocitadlo += poleCisel[j, i]; //přičtení hodnoty na řádku
                }
                Console.Write(pocitadlo + " "); //vypis součtu hodnot ve sloupci
                max += pocitadlo;
                pocitadlo = 0;
            }
            Console.Write("| " + max);
            Console.WriteLine();
        }
    }
}
