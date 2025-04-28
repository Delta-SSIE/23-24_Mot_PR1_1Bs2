namespace Dedicnost_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vytvoření objektu z třídy Human
            Human clovek = new Human
            {
                name = "Hanz",
                email = "hanz@hanz.com",
                age = 20
            };
            //Zavolání metody
            clovek.PredstavSe();

            //vytvoření objektu třídy Student, která dědí ze třídy Human
            Student student = new Student
            {
                name = "Ondřej",
                email = "ondrej@prosim.cz",
                age = 18,
                grade = "2.A"
            };

            //zavolání metody
            student.PredstavSe();

            Console.WriteLine(student.grade);

            //Tvorba objektu z třídy Teacher
            Teacher teacher = new Teacher
            {
                name = "Gustav",
                email = "gusto@gusto.com",
                age = 53,
                cabinet_number = 150,
                subjects = ["Math", "Science"]
            };

            teacher.PredstavSe();
            Console.WriteLine(teacher.cabinet_number);
            teacher.List_Subjects();

        }
    }
}
