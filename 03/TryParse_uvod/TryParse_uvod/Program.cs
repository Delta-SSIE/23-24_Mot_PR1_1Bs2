namespace TryParse_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstup = Console.ReadLine();
            int cislo = 0;

            Console.WriteLine(int.TryParse(vstup, out cislo));
            //datovytyp.TryParse(vstupni string, out proměnná datového typu do kterého parsujeme)
            Console.WriteLine(cislo);

            //Načtení vstupu od uživatele přímo v TryParse a deklarování proměnné uvnitř též
            int.TryParse(Console.ReadLine(), out int cislo2);
            Console.WriteLine(cislo2);

            //Bezpečné načtení proměnné od uživatele TryParse + While
            int cislo3 = 0;
            while (!int.TryParse(Console.ReadLine(),out cislo3))
                //Negace – Dokud nelze parsovat do int, tak se opakuj!
            {
                Console.WriteLine("Zadej čislo!");
            }
            Console.WriteLine(cislo3);

            //Alternativa s DoWhile
            int cislo4 = 0;
            do
            {
                Console.WriteLine("Zadej čislo!");
            } while (!int.TryParse(Console.ReadLine(), out cislo4));
            Console.WriteLine(cislo4);
        }
    }
}
