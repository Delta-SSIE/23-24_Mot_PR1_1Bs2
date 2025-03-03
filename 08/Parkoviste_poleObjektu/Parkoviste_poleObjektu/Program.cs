namespace Parkoviste_poleObjektu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //tvorba nového objektu z třídy
            //4 je argument pro paramter pocet
           
            Auto test_auto = new Auto(4);
            Console.WriteLine(test_auto.Identify());
            */

            //Tvorba pole OBJEKTU o velikosti 50
            Auto[] parkoviste = new Auto[50];

            //průchod pole objektů 
            for (int i = 0; i < parkoviste.Length; i++)
            {
                //do jednotlivých indexů v poli se generuje nový objektu
                parkoviste[i] = new Auto(4);
            }

            /* Výpis všech aut v parkovišti
            for (int i = 0; i < parkoviste.Length; i++)
            {
                Console.WriteLine(i +". " + parkoviste[i].Identify());
            }
            */

            //Příjezd policisty, co rozdá pokuty všem autům značky Audi
            for (int i = 0; i < parkoviste.Length; i++)
            {
                if (parkoviste[i].znacka == "Audi")
                {
                    parkoviste[i].pokuta = true;
                }
            }

            //Přijede zloděj, který ukradne kolo každému auto, které je stříbrné
            for (int i = 0; i < parkoviste.Length; i++)
            {
                if (parkoviste[i].barva == "Stříbrná")
                {
                    parkoviste[i].kola--;
                }
            }

            //Výpis všech auto, které buď nemají kolo, nebo mají pokutu
            for (int i = 0; i < parkoviste.Length; i++)
            {
                if(parkoviste[i].kola < 4 || parkoviste[i].pokuta)
                {
                    Console.WriteLine(parkoviste[i].Identify());
                }
            }


        }
    }
}
