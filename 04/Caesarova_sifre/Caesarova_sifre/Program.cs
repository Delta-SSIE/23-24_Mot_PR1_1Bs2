namespace Caesarova_sifre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Základní verze CS
            string text = "bipk upimf kf ubkob aqsbwb dp nvtjt spamvtuju";
            string des_text = "";
 
            for (int i = 0; i < text.Length; i++)
            {
                int cislo_znaku = text[i];
                if(cislo_znaku == 32)
                {
                    des_text += text[i];
                } else
                {

                    cislo_znaku--;
                    if(cislo_znaku == 96)
                    {
                        cislo_znaku = 122;
                    } 
                    char novy_znak = (char)cislo_znaku;
                    des_text += novy_znak;
                }
                
            }

            Console.WriteLine(des_text);
            string zas_text = "";

            for (int i = 0; i < des_text.Length; i++)
            {
                int cislo_znaku = des_text[i];
                if (cislo_znaku == 32)
                {
                    zas_text += des_text[i];
                }
                else
                {

                    cislo_znaku++;
                    if (cislo_znaku == 123)
                    {
                        cislo_znaku = 97;
                    }
                    char novy_znak = (char)cislo_znaku;
                    zas_text += novy_znak;
                }

            }

            Console.WriteLine(zas_text);
            */
            /* Pokročilá verze CS
            string text = "dyrvo to woqk dktxk jzbkfk my xsuny xocws jscukd";
            string des_text = "";
            int posun = 10;

            for (int i = 0; i < text.Length; i++)
            {
                int cislo_znaku = text[i];
                if (cislo_znaku == 32)
                {
                    des_text += text[i];
                }
                else
                {

                    cislo_znaku-=posun;
                    if (cislo_znaku < 97)
                    {
                        cislo_znaku += 26; //26 je znaků abecedy po jejich přičtení se dostaneme na místo daného znaku v dešifrování
                    }
                    char novy_znak = (char)cislo_znaku;
                    des_text += novy_znak;
                }

            }

            Console.WriteLine(des_text);
            */

            /* CS s neznámým posunem
            string text = "bpm eig gwcz lil twwsml ib qb bpqa eibkp eia gwcz jqzbpzqopb pml jm liuvml qn ivg atwxma owvvi xcb bpmqz ozmiag gmttwe pivla wv pqa jwga jqzbpzqopb aw pm pql qb qv bpm wvm xtikm pm svme pm kwctl pqlm awumbpqvo pqa iaa nqdm twvo gmiza pm ewzm bpqa eibkp cx pqa iaa bpmv epmv pm lqml wn lgamvbmzg pm oidm um bpm eibkp q pql bpqa cvkwunwzbijtm xqmkm wn umbit cx ug iaa nwz bew gmiza bpmv inbmz amdmv gmiza q eia amvb pwum bw ug niuqtg ivl vwe tqbbtm uiv q oqdm bpm eibkp bw gwc";
            string des_text = "";
            string slovo = "yellow";
            bool kontrola = false;

            for (int j = 1; j < 21 && kontrola == false; j++)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int cislo_znaku = text[i];
                    if (cislo_znaku == 32)
                    {
                        des_text += text[i];
                    }
                    else
                    {

                        cislo_znaku -= j;
                        if (cislo_znaku < 97)
                        {
                            cislo_znaku += 26; //26 je znaků abecedy po jejich přičtení se dostaneme na místo daného znaku v dešifrování
                        }
                        char novy_znak = (char)cislo_znaku;
                        des_text += novy_znak;
                    }

                }
                string nactene_slovo = "";
                for (int k = 0; k < des_text.Length; k++) //Průchod dešifrovaným textem a hledání konkrétního slova
                {
                    
                    if (des_text[k] == 32)
                    {
                        if(nactene_slovo == slovo)
                        {
                            kontrola = true;
                            break;
                        } else
                        {
                            nactene_slovo = "";
                        }
                    } else
                    {
                        nactene_slovo += des_text[k];
                    }
                }
                if (!kontrola)
                {
                    des_text = "";
                }
            }
            Console.WriteLine(des_text);
            */
            /*
            string text = "dklrvqvum";
            string des_text = "";
            int[] pole = { 3, 1, 4, 2, 5, 0, 6, 7, 8, 9 };

            for (int i = 0; i < text.Length; i++)
            {
                int cislo_znaku = text[i];
                if (cislo_znaku == 32)
                {
                    des_text += text[i];
                }
                else
                {

                    cislo_znaku -= pole[i];
                    if (cislo_znaku < 97)
                    {
                        cislo_znaku += 26; //26 je znaků abecedy po jejich přičtení se dostaneme na místo daného znaku v dešifrování
                    }
                    char novy_znak = (char)cislo_znaku;
                    des_text += novy_znak;
                }

            }

            Console.WriteLine(des_text);
            */

            Random gen = new Random();
            string text = "tohle mi prosim zasifruj";
            int[] pole = new int[text.Length];
            string zas_text = "";

            for (int i = 0; i < text.Length; i++)
            {
                int posun = gen.Next(1, 20);
                pole[i] = posun;
                int cislo_znaku = text[i];
                cislo_znaku += posun;
                if (cislo_znaku > 122)
                {
                    cislo_znaku -= 26; //26 je znaků abecedy po jejich přičtení se dostaneme na místo daného znaku v dešifrování
                }
                char novy_znak = (char)cislo_znaku;
                zas_text += novy_znak;
            }

            Console.WriteLine(zas_text);
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            Console.WriteLine();

            string des_text = "";

            for (int i = 0; i < zas_text.Length; i++)
            {
                char novy_znak = ' ';
                int cislo_znaku = zas_text[i];
                cislo_znaku -= pole[i];
                if (cislo_znaku == 32)
                {
                    novy_znak = (char)cislo_znaku;
                    des_text += novy_znak;
                }
                    else if (cislo_znaku < 97)
                    {
                        cislo_znaku += 26; //26 je znaků abecedy po jejich přičtení se dostaneme na místo daného znaku v dešifrování
                    }
                    novy_znak = (char)cislo_znaku;
                    des_text += novy_znak;
                

            }

            Console.WriteLine(des_text);
        }
    }
}
