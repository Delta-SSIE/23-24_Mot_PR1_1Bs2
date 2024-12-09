namespace Cvic_DnyVRoce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mesice = { "leden", "únor", "březen", "duben", "květen", "červen", "červenec", "srpen", "září", "říjen", "listopad", "prosinec" };
            string[] dny = { "pondělí", "úterý", "středa", "čtvrtek", "pátek", "sobota", "neděle" };
            //pomocný index:
            int pocitadlo_dnu = 0;

            for (int i = 0; i < mesice.Length; i++)
            {
                for (int j = 1; j < 31; j++)
                {
                    //pokud se počitadlo dostane na 7, což je index, který v poli dny už není!
                    if(pocitadlo_dnu == 7)
                    {
                        pocitadlo_dnu = 0; //tak se vynuluje (tzn. z neděle jdu zpět na pondělí)
                    }
                    Console.WriteLine($"{j}-{dny[tyden]}-{mesice[i]}");
                    pocitadlo_dnu++; //zvýšení pomocného indexu
                }
            }
        }
    }
}
