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

            //Procvičení výpisu hodnot v jednom řádku (ulice + číslo popisné)
            string ulice = "Kamenická";
            int cislo_popisne = 15;
            Console.WriteLine($"Bydlím v ulici {ulice} a číslo popisné je {cislo_popisne}.");
            ulice = "Vojtkova";
            Console.WriteLine($"Bydlím v ulici {ulice} a číslo popisné je {cislo_popisne}.");

            //Long drží čísla nad 2 miliardy (int zvládne čísla do 2 miliard)
            // int a = 3000000000;
            long a = 3000000000;

            //Desetinná čísla
            float b = 2.12356789f; //vypíše pouze do 8 
            double c = 2.1234567891011121314151617181920d; //vypíše do 12
            Console.WriteLine($"float: {b} double: {c}");

            //Boolean (true/false)
            bool e = false;
            Console.WriteLine(e);

            //Character
            char d = 'B';
            Console.WriteLine(d);


            //Implicit casting char -> int
            int f = d;
            Console.WriteLine(f);

            //Implicit casting char -> float
            float g = d;
            Console.WriteLine(g);

            //Explicit casting int -> char (přidá se závorka navíc)
            int h = 102;
            char i = (char) h;
            Console.WriteLine(i);

            //Parsování string na int
            string text1 = "15";
            int cislo1 = int.Parse(text1); //syntaxe: datovyTyp.Parse(text)
            Console.WriteLine(cislo1 + 5);

            //Parsování string na float
            string text2 = "12,5";
            float cislo2 = float.Parse(text2);
            Console.WriteLine(cislo2 + 0.5);

            //Convertování string na int
            string text3 = "20";
            int cislo3 = Convert.ToInt32(text3);
            Console.WriteLine(cislo3 + 15);

            //Convert int na string
            int cislo4 = 20;
            string text4 = Convert.ToString(cislo4);
            Console.WriteLine(text4 + 24);

            //Vstup od uživatele
            Console.WriteLine("Zadej mi své jméno");
            string uziv_jmeno = Console.ReadLine();
            Console.WriteLine("Jmeno uživatele je \n{0}", uziv_jmeno);

            //Vstup od uživatele (ulice)
            Console.Write("Zadej mi název ulice: ");
            string uziv_ulice = Console.ReadLine();
            Console.WriteLine($"Uživatel jménem {uziv_jmeno} žije v ulici {uziv_ulice}");

            //Jednoduchá sčítačka (problematika načtení dat od uživatele, které nejsou string)
            Console.Write("Zadej mi číslo A: ");
            int cisloA = int.Parse(Console.ReadLine()); //Parsování vstupu
            Console.Write("Zadej mi číslo B: ");
            int cisloB = Convert.ToInt32(Console.ReadLine()); //Konvertování vstupu
            Console.WriteLine($"Uživatel zadal číslo A: {cisloA} a číslo B: {cisloB} a výsledek součtu těchto čísel je {cisloA+cisloB}");
        }
    }
}
