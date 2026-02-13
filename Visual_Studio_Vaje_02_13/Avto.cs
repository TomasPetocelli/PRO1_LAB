using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_13 {
    class Avto {
        private double najvecjaHitrost;
        private double povprecnaPoraba;      
        private double kolicinaGoriva;       
        private int steviloPrevozenihKm;     
        private string registrskaStevilka;

        public Avto(double najvecjaHitrost, double povprecnaPoraba, string registrskaStevilka) {
            this.najvecjaHitrost = najvecjaHitrost;
            this.povprecnaPoraba = povprecnaPoraba;
            this.registrskaStevilka = registrskaStevilka;
            this.kolicinaGoriva = 0;
            this.steviloPrevozenihKm = 0;
        }//Konec konstruktor (nov avto)

        public Avto(double najvecjaHitrost, double povprecnaPoraba, double kolicinaGoriva, int steviloPrevozenihKm,
                    string registrskaStevilka) {
            this.najvecjaHitrost = najvecjaHitrost;
            this.povprecnaPoraba = povprecnaPoraba;
            this.kolicinaGoriva = kolicinaGoriva;
            this.steviloPrevozenihKm = steviloPrevozenihKm;
            this.registrskaStevilka = registrskaStevilka;
        }//Konec konstruktor (vsi atributi)

        public double Doseg() {
            if (povprecnaPoraba == 0) return 0;
            return (kolicinaGoriva / povprecnaPoraba) * 100.0;
        }//Konec Metoda Doseg

        public void IzpisiVse() {
            Console.WriteLine("Registrska: " + registrskaStevilka);
            Console.WriteLine("Največja hitrost: " + najvecjaHitrost + " km/h");
            Console.WriteLine("Povprečna poraba: " + povprecnaPoraba + " l/100km");
            Console.WriteLine("Količina goriva: " + kolicinaGoriva + " l");
            Console.WriteLine("Prevoženi km: " + steviloPrevozenihKm);
            Console.WriteLine();
        }//Konec Metoda IzpisiVse

        public int NaslednjiServis(int n) {
            int ostanek = steviloPrevozenihKm % n;
            if (ostanek == 0) return 0;
            return n - ostanek;
        }//Konec  Metoda NaslednjiServis
        public static void Main(string[] args) {
            Avto a1 = new Avto(165, 6.8, "KP M3-915");
            Console.WriteLine("Podatki o a1:");
            a1.IzpisiVse();

            Avto a2 = new Avto(200, 7.25, 28.9, 87345, "LJ A1-123");
            Console.WriteLine("Podatki o a2:");
            a2.IzpisiVse();

            Console.WriteLine("Doseg a2: " + a2.Doseg() + " km");
            Console.WriteLine("Naslednji servis čez: " + a2.NaslednjiServis(15000) + " km");
        }//Konec Main
    }//Konec class Avto
}//Konec namespace
