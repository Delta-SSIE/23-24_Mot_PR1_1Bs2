namespace Proc_Kresleni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] mapa =
         {
            {  true, false, false,  true, false, false,  true},
            { false,  true, false,  true, false,  true, false},
            { false, false,  true,  true,  true, false, false},
            { false, false, false,  true, false, false, false},
         };

            VykresliPole(mapa);
            VykresliPole2(mapa,'X','-');
            VykresliPole2(mapa); //druhý a třetí parametr použije předepsanou hodnotu
            VykresliPole2(mapa,'0'); //třetí parametr si vezme předepsanou hodnotu

        }

        static void VykresliPole(bool[,] pole)
        {
            for (int i = 0; i < pole.GetLength(0); i++) //řádky
            {
                for (int j = 0; j < pole.GetLength(1); j++) //sloupce
                {
                    if (pole[i, j]) //pokud ta hodnota je true, tak je podmínka splněna
                    {
                        Console.Write('#');
                    } else
                    {
                        Console.Write(' ');
                    }

                    /*Terární operátor (shorthand if)
                    Console.Write((pole[i, j] ? '#' : ' '));
                    Je to to stejné, co nahoře, akorát zkráceně zapsáno
                    */
                }
                Console.WriteLine(); //zalomení na konci řádku
            }
        }

        static void VykresliPole2(bool[,] pole, char znakT = '#', char znakF = ' ')
            //Předepsaná hodnota u parametrů, naplní je když je argument nedefinuje
        {
            for (int i = 0; i < pole.GetLength(0); i++) //řádky
            {
                for (int j = 0; j < pole.GetLength(1); j++) //sloupce
                {
                    if (pole[i, j]) //pokud ta hodnota je true, tak je podmínka splněna
                    {
                        Console.Write(znakT);
                    }
                    else
                    {
                        Console.Write(znakF);
                    }

                    /*Terární operátor (shorthand if)
                    Console.Write((pole[i, j] ? znakT : znakF));
                    Je to to stejné, co nahoře, akorát zkráceně zapsáno
                    */
                }
                Console.WriteLine(); //zalomení na konci řádku
            }
        }
    }
}
