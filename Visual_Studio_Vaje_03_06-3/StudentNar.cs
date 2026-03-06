using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_03_06_3 {
    internal class StudentNar : Student {
        public override void Racunaj() {
            ocena = (Vmesna + Koncna + Seminar ) / 3;
        }//Konec Racunaj
    }//Konec class StudentNar
}
