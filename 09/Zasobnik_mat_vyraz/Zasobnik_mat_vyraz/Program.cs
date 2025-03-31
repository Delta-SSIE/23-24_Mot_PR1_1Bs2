namespace Zasobnik_mat_vyraz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidovatVyraz("4 + 5"));
            Console.WriteLine(ValidovatVyraz("(4 + 5) * (15 * 5"));
            Console.WriteLine(ValidovatVyraz("(4 + 5) * (15 * 5)"));
        }

        static bool ValidovatVyraz(string vyraz)
        {
            Stack<int> zavorky = new Stack<int>();

            bool podminka = true;
            for (int i = 0; i < vyraz.Length; i++)
            {
                if ((vyraz[i] > 39 && vyraz[i] < 58) || vyraz[i] == 32)
                {
                    if (vyraz[i] == '(')
                    {
                        if(zavorky.Count > 0)
                        {
                            podminka = false;
                            break;
                        } else
                        {
                            zavorky.Push(vyraz[i]);
                        }
                    }
                    if (vyraz[i] == ')')
                    {
                        if(zavorky.Count > 0)
                        { 
                            if(zavorky.Peek() == '(')
                            {
                                zavorky.Clear();
                            } else
                            {
                                podminka = false;
                                break;
                            }
                        } else
                        {
                            podminka = false;
                            break;
                        }
                    }
                } else
                {
                    podminka = false;
                    break;
                }
            }


            if(zavorky.Count > 0)
            {
                podminka = false;
            }
            return podminka;
        }
    }
}
