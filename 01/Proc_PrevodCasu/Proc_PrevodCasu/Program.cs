namespace Proc_PrevodCasu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarace proměnných
            int minuty = 0;
            int hodiny = 0;

            Console.WriteLine("Zadej mi čas v sekundách");
            int sekundy = int.Parse(Console.ReadLine());

            //Převod sekund na minuty
            minuty = (sekundy - (sekundy % 60)) / 60;
            sekundy = sekundy % 60;

            //Převést minuty na hodiny
            hodiny = (minuty - (minuty % 60)) / 60;
            minuty = minuty % 60;

            Console.WriteLine($"Máme sekund: {sekundy}; minut: {minuty}; hodin: {hodiny}");
        }
    }
}
