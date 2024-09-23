namespace Proc_obsahCtverce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sem přijde váš kód

            Console.WriteLine("Zadej mi stranu A");
            // int stranaA = int.Parse(Console.ReadLine()); //Parsování vstupu na int
            int stranaA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Obsah čtverce je {stranaA*stranaA}");
            Console.WriteLine("Obsah čtverce je {0}", stranaA * stranaA);
            Console.WriteLine("Obsah čtverce je " + stranaA * stranaA);

            // Konec prostoru pro kód
        }
    }
}
