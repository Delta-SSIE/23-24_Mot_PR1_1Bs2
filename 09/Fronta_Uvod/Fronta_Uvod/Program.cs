namespace Fronta_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarace fronta
            Queue<string> fronta = new Queue<string>();

            //přidání prvků do fronty
            fronta.Enqueue("Jaromír");
            fronta.Enqueue("Lumír");
            fronta.Enqueue("Hanuš");
            fronta.Enqueue("Jindřiška");

            //Průchod frontou (odpředu)
            foreach (string jmeno in fronta)
            {
                Console.WriteLine(jmeno);
            }
            Console.WriteLine("---------------");

            //vyhazování prvků z fronty - z frontu
            fronta.Dequeue(); //vyhodí Jaromíra
            fronta.Dequeue(); //vyhodí Lumíra
            //Průchod frontou (odpředu)
            foreach (string jmeno in fronta)
            {
                Console.WriteLine(jmeno);
            }
            Console.WriteLine("---------------");

            //vyhození a zařazení prvku do fronty (přesune prvek z frontu na back)
            fronta.Enqueue(fronta.Dequeue());
            foreach (string jmeno in fronta)
            {
                Console.WriteLine(jmeno);
            }
            Console.WriteLine("---------------");

            //Peek
            Console.WriteLine(fronta.Peek()); //vrátí prvek na frontu fronty

            //Contain
            Console.WriteLine(fronta.Contains("Hanuš"));
        }
    }
}
