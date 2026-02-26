using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_26 {
    internal class Tocka3D : Tocka{
        private int z;

        public int Z {
            get {
                if (z < 0) {
                    return 0;
                } else {
                    return z;
                }
            } set { z = value; }
        }

        public override void Koordinate() {
            base.Koordinate();
            Console.Write(", z = " + z);
        }//Konec Koordinate
    }//Konec class Tocka3D
}
