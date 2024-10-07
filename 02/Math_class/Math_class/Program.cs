namespace Math_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine(Math.Min(x, y)); //Min vypíše menší ze dvou hodnot
            Console.WriteLine(Math.Max(x, y)); //Max vypíše větší ze dvou hodnot

            Console.WriteLine(Math.Sqrt(25)); //Sqrt je druhá odmocnina z čísla zadaného

            Console.WriteLine(Math.Pow(5, 2)); //Pow v závorce je zapsáno číslo a pak jeho mocnitel (v našem případě 5 na 2)

            Console.WriteLine(Math.Abs(-2)); //Absolutní hodnota

            Console.WriteLine(Math.Round(2.55)); //Zaokrouhlení na celé číslo
            Console.WriteLine(Math.Round(2.4)); //Zaokrouhlení na celé číslo

            Console.WriteLine(Math.PI); //hodnota PI
            Console.WriteLine(Math.E); //Eulerovo číslo

        }
    }
}
