namespace Uvod_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napiš mi kolik ti je let? ");
            int vek = int.Parse(Console.ReadLine());
            Console.Write("Máš řidičák? (y/n) ");
            char ridicak = Console.ReadKey().KeyChar; //načtení znaku od uživatele
            Console.WriteLine();

            //Podmínka if s pouze kladnou větví
            if (vek >= 18) //vek je větší, nebo roven 18
            {
                Console.WriteLine("Gratuluji! Jsi dle zákona dospělý!");
            }

            //Podmínka s logickým operátorem AND
            if (vek >= 18 && ridicak == 'y') //(&& == AND) vek je větší, nebo roven 18 A ZAROVEN je ridicak 'y'
            {
                Console.WriteLine("Gratuluji! Jsi dospělý a můžeš řídit auto!");
            }

            //Podmínka s logický operáorem OR
            if (vek >= 18 || ridicak == 'y') //(|| == OR) vek je větší, nebo roven 18 NEBO je ridicak 'y'
            {
                Console.WriteLine("Gratuluji! Jsi dospělý, nebo můžeš řídit auto, či obojí!");
            }

            //Podmínka s logickým opeátorem NOT
            if (!(vek < 18) && !(ridicak == 'n')) //(! == NOT) Pokud NENI věk nižší než 18 a zaroven NENI ridicak 'n'
            {
                Console.WriteLine("Gratuluji! Jsi dospělý a můžeš řídit auto! (NEGACE)");
            }

            //Podmínka s negativní větví ELSE
            if(vek >= 18)
            {
                Console.WriteLine("Dospělý!");
            } else
            {
                Console.WriteLine("Dítě!");
            }

            //Podmínka s negativní větví ELSE IF
            if (vek >= 18 && ridicak == 'y')
            {
                Console.WriteLine("Dospělý řidič!");
            } else if (vek >= 18)
            {
                Console.WriteLine("Dospělý neřidič");
            } else if (ridicak == 'y')
            {
                Console.WriteLine("Dítě řidič");
            } else
            {
                Console.WriteLine("Dítě neřidič");
            }

            //Short-hand if (zkrácená verze if)
            Console.Write("Zadej mi hodinu ");
            int hodina = int.Parse(Console.ReadLine());
            Console.WriteLine((hodina > 18) ? "Dobrý večer!" : "Dobrý den!");
            //V závorce je podmínka za ním označení pro if "?" a následně kladná větev : záporná větev

        }
    }
}
