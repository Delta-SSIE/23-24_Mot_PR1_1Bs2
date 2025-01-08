namespace Proc_KolikatyJsem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KolikatyJsem([12,15,11,4,10,13,14],2));
        }

        static int KolikatyJsem(int[] vysledky, int index)
        {
            /* předpoklad, že náš zkoumaný student je poslední 
            int poradi = vysledky.Length;
            for (int i = 0; i < vysledky.Length; i++)
            {
                if (vysledky[i] < vysledky[index] && index != i)
                {
                    poradi--;
                }
            }
            */

            //předpoklad, že je první
            int poradi = 1;
            for (int i = 0; i < vysledky.Length; i++)
            {
                if (vysledky[i] > vysledky[index] && index != i)
                {
                    poradi++;
                }
            }
            return poradi;
        }
    }
}
