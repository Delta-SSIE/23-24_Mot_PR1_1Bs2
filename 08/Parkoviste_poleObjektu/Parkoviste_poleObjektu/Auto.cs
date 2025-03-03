using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkoviste_poleObjektu
{
    internal class Auto
    {
        //Vlastnost/Položka každého objektu vytvořeného z třídy Auto
        public string znacka;
        public int kola;
        public string barva;
        public bool pokuta;

        //Kontruktor pro objekty z třídy Auto
        //Konstruktor je metoda, která se zavolá kdykoliv se vytváří nový objekt z třídy Auto
        public Auto(int pocet)
        {
            Random gen = new Random();
            //náhodně se generují jednotlivé vlastnosti barva a znacka
            string[] znackyAut = { "Toyota", "Ford", "BMW", "Audi", "Mercedes", "Honda", "Hyundai", "Volkswagen", "Nissan", "Chevrolet", "Kia", "Mazda", "Subaru", "Lexus", "Jaguar", "Porsche", "Ferrari", "Lamborghini", "Mitsubishi", "Peugeot" };
            znacka = znackyAut[gen.Next(0, znackyAut.Length)];
            string[] barvy = { "Červená", "Modrá", "Zelená", "Žlutá", "Černá", "Bílá", "Fialová", "Oranžová", "Růžová", "Hnědá", "Šedá", "Tyrkysová", "Zlatá", "Stříbrná", "Béžová", "Bordó", "Olivová", "Limetková", "Námořnická modrá", "Levandulová" };
            barva = barvy[gen.Next(0, barvy.Length)];
            
            //zadává v parametru uživatel při tvoření objektu
            kola = pocet;
            pokuta = false;
        }

        //Metoda pro vypsání hodnot objektu
        public string Identify()
        {
            string pomoc = (pokuta) ? "Má" : "Nemá";
            return $"Auto je značky: {znacka}, barvy: {barva} a má počet kol {kola}. {pomoc} pokutu!";
        }


    }
}
