using System.Xml.Serialization;

namespace Soubor_Cteni_Zapis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("text.txt"))
            {
                File.Create("text.txt");
            }

            while(true)
            {
                Console.WriteLine("Psani 1. Čtení 2.");
                int volba = int.Parse(Console.ReadLine());  
                switch (volba)
                {
                    case 1:
                        StreamWriter sw = new StreamWriter("text.txt");
                        Console.WriteLine("Piš, pokud budeš chtít přestat psát zadej prázdnou hodnotu");
                        string text = Console.ReadLine();
                        while(text != "")
                        {
                            sw.WriteLine(text);
                            text = Console.ReadLine();
                        }
                        sw.Close();
            
                        break;
                    case 2:
                        StreamReader sr = new StreamReader("text.txt");
                        string radek = sr.ReadLine();
                        while(radek != null)
                        {
                            Console.WriteLine(radek);
                            radek = sr.ReadLine();
                        }
                        sr.Close();
                        break;
                }
            }


        }

    }
}
