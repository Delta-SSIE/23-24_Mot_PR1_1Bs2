namespace Proc_NajdiPrvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { -11, 0, 5, -12, 13, 24, 19, 13, -17 };
            int cislo = 0;
            int index = -1; //proměnná pro index pro ověření nastavená nesmyslná hodnota

            Console.WriteLine("Napiš mi číslo, které hledáš?");
            while(!int.TryParse(Console.ReadLine(), out cislo))
            {
                Console.WriteLine("Zadej čislo!");
            }

            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] == cislo)
                {
                    index = i;
                    break; //vyskočení z cyklu ven
                }
            }

            if(index == -1) //ověření nalezení čísla
            {
                Console.WriteLine($"{cislo} se nenachází v poli.");
            } else
            {
                Console.WriteLine($"{cislo} se nachází v poli na indexu: {index}.");
            }
        }
    }
}
