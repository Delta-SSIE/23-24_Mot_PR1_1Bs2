namespace Cyklus_While_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Napiš kolik čísel od 0 chceš vypsat!");
            int maxCislo = int.Parse(Console.ReadLine());
            int pocitadlo = 0;

            //Cyklus while
            while(pocitadlo <= maxCislo) //v závorce podmínka, dokud platí, tak se opakuje tělo cyklu {}
            //Podmínka nyní říká, že se cyklus opakuje, dokud se pocitadlo menší, nebo rovno maxCislo
            {
                Console.Write(pocitadlo + " ");
                pocitadlo++;
            }
            Console.WriteLine();

            Random gen = new Random();
            int cenaCola = 35;
            int automat = 0;
            int mince = 0;

            //DoWhile cyklus
            do //tělo cyklu je před podmínkou
            {

                do //tělo vnořeného cyklus
                {
                    mince = gen.Next(1, 51);
                } while (mince != 1 && mince != 2 && mince != 5 && mince != 10 && mince != 20 && mince != 50); //podmínka cyklu vnořeného
                Console.WriteLine($"Android vhodil {mince} do automatu.");
                automat += mince;
            } while (automat < cenaCola); //podmínka cyklu
            Console.WriteLine($"Cola vypadla! V automatu zůstaly drobné: {automat-cenaCola}");

        }
    }
}
