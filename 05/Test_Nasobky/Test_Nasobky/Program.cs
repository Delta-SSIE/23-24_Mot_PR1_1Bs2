namespace Test_Nasobky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velikost_pole = 0;
            int nasobky = 0;
            Console.WriteLine("Zadej mi velikost pole");
            while(!int.TryParse(Console.ReadLine(),out velikost_pole))
            {
                Console.WriteLine("Zadej čislo");
            }
            Console.WriteLine("Zadej mi násobky, které mám do pole vypsat!");
            while (!int.TryParse(Console.ReadLine(), out nasobky))
            {
                Console.WriteLine("Zadej čislo");
            }

            int[] pole_nasobku = new int[velikost_pole];

            for (int i = 0; i < pole_nasobku.Length; i++)
            {
                pole_nasobku[i] = (i + 1) * nasobky;
            }

            int index = 0;
            int pocet = 0;
            bool kontrola_index = false;
            bool kontrola_pocet = false;

            Console.WriteLine("Zadej mi index od kterého chceš prvky vypsat");
            while(!kontrola_index)
            { 
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Zadej čislo");
            }
            if(index >= 0 && index < velikost_pole)
            {
                kontrola_index = true;
            } else
                {
                    Console.WriteLine("Zadej index, který odpovídá poli!");
                }
            }

            Console.WriteLine("Zadej mi počet prvků, co chceš vypsat");
            while (!kontrola_pocet)
            {
                while (!int.TryParse(Console.ReadLine(), out pocet))
                {
                    Console.WriteLine("Zadej čislo");
                }
                if (pocet > 0 && pocet+index < velikost_pole)
                {
                    kontrola_pocet = true;
                }
                else
                {
                    Console.WriteLine("Zadej počet, který lze v poli realizovat!");
                }
            }

            for (int i = index; i < index+pocet; i++)
            {
                Console.WriteLine(pole_nasobku[i]);
            }
        }
    }
}
