namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            //Sčítání
            Console.WriteLine(y+x);
            //Odčítání
            Console.WriteLine(y - x);
            //Násobení
            Console.WriteLine(x * y);
            //Dělení
            Console.WriteLine(y / x);

            //Modulo
            Console.WriteLine(6 % 2);
            Console.WriteLine(7 % 2);

            //Inkriminace (zvýšení hodnoty čísla o 1)
            x++;

            //Deinkriminace (snížení hodnoty čísla o 1)
            x--;

            //Přířazovací operátoy
            //Zvýšení hodnoty x o 3 ( x = x + 3)

            x += 3; // x = x + 3;
            x -= 3; // x = x - 3;

            //Porovnávací operátory

            Console.WriteLine(x > y);
            Console.WriteLine(x < y);

            Console.WriteLine(5 == 5); //rovná se jsou DVĚ znamení "="

            Console.WriteLine(6 >= 6); //větší, nebo rovno

        }
    }
}
