using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_26 {
    internal class Krog {
        private double polmer;
        public double Polmer {
            get { if (polmer < 0) {
                    return 0.0;
                } else {
                    return polmer;
                }
            } set { polmer = value; } 
        }
        public double Obseg {
            get { return 2 * Polmer * Math.PI; }
        }//Konec Obseg

        public double Kvadratura {
            get { return Math.PI * Math.Pow(Polmer, 2); }
        }//Konec Kvadratura

    }//Konec class Krog
}
