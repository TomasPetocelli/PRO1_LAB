using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_03_19_ {
    public abstract class Racun {
        public string ime;
        public double stanje;

        public Racun(string ime, double stanje) { 
            this.ime = ime;
            this.stanje = stanje;
        }//Konec konstruktor Racun

        public void Transakcija(double znesek) {
            this.stanje += znesek;
        }//Konec Transakcija

        public abstract double Obresti();
    }//Konec Racun
}
