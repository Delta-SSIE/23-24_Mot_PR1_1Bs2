using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapouzdreni_Banka
{
    internal class Ucet
    {
        //private je opak public
        //private lze manipulovat jen uvnitř Třídy
        //private string jmeno_Drzitele;
        //private položka
        private double bilance;

        //veřejná vlastnost
        public double Bilance
        {
            //co se má stát, když uživatel zavolá danou vlastnost u objektu
            get
            {
                //vracíme hodnotu private položky bilance
                return bilance;
            }
            //Co se má stát, když uživatel manipuluje s hodnotou
            set
            {
                double puv_hod = bilance;
                //value je hodnota, když uživatel manipuluje s vlastností Bilance
                bilance = value;
                //testuje se,jestli po úpravě hodnoty uživatelem zadané se nerovná položka mínusové číslo, pokud ano, tak se vrací její původní hodnota
                if(bilance < 0)
                {
                    bilance = puv_hod;
                    Console.WriteLine("Nelze vybrat více než je na účtu!");
                }
            }
        }

        //get a set auto --> Veřejná vlatnost, která má jednoduchý getter a setter na načtení a změnu private položky (ta zde není definovaná)
        public string JmenoDrzitele { get; set; }




        //Metoda na odchycení chybného zadaní pro změnu vlastnosti Bilance
        /*
        public void SetBilance(double vyber)
        {
            if(vyber<Bilance)
            {
                Bilance -= vyber;
            } else
            {
                Console.WriteLine("Nemůžeš vybrat tolik peněz. Na účtu jich tolik není!");
            }
        }
        */
    }
}
