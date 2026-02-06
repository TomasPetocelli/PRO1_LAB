using System.ComponentModel;

namespace Visual_Studio_Vaje_02_06 {
    internal class Program {
        //---------------NALOGA 13.1---------------
        public class Trikotnik {
            public int a, b, c;

            public Trikotnik() {
                Random naklucno = new Random();
                this.a = naklucno.Next(1, 10);
                this.b = naklucno.Next(1, 10);

                while (true) {
                    this.c = naklucno.Next(1, 10);
                    if ((a+b) > c && (a+c) > b && (b+c) > a) {
                        break;
                    }
                }//Konec while 
            }//Konec konstruktor Trikotnik-t1

            public Trikotnik(int a, int b, int c) {
                this.a = a; 
                this.b = b; 
                this.c = c;
            }//Konec konstruktor Trikotnik-t2
        }//Konec class Trikotnik



        static void Main(string[] args) {
            //---------------NALOGA 13.1---------------
            Trikotnik t = new Trikotnik();
            Console.WriteLine("Stranice trikotnika: \n" + t.a + "\n" + t.b + "\n" + t.c);

            Trikotnik t2 = new Trikotnik(3, 4, 5);
            Console.WriteLine("Stranice trikotnika: \n" + t2.a + "\n" + t2.b + "\n" + t2.c);
        }//Konec Main
    }//Konec class Program
}
