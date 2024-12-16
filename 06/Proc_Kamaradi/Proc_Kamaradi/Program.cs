namespace Proc_Kamaradi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zavolání metody Kamaradi třikrát pokaždé s unikatními argumenty, které naplní dva parametry metody!
            Kamaradi("Honza", "Pepa");
            Kamaradi("Anička", "Rudolf");
            Kamaradi("Adolf", "Herman");
        }

        //Metoda Kamaradi s dvěma string parametry
        static void Kamaradi(string kamarad1, string kamarad2)
        {
            //Výpis do konzole s parametry
            Console.WriteLine($"Moji kamarádi jsou {kamarad1} a {kamarad2}");
        }
    }
}
