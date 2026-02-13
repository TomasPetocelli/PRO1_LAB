using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_13 {
    internal class Krog {
        private double polmer;

        public double Polmer {
            get {
                if (polmer < 0) { 
                    return 0; 
                } else { return polmer; } 
            } set { polmer = value; }
        }//Konec Polmer

        public double Premer {
            get { return 2 * Polmer; }
        }//Konec Premer

        public double Obseg {
            get { return Polmer * Math.PI; }
        }//Konec Obseg
        public double Kvadratura {
            get {
                return Math.PI * Math.Pow(Polmer, 2);
            }
        }//Konec Kvadratura
    }//Konec class Krog
}//Konec namespace
