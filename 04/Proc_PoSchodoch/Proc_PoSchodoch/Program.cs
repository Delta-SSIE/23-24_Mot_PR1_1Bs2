namespace Proc_PoSchodoch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int patra = 0;
            Console.WriteLine("Kolik chceš pater?");
            while (!int.TryParse(Console.ReadLine(),out patra))
            {
                Console.WriteLine("Čislo!");
            }

            for (int i = 0; i < patra; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
