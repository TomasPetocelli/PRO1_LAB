using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_27.Abstraktni_Razredi_in_Interfaces {
    internal class Macka : Zival {
        public Macka(string i, int s) : base(i, "Macka", s) {
        }//Konec Pes

        public override void Oglasanje() {
            Console.WriteLine("MIAO");
        }//Konec Oglasanje

        public override void Premik() {
            Console.WriteLine(ime + " Hodi po parku.");
        }//Konec Premik
    }//Konec class Pes
}
