namespace Proc_Namaluj_ctverec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int delka = 0;
            Console.WriteLine("Jaká bude délka hrany čtverce?");
            while(!int.TryParse(Console.ReadLine(),out delka))
            {
                Console.WriteLine("Zadej číslo!");
            }

            for (int i = 0; i < delka; i++)
            {
                for (int j = 0; j < delka; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }
    }
}
