namespace Proc_DlouheRetezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] retezce = new string[5]; //Délka pole je 5, očekává 5 prvků

            for (int i = 0; i < retezce.Length; i++) //procházení pole a načítání řetězců na jednotlivé pozice
            {
                Console.WriteLine($"Zadej {i+1}. řetězec");
                retezce[i] = Console.ReadLine();
            }

            Console.WriteLine("Ze zadaných řetězců jsou alespoň 6-znakové tyto:");
            foreach (string slovo in retezce) //průchod pole retezce, již naplněného hodnotami
            {
                if(slovo.Length >= 6) //kontrola délky stringus
                {
                    Console.WriteLine(slovo);
                }
            }
        }
    }
}
