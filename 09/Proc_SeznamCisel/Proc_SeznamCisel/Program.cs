namespace Proc_SeznamCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            List<int> seznamCisel = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                seznamCisel.Add(gen.Next(0, 1000000));
            }

            Console.WriteLine(seznamCisel.Sum());
            Console.WriteLine(seznamCisel.Sum()/seznamCisel.Count);

            Console.WriteLine(seznamCisel.Min());
            Console.WriteLine(seznamCisel.Max());

            Console.WriteLine(seznamCisel.Count());

            //Smaž z listu všechny prvky větší než 500 000
            /*
            for (int i = 499999; i < 1000000; i++)
            {
                while(seznamCisel.IndexOf(i) > 0)
                {
                    seznamCisel.Remove(i);
                }
            }
            Console.WriteLine(seznamCisel.Count());
            */

            //RemoveAll
            //seznamCisel.RemoveAll(VetsiNez);

            //Arrow function
            seznamCisel.RemoveAll(c => c >= 500000);
            Console.WriteLine(seznamCisel.Count());


        }

        static bool VetsiNez(int cislo)
        {
            if (cislo >= 500000)
            {
                return true;
            }
             return false;
        }
    }
}
