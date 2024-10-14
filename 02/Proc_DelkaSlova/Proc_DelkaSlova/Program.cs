namespace Proc_DelkaSlova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej 1. slovo");
            string slovo1 = Console.ReadLine();
            Console.WriteLine("Zadej 2. slovo");
            string slovo2 = Console.ReadLine();

            if(slovo1.Length == slovo2.Length) //string.Lenght vrací délku daného textu v čísle
            {
                Console.WriteLine("Slova jsou stejně dlouhá");
            } else if (slovo1.Length > slovo2.Length)
            {
                Console.WriteLine($"1. slovo: {slovo1} je delší než 2. slovo");
            } else
            {
                Console.WriteLine($"2. slovo: {slovo2} je delší než 1. slovo");
            }
        }
    }
}
