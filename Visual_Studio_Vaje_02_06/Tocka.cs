using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//---------------NALOGA 13.2---------------

namespace Visual_Studio_Vaje_02_06 {
    internal class Tocka {
        private int x, y;

        public Tocka() {
            x = 0; y = 0;
        }//Konec konstruktor Tocka

        public Tocka(int x, int y) {
            this.x = x; this.y = y;
        }//Konec konstruktor Tocka

        public void SpremeniX(int x) {
            this.x = x;
        }//Konec SpremeniX

        public void SpremeniY(int y) {
            this.y = y;
        }//Konec SpremeniY

        public double Razdalja(Tocka B) {
            int razdaljaX = x - B.x;
            int razdaljaY = y - B.y;

            return Math.Sqrt(Math.Pow(razdaljaX, 2) + Math.Pow(razdaljaY, 2));
        }

        public static void Main(string[] args) {
            Tocka A = new Tocka();
            Tocka B = new Tocka(3, 8);

            Console.WriteLine("Tocka A: " +A.x + ", y = " +A.y);
            Console.WriteLine("Tocka A: " + B.x + ", y = " + B.y);

            A.SpremeniX(5);
            A.SpremeniY(10);
            Console.WriteLine("Tocka A: " + A.x + ", y = " + A.y);

            double razdalja = A.Razdalja(B);
            Console.WriteLine("Razdalja: " + razdalja);
        }//Konec Main

    }
}
