namespace CSV_Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] lide = new string[1000, 3];
            StreamReader sr = new StreamReader("data.csv");
            string radek = sr.ReadLine();
            for (int i = 0; i < lide.GetLength(0); i++)
            {
                string[] data = radek.Split(",");
                for (int j = 0; j < lide.GetLength(1); j++)
                {
                    lide[i, j] = data[j];
                }
                radek = sr.ReadLine();
            }
            sr.Close();

            for (int i = 0; i < lide.GetLength(0); i++)
            {
                for (int j = 0; j < lide.GetLength(1); j++)
                {
                    Console.Write(lide[i,j] + " ");
                }
                Console.WriteLine();
            }

            lide[0, 0] = "5";
            lide[0, 1] = "John";
            lide[0, 2] = "Gordon";

            StreamWriter sw = new StreamWriter("data.csv");
            for (int i = 0; i < lide.GetLength(0); i++)
            {
                radek = "";
                for (int j = 0; j < lide.GetLength(1); j++)
                {
                    radek += lide[i, j] + ",";
                }
                sw.WriteLine(radek);
            }
            sw.Close();
        }
    }
}
