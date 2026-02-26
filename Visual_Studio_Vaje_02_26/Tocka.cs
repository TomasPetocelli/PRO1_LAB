using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_26 {
    internal class Tocka {
        private int x, y;

        public int X {
            get {
                if (x < 0) {
                    return 0;
                } else {
                    return x;
                }
            } set { x = value; }
        }

        public int Y {
            get {
                if (y < 0) {
                    return 0;
                } else {
                    return y;
                }
            } set { y = value; }
        }

        public virtual void Koordinate() {
            Console.Write("Koordinate točke: x = " + x + ", y = " + y);
        }//Konec Koordinate
    }//Konec class Tocka
}
