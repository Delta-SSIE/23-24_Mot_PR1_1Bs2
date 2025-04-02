namespace Soubor_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create vždy vytvoří soubor - pokud existuje, tak ho přepíše

            //vloží přes relativní odkaz soubor do adresáře, kde je skript
            File.Create("ahoj.pdf");

            //relativní odkaz do složky projektu
            File.Create("../../../../text.txt");
            // ../ jdi o adresáře zpět

            //relativní odkaz do složky v složce skriptu
            //File.Create("data/text.txt");

            //Absolutní odkaz - na plochu
            File.Create(@"C:\Users\mottja\Desktop\text.txt");

            //existence souboru
            if(File.Exists("data/text.txt"))
            {
                Console.WriteLine("File exist");
            } else
            {
                Console.WriteLine("File was created");
                File.Create("data/text.txt");
            }

            //Primitivnéí zápis do souboru a jeho čtení
            File.WriteAllText("data/text.txt", "Ahoooj"); //zápis do souboru
            Console.WriteLine(File.ReadAllText("data/text.txt")); //čtení ze souboru a výpis do konzole

            //existence souboru
            if (File.Exists("data/text2.txt"))
            {
                Console.WriteLine("File exist");
            }
            else
            {
                Console.WriteLine("File was created");
                File.Create("data/text2.txt");
            }


            //Komplexnější práce s čtením a zápisem do souboru
            StreamWriter sw = new StreamWriter("data/text2.txt");
            sw.WriteLine("Ahooj");
            sw.WriteLine("To koukáš, co?");
            //uzavření streamreaderu
            sw.Close();

            //Čtení do konzole
            StreamReader sr = new StreamReader("data/text2.txt");
            //načte první řádek do proměnné řádek
            string radek = sr.ReadLine();
            //dokud radek není null, tak se opakuje
            while(radek != null)
            {
                //vypíše obsah proměnné řádek
                Console.WriteLine(radek);
                //načte do proměnné další řádek z dokumentu
                radek = sr.ReadLine();
            }
            //uzavření streamreaderu
            sr.Close();
            



        }

    }
}
