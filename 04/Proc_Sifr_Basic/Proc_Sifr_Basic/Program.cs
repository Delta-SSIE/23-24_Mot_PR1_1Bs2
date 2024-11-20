namespace Proc_Sifr_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string zasifrovany_text = "";
            string desifrovany_text = "";
            Console.WriteLine("Zadej mi text");
            string text = Console.ReadLine();

            for (int i = text.Length-1; i >= 0; i--)
            {
                switch (text[i])
                {
                    case 'a':
                        zasifrovany_text += '#';
                        break;
                    case 'e':
                        zasifrovany_text += '$';
                        break;
                    case 'o':
                        zasifrovany_text += '&';
                        break;
                    default:
                        zasifrovany_text += text[i];
                        break;
                }
            }
            Console.WriteLine(zasifrovany_text);
            for (int i = zasifrovany_text.Length - 1; i >= 0; i--)
            {
                switch (zasifrovany_text[i])
                {
                    case '#':
                        desifrovany_text += 'a';
                        break;
                    case '$':
                        desifrovany_text += 'e';
                        break;
                    case '&':
                        desifrovany_text += 'o';
                        break;
                    default:
                        desifrovany_text += zasifrovany_text[i];
                        break;
                }
            }
            Console.WriteLine(desifrovany_text);

        }
    }
}
