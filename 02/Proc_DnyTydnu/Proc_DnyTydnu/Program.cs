namespace Proc_DnyTydnu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo dne? (1-7) ");
            int cislo = int.Parse(Console.ReadLine());

            /*
            if(cislo == 1)
            {
                Console.WriteLine("Pondělí");
            } else if (cislo == 2)
            {
                Console.WriteLine("Úterý");
            }
            */

            //Switch
            switch(cislo)
            {
                case 1:
                    Console.WriteLine("Pondělí");
                    break;
                case 2:
                    Console.WriteLine("Úterý");
                    break;
                case 3:
                    Console.WriteLine("Středa");
                    break;
                case 4:
                    Console.WriteLine("Čtvrtek");
                    break;
                case 5:
                    Console.WriteLine("Pátek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Neděle");
                    break;
                default: //default se spustí kdykoliv, kdy hodnota proměnné cislo neodpovídá žádnému case
                    Console.WriteLine("Neplatný vstup");
                    break;
            }
        }
    }
}
