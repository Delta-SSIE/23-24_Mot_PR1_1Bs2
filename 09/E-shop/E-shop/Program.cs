using System.Collections.Generic;
using System.Text.Json;

namespace E_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hlavní dva listy, držící data
            List<User> users = new List<User>();
            List<Item> items = new List<Item>();

            //Načtení dat do listů
            users.AddRange(NacistDataU("data/customer.json", "customer"));
            users.AddRange(NacistDataU("data/admin.json", "admin"));
            items.AddRange(NacistDataI("data/drink.json", "drink"));
            items.AddRange(NacistDataI("data/food.json", "food"));

            //Logování do systému
            User prihlaseny_uzivatel = LogIn(users);
            Console.WriteLine("LOG");
        }


        static User LogIn(List<User> list)
        {
            User uzivatel = null;
            bool podminka = true;
            Console.WriteLine("Vítej v systému, prosím zadej své přihlašovací jméno");
            do
            {
                string try_name = Console.ReadLine();
                foreach (User uz in list)
                {
                    if (uz.username == try_name)
                    {
                        uzivatel = uz;
                        podminka = false;
                    }
                }
            } while (podminka);

            Console.WriteLine($"Uživatel {uzivatel.username}, zadej své heslo. Pro přihlášení za jiný účet dej 'e'");
            do
            {
                string try_pass = Console.ReadLine();
                if(uzivatel.pass == try_pass)
                {
                    break;
                }
                if("e" == try_pass)
                {
                    return LogIn(list);
                }
            } while (true);

            return uzivatel;
        }

        static Item[] NacistDataI(string path, string type)
        {
            string textsoubor = File.ReadAllText(path);
            if (type == "drink")
            {
                return JsonSerializer.Deserialize<Drink[]>(textsoubor);
            }
            else
            {
                return JsonSerializer.Deserialize<Food[]>(textsoubor);
            }
        }
        static User[] NacistDataU(string path, string type)
        {
            string textsoubor = File.ReadAllText(path);
            if(type == "customer")
            {
                return JsonSerializer.Deserialize<Customer[]>(textsoubor);
            } else
            {
                return JsonSerializer.Deserialize<Admin[]>(textsoubor);
            }
        }
    }
}
