namespace Radici_algoritmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pole = { 1, 5, 13, 2, 64, 15, 20, 19, 4, 6, 12 };
            VypisPole(pole);
            int[] selction_pole = SelectionSort(pole);
            VypisPole(selction_pole);
            int[] bubble_pole = BubbleSort(pole);
            VypisPole(bubble_pole);
        }

        static void VypisPole(int[] pole)
        {
            foreach (int cislo in pole)
            {
                Console.Write(cislo + " ");
            }
            Console.WriteLine();
        }

        static int[] SelectionSort(int[] array)
        {
            int kroky = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int IMin = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[IMin])
                    {
                        IMin = j;
                    }
                    kroky++;
                }
                if(IMin != i)
                {
                    int pomoc = array[i];
                    array[i] = array[IMin];
                    array[IMin] = pomoc;
                }
            }
            Console.WriteLine(kroky);
            return array;
        }
        static int[] BubbleSort(int[] array)
        {
            int kroky = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int pomoc = array[j];
                        array[j] = array[j+1];
                        array[j] = pomoc;
                    }
                    kroky++;
                }
            }
            Console.WriteLine(kroky);
            return array;
        }
    }
}
