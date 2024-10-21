namespace Proc_Mala_nasobilka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi číslo a já ti vypíšu malou násobilkou tohoto čísla");
            int cislo = int.Parse(Console.ReadLine());
            int pocitadlo = 1;
            
            while(pocitadlo <= 10)
            {
                Console.WriteLine($"{cislo}x{pocitadlo}={cislo*pocitadlo}");
                pocitadlo++;
            }
        }
    }
}
