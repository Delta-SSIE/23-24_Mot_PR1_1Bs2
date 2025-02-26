namespace Enum
{
    internal class Program
    {
        enum Obdobi
        {
            Jaro,
            Leto,
            Podzim,
            Zima
        }
        static void Main(string[] args)
        {
            //Uložení enumerační hodnoty do proměnné
            Obdobi aktualniObdobi = Obdobi.Zima;
            Console.WriteLine(aktualniObdobi);

            //ukázka indexu prvku v enumeraci
            Console.WriteLine((int) aktualniObdobi); //převod aktualniObdobi na čislo

            //posun enumerační hodnoty v rámci seznamu
            aktualniObdobi--; //za Zimou není další období, proto nelze ++, ale lze -- (skok na Podzim)
            Console.WriteLine(aktualniObdobi);



        }
    }
}
