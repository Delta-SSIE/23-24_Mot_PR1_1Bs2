using System.Collections.Generic;
using System.Data;
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
            
            //Hlavní smyčka programu (menu)
            while(true)
            {
                Console.WriteLine($"Přihlášen:");
                prihlaseny_uzivatel.DisplayInfo(); 
                if(prihlaseny_uzivatel.type == "customer") //customer
                {
                    Console.Clear();
                    Console.WriteLine($"1. pro výpis zboží v eshopu\n 2.Vytvořit objednávku");
                    int volba = int.Parse(Console.ReadLine());
                    int indexzbozi = 0;
                    switch (volba)
                    {
                        case 1:
                            foreach(Item zbozi in items)
                            {
                                zbozi.DisplayInfo();
                            }
                            break;
                        case 2:
                            Order objednavka = new Order(prihlaseny_uzivatel);
                            do
                            {
                                Console.Clear();
                                for (int i = 0; i < items.Count; i++)
                                {
                                    Console.Write($"{i + 1}.");
                                    items[i].DisplayInfo();
                                }
                                Console.WriteLine("Zadej index zboží, co chceš přidat do objednávky, pokud budeš chtít zadávání ukončit zadej 0");
                                indexzbozi = int.Parse(Console.ReadLine());
                                if (indexzbozi != 0)
                                {
                                    objednavka.items.Add(items[indexzbozi - 1]);
                                    objednavka.total_price += items[indexzbozi - 1].price;
                                }

                            } while (indexzbozi != 0);
                            //Přidání objednávky do listu všech objednávek
                            break;



                    }

                } else // admin
                {
                    Console.WriteLine($"1. pro výpis zboží v eshopu\n");
                    int volba = int.Parse(Console.ReadLine());
                    switch (volba)
                    {
                        case 1:
                            foreach (Item zbozi in items)
                            {
                                zbozi.DisplayInfo();
                            }
                            break;

                    }
                }
            }
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
