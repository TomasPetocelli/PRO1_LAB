using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_27.Abstraktni_Razredi_in_Interfaces {
    internal class Pes : Zival {
        public Pes(string i, int s) : base(i, "Pes", s) {
        }//Konec Pes

        public override void Oglasanje() {
            Console.WriteLine("HOV, HOV");
        }//Konec Oglasanje

        public override void Premik() {
            Console.WriteLine(ime + " Tece po parku.");
        }//Konec Premik
    }//Konec class Pes
}
