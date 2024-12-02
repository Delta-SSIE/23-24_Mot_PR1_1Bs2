namespace Proc_PodminenySoucet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { 25, -56, -88, 5, 10, 65, 584, -8, -120, 186 };
            int soucet = 0;

            foreach (int cislo in pole)
            {
                if(cislo < 10 && cislo > -10)
                {
                    soucet += cislo;
                }
            }

            Console.WriteLine(soucet);

        }
    }
}
