namespace CyklusFor_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1 /*1.*/; i < 11/*2.*/; i++/*3.*/)
            //1. Stane se přesně jednou při spuštění celého cyklu!
            //2. Podmínka, která se kontroluje při každém spuštění těla cyklu.
            //3. Stane se vždy na konci průchodu těla cyklu!
            {
                Console.WriteLine("Hodnota i je {0}",i);
            }

            //Počitadlo naopak, snižování hodnoty i
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Hodnota i je {0}", i);
            }

            //Použití dvou cyklů v sobě
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
                
            }
        }
    }
}
