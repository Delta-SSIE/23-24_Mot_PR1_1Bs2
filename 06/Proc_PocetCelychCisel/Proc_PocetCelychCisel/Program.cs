namespace Proc_PocetCelychCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { 1.3, 1.7, 2, 3.1, 0.1, -1 };

            Console.WriteLine(
                "Pole  [{0}] obsahuje {1} celých čísel",
                string.Join("; ", cisla),
                PocetCelych(cisla)
            );

            double[] cisla2 = { 1, 1.8, 2.3, 3, 1.1, -1.1, 5.2, 6, 4.7 };

            Console.WriteLine(
                "Pole  [{0}] obsahuje {1} celých čísel",
                string.Join("; ", cisla2),
                PocetCelych(cisla2)
            );
        }

        //Metoda vrací hodnotu int
        //Metoda má parametr pole desetinných číseldes_pole
        static int PocetCelych(double[] des_pole)
        {
            int pocet_cel = 0;
            for (int i = 0; i < des_pole.Length; i++)
            {
                if (des_pole[i] % 1 == 0)
                {
                    pocet_cel++;
                }
            }
            return pocet_cel;
        }
    }
}
