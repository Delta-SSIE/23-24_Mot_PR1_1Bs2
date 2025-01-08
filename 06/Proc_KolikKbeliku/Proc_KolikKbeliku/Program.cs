namespace Proc_KolikKbeliku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KolikKbeliku(3,4,2.8,18));
        }


        static int KolikKbeliku(double delka, double vyska, double sirka, double vydatnost)
        {
            double plocha = 2 * (delka * vyska) + 2 * (sirka * vyska) + delka * sirka;
            //4 stěny + 1 strop
            Console.WriteLine(plocha);
            double barva = plocha / vydatnost;
            if(barva % 1 != 0) //pokud je číslo desetinné, tak přidá jeden kyblik
            {
                return (int) barva + 1;
            }
              return (int)barva; //vracení hodnoty v případě celého čísla
        }
    }
}
