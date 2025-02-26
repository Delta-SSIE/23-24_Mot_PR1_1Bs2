namespace Exepctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vyjimka

            try
            {
                int cislo = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Nebylo zadáno číslo");
            }

            try
            {
                int cislo2 = Convert.ToInt32("deset");
            } catch (Exception error) //zachytává chybovou hlášku a ukládá do proměnné error
            {
                Console.WriteLine($"Chyba, zde je chybová hláška: {error}");
            }
        }
    }
}
