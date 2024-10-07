namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "ABCDefgh";

            Console.WriteLine(text.Length); //.Length vrací délku daného řetězce, jako číslo

            Console.WriteLine(text.ToUpper()); //Převede text na velká písmena
            Console.WriteLine(text.ToLower()); //Převede text na malá písmena4

            //Vytažení jednotlivých znaků z textu
            Console.WriteLine(text[0]); //Vrátí znak na indexu 0 (A) v rámci stringu text
            Console.WriteLine(text[2]); //Vrátí znak na indexu 2 (C) v rámci stringu text
            Console.WriteLine(text[7]); //Vrátí znak na indexu 7 (h) v rámci stringu text
            Console.WriteLine(text[text.Length-1]); //Vrátí znak na indexu Délka stringu - 1 (8-1=7) v rámci stringu text

            //Hledání indexu daného znaku ve stringu (první výskyt daného znaku)
            Console.WriteLine(text.IndexOf('e')); //hledání prvního výskytu znaku "e" v rámci stringu text

            //Vytažení znaku z textu a převod na int
            int cislo_znaku = text[0];
            Console.WriteLine(cislo_znaku);

            //Speciální znaky
            Console.WriteLine("\"Tento text bude mezi dvojitými uvozovkami\"");
            Console.WriteLine("\'Tento text bude mezi jednoduchými uvozovkami\'");
            Console.WriteLine("\\Tento text bude mezi lomítky\\");

            Console.WriteLine("Text 1.řádku\nText 2.řádku\nText 3.řádku");


        }
    }
}
