using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_26
{
    internal class Kmetovalec : Oseba {
        int velikostPosesti;

        public Kmetovalec(string ime, int velikostPosesti) : base(ime) {
            this.velikostPosesti = velikostPosesti;
        }//Konec Kmetovalec

        public override string ToString() {
            return base.ToString() + ", Velikost posesti: " +velikostPosesti.ToString();

        }//Konec ToString
    }
}
