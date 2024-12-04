namespace Proc_PoleSouctu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 20, 11, 0, 10, 7, 12, 83, 0, 0, 15 };
            int[] pole_souctu = new int[cisla.Length];

            for (int i = 0; i < pole_souctu.Length; i++)
            {
                /* Načítání hodnoty předchozího čísla v poli součtu
                if(i != 0)
                {
                    pole_souctu[i] += pole_souctu[i - 1];
                }
                */
                //Řešení přes průchod původním polem
                for (int j = i; j >= 0; j--)
                {
                    pole_souctu[i] += cisla[j];
                }
            }

            foreach (int cislo in pole_souctu) //výpis
            {
                Console.WriteLine(cislo);
            }
        }
    }
}
