namespace Lode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = 5;
            int[,] hracPole = VytvorMapu(v);
            int[,] hracSonar = VytvorMapu(v);
            int[,] protiPole = VytvorMapu(v);

            VykresliMapu(hracPole);
        }

        //Metoda na vložení lodě na plochu
        static int[,] VlozLod(int[,] m)
        {
            
        }

        //Metoda na vypsání hrací plochy
        static void VykresliMapu(int[,] m)
        {
            //průchod 2D pole
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    switch(m[i,j])
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write('V');
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write('L');
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write('Z');
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write('S');
                            break;
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(); //zalomení na konci řádku
            }
        }

        //Metoda na tvorbu hrací plochy
        static int[,] VytvorMapu(int velikost)
        {
            //vytvoření čtvercového pole
            int[,] mapa = new int[velikost, velikost];
            //naplnění pole
            for (int i = 0; i < mapa.GetLength(0); i++)
            {
                for (int j = 0; j < mapa.GetLength(1); j++)
                {
                    mapa[i, j] = 0; //naplňuji pole vodou (0 = voda)
                }
            }
            //vracím 2d pole
            return mapa;
        }
    }
}
