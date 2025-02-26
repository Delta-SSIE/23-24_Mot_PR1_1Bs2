namespace Uvod_OOP_sam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Vytvoření objektu a přiřazení hodnot k jeho vlastnostem
            Human person1 = new Human();

            person1.name = "Josh";
            person1.age = 50;
            person1.sex = Sex.Man;
            */

            //Vytvoření objektu a přiřazení hodnot k vlastnostem pomocí KONSTRUKTORU
            Human person1 = new Human("Josh", Sex.Man, 50);
            Human person2 = new Human("Helga", Sex.Woman, 30);

            Console.WriteLine(person1.Introduction());
            Console.WriteLine(person1.life);

            person1.Kill();
            Console.WriteLine(person1.life);

            Console.WriteLine(person2.Introduction());

        }
    }
}
