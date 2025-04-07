using System.Text.Json;

namespace JSON_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Clovek> lide = new List<Clovek>();

            Clovek test = new Clovek
            {
                id = 5,
                first_name = "Karel",
                last_name = "Omacka"

            };

            var json = JsonSerializer.Serialize(test);
            Console.WriteLine(json);

            var novy_clovek = JsonSerializer.Deserialize<Clovek>(json);

            Console.WriteLine(novy_clovek.first_name + " " + novy_clovek.last_name);

            byte[] data = File.ReadAllBytes("data.json");
            Utf8JsonReader reader = new Utf8JsonReader(data);
            string vlastnost;
            while (reader.Read())
            {
                switch(reader.TokenType)
                {
                    case JsonTokenType.StartObject:
                        Clovek lepsi_clovek = new Clovek();
                        break;
                    case JsonTokenType.PropertyName:
                        vlastnost = reader.GetString();
                        break;
                    case JsonTokenType.Int:
                        lepsi_clovek.id = reader.GetInt32();
                        break;

                }
            }


        }
    }
}
