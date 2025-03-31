namespace Zasobnik_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarace zasobníku
            Stack<string> jmena = new Stack<string>();

            //Přidání prvků do zasobníku
            jmena.Push("Petr");
            jmena.Push("Lukáš");
            jmena.Push("Jindřich");

            //průchod zásobníkem
            foreach (string jmeno in jmena)
            {
                Console.WriteLine(jmeno);
            }

            //FIFO - first in, first out
            //vyhození prvku ze zásobníku
            jmena.Pop();
            foreach (string jmeno in jmena)
            {
                Console.WriteLine(jmeno);
            }

            //Jak lze zjistit, co je první prvek v zásobníku
            Console.WriteLine(jmena.Peek());
            jmena.Pop();
            Console.WriteLine(jmena.Peek());
        }
    }
}
