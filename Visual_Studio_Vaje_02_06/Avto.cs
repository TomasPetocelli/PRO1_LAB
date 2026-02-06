using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_06 {
    internal class Avto {
        public string znamka;
        private int letnik;
        public string registracija;

        public Avto (string z, int l, string r) {
            znamka = z;
            letnik = l;
            registracija = r;
        }//Konec konstruktor Avto

        public bool SpremeniLetnik(int letnik) {
            if (letnik >= 2000 && letnik <= 2026) {
                this.letnik = letnik;
                return true;
            } else {
                return false;
            }//Konec if - else
        }//Konec SpremeniLetnik

        public override string ToString() {
            return ("Znamka: " + znamka + ", letnik: " + letnik + ", Reg. stevilka: " + registracija);
        }//Konec override ToString

        public static void Main(String[] args) {
            Avto nov = new Avto("Avto", 1999, "GO 12345");
            Console.WriteLine(nov.ToString());

            nov.SpremeniLetnik(1800);
            Console.WriteLine(nov.ToString());

            nov.SpremeniLetnik(2015);
            Console.WriteLine(nov.ToString());
        }//Konec Main
    }//Konec class Avto
}
