namespace Abstrakce_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Savec novy_sav = new Savec
            {
                name = "alik",
                age = 12
            };

            novy_sav.IdentifySelf();
            novy_sav.MakeSound();

            Plaz novy_plaz = new Plaz
            {
                name = "Had",
                age = 1
            };

            novy_plaz.IdentifySelf();
            novy_plaz.MakeSound();

        }
    }
}
