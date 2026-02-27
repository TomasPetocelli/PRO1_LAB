using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_27.Naloga13._9 {
    internal class Oseba {
        private string ime;
        private string priimek;

        public void NastaviIme(string ime, string priimek) { 
            this.ime = ime;
            this.priimek = priimek;
        }//Konec NastaviIme
        
        public string PolnoIme {
            get { return ime + " " + priimek; }
            set {
                string zacasnoSpremenljivko = value;
                string[] imena = zacasnoSpremenljivko.Split();
                ime = imena[0];
                priimek = imena[imena.Length - 1];
            }//Konec set
        }//Konec PolnoIme
    }//Konec class Oseba
}
