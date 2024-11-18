namespace Proc_Faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong cislo = 0;
            Console.WriteLine("Napiš číslo a já vypíšu faktoriál tohoto čísla");
            while (!ulong.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Zadal jsi špatný datový typ! Zadej číslo!");
            }

            for (ulong i = cislo-1; i > 0; i--)
            {
                cislo *= i;
            }

            Console.WriteLine(cislo);
        }
    }
}
