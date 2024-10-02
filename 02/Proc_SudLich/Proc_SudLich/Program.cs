namespace Proc_SudLich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej mi číslo: ");
            int cislo = int.Parse(Console.ReadLine());

            if (cislo == 0)
            {
                Console.WriteLine("Číslo je nula!");
            } else if (cislo % 2 == 0)
            {
                Console.WriteLine("Čislo je sudé!");
            } else
            {
                Console.WriteLine("Číslo je liché!");
            }
        }
    }
}
