namespace Pole_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace pole
            int[] pole_cisel; //deklarace pole čísel bez hodnot
            string[] pole_textu; //deklarace pole stringů (textů) bez hodnot

            //Deklarace pole s hodnotami
            int[] cisla = { 10, 20, 30, 50, 70, -22, 100 };
            string[] jmena = { "Honza", "Lukáš", "Petr" };

            //Výpis prvků z pole
            Console.WriteLine(cisla[2]); //vypíše číslo na 2 indexu (30)
            Console.WriteLine(cisla[0]); //vypíše číslo na 0 indexu (10)
            Console.WriteLine(cisla[cisla.Length - 1]); //vypíše číslo na posledním (délka pole (7) - 1 = 6) indexu (100)
            Console.WriteLine(jmena[1]); //vypíše string na 1 inedxu (Lukáš)

            //Přepisování hodnot v poli
            cisla[0] = 50; //přepíše hodnotu cisla na 0. indexu (původní hodnota je 10) na novou hodnotu 50;
            Console.WriteLine(cisla[0]);
            jmena[0] = "Petr"; //přepíše hodnotu stringu na 0.indexu (původní hodnota je "Honza") na novou hodnotu "Petr"

            //Deklarace pole s pevně určenou délkou bez hodnot
            int[] pole_cisel2 = new int[8]; //pole pole_cisel2 má délku 8 (tzn. indexy 0 až 7) nyní prázdných hodnot

            //for cyklus pro výpis pole
            for (int i = 0; i < cisla.Length; i++)
            {
                Console.Write(cisla[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < jmena.Length; i++)
            {
                Console.Write(jmena[i] + " ");
            }
            Console.WriteLine();

            //průchod pomocí foreach
            foreach (int cislo in cisla)
                //V rámci průchodu foreache se bude do proměnné čislo načítat vždy hodnota v kolekci čísla 
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();

            foreach (string jmeno in jmena)
            {
                Console.Write(jmeno + " ");
            }
            Console.WriteLine();

        }
    }
}
