using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_27.Naloga13._10 {
    internal class Valj : Krog{
        float visina;

        public Valj(int xV, int yV, float radijV, float visinaV) : base(xV, yV, radijV) {
            visina = visinaV;
        }//Konec Valj

        public float Visina {
            get { return visina; }
            set { visina = value; }
        }//Konec Visina

        public double Povrsina() {
            return 2 * Math.PI * radij * (radij + visina);
        }//Konec Povrsina

        public double Volumen() {
            return Math.PI * radij * radij * visina;
        }//Konec Volumen
            
    }//Konec class Valj
}
