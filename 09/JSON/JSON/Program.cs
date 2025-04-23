using System.Text.Json;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "database.json";

            //Ověření existence souboru
            if(!File.Exists(path))
            {
                File.Create(path);
            }

            //načtení kompletního textu ze souboru
            string text = File.ReadAllText(path); //vytáhnou text ze souboru
            User[] pole_uz;
            
            try
            {
                pole_uz = JsonSerializer.Deserialize<User[]>(text); //přeložím text do User[]

            } catch
            {
                pole_uz = [];
            }

            List<User> list_uz = new List<User>(pole_uz); //převedení pole pole_uz na list_uz

            List<User> list_uz2 = new List<User>(JsonSerializer.Deserialize<User[]>(File.ReadAllText("database.json")));

            //Práce s listem
            list_uz.Add(new User
            {
                id = 10,
                first_name = "John",
                last_name = "Brook",
                email = "brook@john.com",
                ip_adress = "111"
            });

            list_uz[1].first_name = "Donald";

            list_uz.Remove(list_uz[5]);

            //uložení dat

            pole_uz = list_uz.ToArray(); //změní list na pole
            text = JsonSerializer.Serialize<User[]>(pole_uz); //změna User[] na string
            File.WriteAllText(path, text); //přepíše souboru textem z proměnné

            //uložení reportu do txt
            //File.Create("report.txt"); //vytvoří soubor (přepíše existující)

            StreamWriter sw = new StreamWriter("report.txt");
            for (int i = 0; i < list_uz.Count; i++)
            {
                sw.WriteLine(list_uz[i].IdentifySelf());
            }
            sw.Close();



        }
    }
}
