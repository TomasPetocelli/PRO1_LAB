using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_26 {
    internal class Krogla : Krog{
        new public double Kvadratura {
            get {
                return Math.PI * Math.Pow(Polmer, 2);
            }//Konec get
        }//Konec Kvadratura

        public double Volumen {
            get {
                return (4 * Math.PI * Polmer * Polmer) / 3;
            }//Konec get
        }//Konec Volumen
    }//Konec class Krogla
}
