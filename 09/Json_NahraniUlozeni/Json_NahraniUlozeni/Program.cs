using System.Text.Json;

namespace Json_NahraniUlozeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nahraní dat ze souboru do stringu
            string text = File.ReadAllText("dataj.json");

            //Převedení textu ze souboru uložené v proměnné text do pole objektů třídy Human
            Human[] people = JsonSerializer.Deserialize<Human[]>(text);

            foreach (Human clovek in people)
            {
                Console.WriteLine(clovek.first_name + " " + clovek.last_name);
            }

            //převedu statické pole do dynamického listu
            List<Human> sprava_mesta = new List<Human>(people);

            Human novy_obcan = new Human
            {
                id = 1001,
                first_name = "Karel",
                last_name = "Polivka",
                email = "polivka@karel.cz"
            };

            //přidání nového občana do listu
            sprava_mesta.Add(novy_obcan);

            //změna hodnot v listu na 0. indexu
            sprava_mesta[0].first_name = "Richard";
            sprava_mesta[0].last_name = "Brun";

            //převedení listu na pole
            people = sprava_mesta.ToArray();

            //převedení pole na json string
            string json = JsonSerializer.Serialize(people);

            //přepsání hodnot v souboru na nový string
            File.WriteAllText("dataj.json", json);

        }
    }
}
