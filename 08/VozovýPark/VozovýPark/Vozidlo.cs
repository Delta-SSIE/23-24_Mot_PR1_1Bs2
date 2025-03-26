using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VozovýPark
{
    internal class Vozidlo
    {
        private string spz;
        private int rokVyroby;
        private double najeteKM;

        public int RokVyroby
        {
            get
            {
                return rokVyroby;
            }
            set
            {
                if(value >= 1900 && value <= 2025)
                {
                    rokVyroby = value;
                }
            }
        }

        public double NajeteKM
        {
            get
            {
                return najeteKM;
            }
            set
            {
                if(value > 0)
                {
                    najeteKM = value;
                }
            }
        }

        public string SPZ
        {
            get
            {
                return spz;
            }
            set
            {
                spz = value;
                if(spz.Length != 8)
                {
                    spz = "";
                }
                for (int i = 0; i < spz.Length; i++)
                {
                    //(je číslo) || (je velké písmeno)
                    if ((spz[i] > 47 && spz[i] < 58) || (spz[i] > 64 && spz[i] < 91))
                    { }else
                    {
                        spz = "";
                        break;
                    }
                }
            }
        }

        
        public bool Dostupne { get; set; }

        //konstruktor 

        public Vozidlo(string s, int rok, double km)
        {
            SPZ = s;
            RokVyroby = rok;
            NajeteKM = km;
            Dostupne = true;
        }

        //metoda
        public void VypisInfo()
        {
            Console.WriteLine($"SPZ: {SPZ}, najete km: {NajeteKM}, rok výroby {RokVyroby}");
        }

    }
}
