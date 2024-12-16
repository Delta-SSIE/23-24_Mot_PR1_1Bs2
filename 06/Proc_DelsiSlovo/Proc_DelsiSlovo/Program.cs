using System.Text;

namespace Proc_DelsiSlovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej první slovo: ");
            string slovo1 = Console.ReadLine();

            Console.Write("Zadej druhé slovo: ");
            string slovo2 = Console.ReadLine();

            string delsiSlovo = DelsiSlovo(slovo1, slovo2); //Zavolání metody s dvěma argumenty, vracící hodnotu do proměnné delsiSlovo
            Console.WriteLine($"Když porovnáme {slovo1} a {slovo2}, pak delší je {delsiSlovo}.");
        }

        static string DelsiSlovo(string a, string b) //dva parametry
        {
            if(a.Length > b.Length)
            {
                return a; //návratová hodnota
            } else
            {
                return b; //návratová hodnota
            }
        }
    }
}
