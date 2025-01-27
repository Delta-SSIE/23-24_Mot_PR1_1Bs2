namespace _2DPole_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarace vícerozměná pole
            int[,] dvou_pole; //2D pole
            int[,,] tri_pole; //3D pole

            //inicializace 2D pole s hodnotami
            int[,] d2_pole = { {5,7,8 }, {11, 50, 3 } };
            //jednotlivé řádky v poli jsou uvozeny {}, tzn. 5,7,8 je jeden řádek a 11,50,3 je druhý řádek

            //Výpis prvku z pole
            Console.WriteLine(d2_pole[1, 1]); //výpis prvku na řádku s indexem 1 a sloupcem na indexu 1 => 50
            Console.WriteLine(d2_pole[0, 2]); //výpis prvku na řádku s indexem 0 a sloupcem na indexu 2 => 8
            //[index řádku, index sloupce]

            //Změna hodnoty na konkrétním indexu
            d2_pole[1, 1] = 30; //změna hodnoty na [1,1] ==> 50 se změní na 30

            //Výpis všech prvků v poli
            foreach (int cislo in d2_pole)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();
            //Vypisuje všechny prvky v 2D poli za sebou do řádku
            //Nejdříve vypíše prvky na řádku s indexem 0 od indexu sloupce 0, pak přechází na řádek další a pokračuje!

            //Určení počtu řádků a sloupců pole
            Console.WriteLine("Počet řádků: "+d2_pole.GetLength(0));
            Console.WriteLine("Počet sloupců: " + d2_pole.GetLength(1));

            //Výpis 2D pole pomocí vnějšího a vnitřního cyklu

            for (int i = 0; i < d2_pole.GetLength(0); i++) //Vnější cyklus -> Jde po řádcích, potřebuje jejich počet
            {
                for (int j = 0; j < d2_pole.GetLength(1); j++) //Vnitřní cyklus -> Jde po sloupcích, potřebuje jejich počet
                {
                    Console.Write(d2_pole[i,j] + " ");
                    //i v sobě nese index řádku a j v sobě nese index sloupce
                }
                Console.WriteLine(); //zalomení řádku na konci řádku v poli
            }

            //Deklarace 2D pole s předem určenou velikostí
            string[,] d2_text = new string[5, 10]; //pole o 5 řádcích a 10 sloupcích 
            Console.WriteLine("Počet řádků: " + d2_text.GetLength(0));
            Console.WriteLine("Počet sloupců: " + d2_text.GetLength(1));
        }
    }
}
