namespace Proc_Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;
            int max = 0;

            do
            {
                Console.WriteLine("Zadej mi číslo: ");
                while (!int.TryParse(Console.ReadLine(), out cislo))
                {
                    Console.WriteLine("Tohle není číslo!");
                }
                if (cislo > max)
                {
                    max = cislo;
                }
            } while (cislo > 0);

            if (max == 0)
            {
                Console.WriteLine("Nebylo zadáno žádné číslo!");
            } else
            {
                Console.WriteLine($"Nejvyšší zadané číslo bylo {max}");
            }
            
        }
    }
}
