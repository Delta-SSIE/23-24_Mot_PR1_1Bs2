namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej mi číslo měsíce?");
            int mesic = int.Parse(Console.ReadLine());

            /*
            switch (mesic)
            {
                case 1:
                    Console.WriteLine("Zima");
                    break;
                case 2:
                    Console.WriteLine("Zima");
                    break;
            }
            */

            switch (mesic)
            {
                case int a when ((a < 3 && a > 0) || a == 12):
                    Console.WriteLine("Zima");
                    break;
                case int b when (b < 6 && b > 2):
                    Console.WriteLine("Jaro");
                    break;
                case int c when (c < 9 && c > 5):
                    Console.WriteLine("Léto");
                    break;
                case int d when (d < 12 && d > 8):
                    Console.WriteLine("Podzim");
                    break;
                default:
                    Console.WriteLine("Neplatný vstup!");
                    break;
            }
        }
    }
}
