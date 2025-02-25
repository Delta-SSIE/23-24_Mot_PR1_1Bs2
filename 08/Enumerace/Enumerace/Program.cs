namespace Enumerace
{
    internal class Program
    {
        enum Pole
        {
            Voda,
            Lod,
            Zasah,
            Srela
        }

        enum Level
        {
            Low,
            Medium,
            Hard
        }
        static void Main(string[] args)
        {
            Pole policko = Pole.Lod; //nastavení proměnné na enumerační hodnotu
            Console.WriteLine(policko);

            Console.WriteLine((int) policko); //převod enum hodnoty na číslo
            Pole nove_policko = (Pole) ((int)policko)+1; //nová enum hodnota na základě číselné hodnoty jiné enum +1
            Console.WriteLine(nove_policko);

            policko = Pole.Voda;
            Console.WriteLine(policko);

            Level aktualni_uroven = Level.Low;
            Console.WriteLine(aktualni_uroven);
            aktualni_uroven = (Level)(int)aktualni_uroven+1;
            Console.WriteLine(aktualni_uroven);

        }
    }
}
