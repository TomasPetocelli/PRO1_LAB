using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_27.Naloga13._10 {
    internal class Krog {
        protected int x;
        protected int y;
        protected float radij;

        public Krog(int xK, int yK, float radijK) {
            x = xK;
            y = yK;
            radij = radijK;
        }//konec Krog

        public int X {
            get { return x; }
            set { x = value; }
        }//Konec X

        public int Y {
            get { return y; }
            set { y = value; }
        }//Konec Y

        public float Radij {
            get { return radij; }
            set {
                if (value > 0)
                    radij = value;
                else
                    radij = 0;
            }//konec set
        }//Konec Radij

        public float Premer() {
            return 2 * radij;
        }//Konec Premer

        public float Ploscina() {
            return 3.14f * Radij * Radij; //Math.PI vrne double zaradi tega pisemo 3.14f(float)
        }//Konec Ploscina

    }//Konec class Krog
}
