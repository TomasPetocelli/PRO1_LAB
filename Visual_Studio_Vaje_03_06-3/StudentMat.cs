using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_03_06_3 {
    internal class StudentMat : Student{
        public override void Racunaj() {
            ocena = (Vmesna + Koncna ) / 2;
        }//Konec Racunaj
    }//KOnec class StudentMat
}
