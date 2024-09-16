namespace Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tohle je komentář na jeden řádek

            /*
             * Tohle
             * je
             * komentář
             * na
             * více
             * řádků
             */

            //Výstup pro uživatele se zalomením řádku
            Console.WriteLine("Ahoj světe!");
            Console.WriteLine("Tohle je můj první program");

            //Výstup pro uživatele bez zalomení řádku
            Console.Write("Tohle je jeden text. ");
            Console.Write("Tohle je druhý text.");
            Console.WriteLine();

            //Deklarace proměné s hodnotou (int = celé číslo)
            int me_cislo = 10;
            //Deklarace proměné a pozdější vložení hodnoty. (string = textový řetězec)
            string jmeno;
            jmeno = "Marek";

            //Zavolání proměných 
            Console.WriteLine(me_cislo);
            Console.WriteLine(jmeno);

            //Deklarace proměných (více v jednom řádku)
            int x = 5, y = 6;

            //Vložení hodnoty z proměné x do proměné me_cislo
            me_cislo = x;

            //Výpis více proměných v rámci jednoho Console.Write...
            Console.WriteLine("me_cislo:" + me_cislo + " x:" + x + " y:" + y);

            //Výpis hodnot v jednom Console.WriteLine
            Console.WriteLine("Ahoj, mé jméno je " + jmeno + " a je mi " + me_cislo + " let.");

            //Výpis hodnot v jednom řádku pomocí $
            Console.WriteLine($"Ahoj, mé jméno je {jmeno} a je mi {me_cislo} let.");

            //Výpis hodnot v jednom řádku pomocí pořadových čísel
            Console.WriteLine("Ahoj, mé jméno je {0} a je mi {1} let.", jmeno, me_cislo);



        }
    }
}
