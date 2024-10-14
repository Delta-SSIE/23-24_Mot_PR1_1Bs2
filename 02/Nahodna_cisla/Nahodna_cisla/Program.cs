namespace Nahodna_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tvorba generátoru náhodných čísel (ten je v kodu pouze jednou)
            Random rand = new Random();

            //Náhodné číslo, které se vejde do int
            Console.WriteLine(rand.Next());

            //Nahodné čislo v určitém rozsahu
            Console.WriteLine(rand.Next(1, 7)); //dolní mez je 1, včetně a horní je 7.
            Console.WriteLine(rand.Next(0, 2)); //dolní mez je 1, včetně a horní je 1.

            //Generování desetinného čísla mezi 0 a 1
            Console.WriteLine(rand.NextDouble());

            //Generování náhodného znaku
            int a = rand.Next(65, 91);
            char b = Convert.ToChar(a);
            Console.WriteLine(b);


        }
    }
}
