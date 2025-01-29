namespace Proc_TransponujPole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabulka1 =
            {
                {3, 4, 7},
                {5, 9, 1},
                {1, 3, 2}
            };

            Console.WriteLine();

            int[,] tabulka2 =
            {
                {3, 1, 0},
                {2, 4, 5},
                {6, 7, 1},
                {0, 1, 2}
            };

            Console.WriteLine();

            int[,] transpozice1 = Transponuj(tabulka1);
            Vypis2DPole(transpozice1);

            int[,] transpozice2 = Transponuj(tabulka2);
            Vypis2DPole(transpozice2);

            //tohle by mělo vypsat nezměněné pole tabulka1 - jsou tam 2 transpozice za sebou
            Vypis2DPole(Transponuj(Transponuj(tabulka1)));
        }

        static int[,] Transponuj(int[,] pole)
        {
            int[,] tabulka = new int[pole.GetLength(1),pole.GetLength(0)];
            //Nové pole tabulka bude mít velikost danou vstupním polem
            //Dle jejího počtu sloupců bude mít počet řádků a naopak

            for (int i = 0; i < pole.GetLength(1); i++) //Vnější - sloupce původního pole
            {
                for (int j = 0; j < pole.GetLength(0); j++) //Vnitřní cyklus - řádky původího pole
                {
                    tabulka[i,j] = pole[j,i];
                    //vložení prvků z původního pole do nového
                }
            }

            return tabulka;
        }

        public static void Vypis2DPole(int[,] pole)
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
