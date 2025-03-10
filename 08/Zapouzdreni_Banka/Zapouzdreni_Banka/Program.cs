namespace Zapouzdreni_Banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucet mujUcet = new Ucet();
            mujUcet.JmenoDrzitele = "Lubor Zavora";
            mujUcet.Bilance = 200;


            while(true)
            {
                Console.WriteLine($"Učet na jméno: {mujUcet.JmenoDrzitele} \nZůstatek: {mujUcet.Bilance}");
                Console.WriteLine("Pokud chceš vybrat, tak napiš vyber, pokud chceš vložit, napiš vlozit!");
                string volba = Console.ReadLine();
                switch(volba)
                {
                    case "vyber":
                        double vyber = double.Parse(Console.ReadLine());
                        mujUcet.Bilance -= vyber;
                        break;
                    case "vlozit":
                        double vlozit = double.Parse(Console.ReadLine());
                        mujUcet.Bilance += vlozit;
                        break;
                    default:
                        Console.WriteLine("Neplatná možnost!");
                        break;
                }
            }
            
            
        }
    }
}
