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
            for (int i = 0; i < 4; i++)
            {
                hracPole = VlozLod(hracPole, true);
                protiPole = VlozLod(protiPole, false);
            }
            
        }

        //Metoda na vložení lodě na plochu
        static int[,] VlozLod(int[,] m, bool hrac)
        {
            int r = 0;
            int s = 0;
            Random gen = new Random();
            //Rozhoduje se zda se budou souřadnice zadávat, či se budou v případě PC hráče generovat
            if(hrac)
            { 
                Console.Clear();
                VykresliMapu(m);
                Console.WriteLine("Zadej souřadnici řádkovou");
                r = ZadaniSouradnice();
                Console.WriteLine("Zadej souřadnici sloupcovou");
                s = ZadaniSouradnice();
            } else
            {
                r = gen.Next(0, m.GetLength(0));
                s = gen.Next(0, m.GetLength(1));
            }

            //Ověření souřadnic přes metody
            if (!OverPole(m,r, s))
            {
                VlozLod(m, hrac);
            }
            if(!OverLod(m, r, s))
            {
                VlozLod(m, hrac);
            }

            //Vložení lodě a poslání pole zpět
            m[r, s] = 1;
            return m;
        }

        //Metoda zadaní souřadnice
        static int ZadaniSouradnice()
        {
            int s = 0;
            while (!int.TryParse(Console.ReadLine(), out s))
            {
                Console.WriteLine("Zadej číslo");
            }
            return s;
        }

        //Metoda na ověření zda-li na souřadnicích už není loď
        static bool OverLod(int[,] mapa, int sr, int ss)
        {
            bool podminka = true;
            if (mapa[sr,ss] == 1)
            {
                podminka = false;
            }
            return podminka;
        }

        //Metoda na ověření zda-li souřadnice jsou v poli
        static bool OverPole(int[,] mapa, int sr, int ss)
        {
            bool podminka = true;
            if(sr < 0 || sr >= mapa.GetLength(0) || ss < 0 || ss >= mapa.GetLength(1))
            {
                podminka = false;
            }
            return podminka;
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
