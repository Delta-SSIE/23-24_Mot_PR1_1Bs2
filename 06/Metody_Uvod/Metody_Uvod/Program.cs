namespace Metody_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pozdrav(); //zavolání metody

            for (int i = 0; i < 10; i++)
            {
                Pozdrav(); //desetkrát se zavolá metoda Pozdrav
            }

            for (int i = 0; i < 10; i++)
            {
                Dvojnasob(i); //Zavolání metody Dvojnásob s argumentem i, který naplní parametr cislo.
            }

            //Volání metody vždy s jiným argumentem odpovídají datovému typu parametru!
            Pozdrav_v2("John");
            Pozdrav_v2("Daniel");
            Pozdrav_v2("Lucas");

            //Volání metody s dvěma parametry (tedy vkládám dva argumenty)
            Nasob(5, 10); //cislo = 5; nasobek = 10

            //Volání metody s předepsanou hodnotou
            Pozdrav_v2(); //Pokud nedám vlastní argument, tak se vypíše předepsaná hodnota
            Pozdrav_v2("Henry"); //Pokud dám vlastní argument, tak ten přepíše předepsanou hodnotu!

            //Zavolání metody s návratovou hodnotu
            int a = overCislo(); //metoda mi vratí hodnotu, která naplní proměnnou (a)
            int b = overCislo();
            Console.WriteLine(a + b);

            //Zavolání metody s návratovou hodnotou a vstupním parametrem
            int[] pole1 = new int[20];
            int[] pole2 = new int[50];

            pole1 = naplnPole(pole1);
            pole2 = naplnPole(pole2);

            vypisPole(pole1);
            vypisPole(pole2);

        }

        //Nová metoda, která nevrací hodnotu (void) s názvem Pozdrav
        static void Pozdrav()
        {
            Console.WriteLine("Hello!");
        }

        //Metoda s parametrem (int cislo)
        static void Dvojnasob(int cislo)
        {
            Console.WriteLine(cislo*2); //parametr vynásobí dvěma a vypíše do konzole
        }

        //Metoda s parametrem (string jmeno)
        //Parametr má předepsanou hodnotu "Larry"
        static void Pozdrav_v2(string jmeno = "Larry")
        {
            Console.WriteLine("Hello " + jmeno);
        }

        //Metoda s dvěma parametry (int cislo, int nasobek)
        static void Nasob(int cislo, int nasobek)
        {
            Console.WriteLine(cislo*nasobek);
        }

        //Metoda vracející hodnotu (místo void se píše datový typ návratové proměnné)
        static int overCislo()
        {
            int cislo = 0;
            while(!int.TryParse(Console.ReadLine(),out cislo))
            {
                Console.WriteLine("Zadej číslo!");
            }
            return cislo; //metoda vrací hodnotu proměnné číslo!
        }

        //Metoda s návratovou hodnotou pole s parametrem vstupního pole
        static int[] naplnPole(int[] pole)
        {
            Random gen = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = gen.Next(1, 11);
            }
            return pole;
        }

        static void vypisPole(int[] pole)
        {
            foreach (int cislo in pole)
            {
                Console.Write(cislo + ", ");
            }
            Console.WriteLine();
        }
    }
}
