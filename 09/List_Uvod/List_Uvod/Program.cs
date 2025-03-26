namespace List_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { 5, 10, 8 };

            //deklarace listu s kapacitou
            List<int> listCisel = new List<int>();

            //přidání dvou prvků do listu
            listCisel.Add(10);
            listCisel.Add(15);
            
            
            Console.WriteLine(listCisel.Count); //vypíše aktuální počet prvků v listu
            Console.WriteLine(listCisel.Capacity); //vypíše nastavenou kapacitu listu

            //přidání rozsahu
            listCisel.AddRange(cisla); //přidání kolekce do listu

            //průchod listem
            foreach (int cislo in listCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine("\n---------------");

            //vložení prvku do listu
            //Insert(index, novýprvek)
            //prvky za novým prvkem se posunou
            listCisel.Insert(1, 20);
            //průchod listem
            foreach (int cislo in listCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine("\n---------------");

            //vložení rozsahu do listu
            listCisel.InsertRange(0, cisla);
            //průchod listem
            foreach (int cislo in listCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine("\n---------------");
            Console.WriteLine(listCisel.Capacity);

            //Smazaní prvku zt listu
            listCisel.Remove(20);
            foreach (int cislo in listCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine("\n---------------");

            //Smazaní prvku zt listu
            listCisel.Remove(5);
            foreach (int cislo in listCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine("\n---------------");

            //smaže prvek na konkrétním indexu
            listCisel.RemoveAt(0);
            foreach (int cislo in listCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine("\n---------------");
            //smaže rozsah prvků od konkrétního indexu
            listCisel.RemoveRange(1, 3);
            foreach (int cislo in listCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine("\n---------------");

            //listCisel.Clear();

            //Vrací index prvku, pokud není nalezen, tak vrací -1
            Console.WriteLine(listCisel.IndexOf(8)); //0, protože první nalezený odpovídají prvek
            Console.WriteLine(listCisel.IndexOf(18)); //není, takže -1
            Console.WriteLine(listCisel.LastIndexOf(8)); //2, protože poslední nalezený odpovídají prvek

            Console.WriteLine(listCisel.IndexOf(8, listCisel.IndexOf(8)+1));
            //hledá další index hodnoty 8, po indexu s první výskytem 8

            //Řazení listu
            listCisel.Sort();
            foreach (int cislo in listCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine("\n---------------");

            //Řazení listu (obracené)
            listCisel.Reverse();
            foreach (int cislo in listCisel)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine("\n---------------");

            cisla = listCisel.ToArray();





        }
    }
}
