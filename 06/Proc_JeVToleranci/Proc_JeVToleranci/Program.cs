namespace Proc_JeVToleranci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JeVNorme(35.1, 33, 3.5)); //true
            Console.WriteLine(JeVNorme(35.1, 33, 1.5)); //false
            Console.WriteLine(JeVNorme(11.8, 13, 1.3)); //true

            Console.WriteLine(JeVNorme(51, 50, 1));
            Console.WriteLine(JeVNorme(48.5, 50, 1));
        }

        static bool JeVNorme(double skut_roz, double spravny_roz, double tol)
        {
            if(skut_roz >= spravny_roz-tol && skut_roz <= spravny_roz + tol)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
