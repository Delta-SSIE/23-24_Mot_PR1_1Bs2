namespace Uvod_OOP_zaklad
{
    //nová třída Auto v rámci jednoho namespacu
    internal class Auto
    {
        //Vlastnosti/Atributy/Položky (Propreties/Atributes/Fields)
        public string znacka;
        public int kola = 4; //definovaná hodnota vlastnosti
        //položky musí být public, aby je mohla vidět jiná třída

        //Metoda třídy
        public void Zatrub()
        {
            Console.WriteLine("Tůů!Tůůů!");
        }

        public string PredstavSe()
        {
            //Vrací string, který v sobě nese hodnoty vlastností objektů z této třídy
            return $"Auto má {this.kola} kol a je značky {this.znacka}!";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //nový objekt z třídy Auto, který nese název mojeAuto
            Auto mojeAuto = new Auto();

            //Vypsání hodnoty vlastnosti objektu mojeAuto, konkrétně vlastnosti kola
            Console.WriteLine(mojeAuto.kola);
            //Změna hodnoty na vlastnosti objektu
            mojeAuto.znacka = "Ford";
            Console.WriteLine($"Moje auto má {mojeAuto.kola} kola a je značky {mojeAuto.znacka}!");

            Auto sousedAuto = new Auto();
            sousedAuto.znacka = "Mustang";
            //Volání metody objektů s návratovou hodnotou (string)
            Console.WriteLine(sousedAuto.PredstavSe());
            Console.WriteLine(mojeAuto.PredstavSe());

            //změna hodnoty vlastnosti u objektu
            sousedAuto.kola = 2;
            Console.WriteLine(sousedAuto.PredstavSe());

            mojeAuto.Zatrub();
        }
    }
}
