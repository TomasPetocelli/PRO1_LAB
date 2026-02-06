internal class Program {
    //*********************************************KROG*********************************************
    internal class Krog {
        //Polje razreda krog
        public double polmer;

        //Metoda razreda Krog
        public double Ploscina() {
            return Math.PI * polmer * polmer;
        }
    }//Konec class Krog

    //*********************************************STUDENT*********************************************
    public class Student {
        public string ime;
        public string priimek;
        public string vpisnaSt;
        public int letnik;

        /*====================================
                      KONSTRUKTOR
        ====================================*/
        public Student(string ime, string priimek, string vpisnaSt, int letnik) {
            this.ime = ime;
            this.priimek = priimek;
            this.vpisnaSt = vpisnaSt;
            this.letnik = letnik;
        }

        public Student(string ime, string priimek, string vpisnaSt) {
            this.ime = ime;
            this.priimek = priimek;
            this.vpisnaSt = vpisnaSt;
            this.letnik = 2;
        }
    }//Konec class Student

    private static void Main(string[] args) {

        //*********************************************KROG*********************************************
        ////Kreiramo primerek razreda krog (k = objekt)
        //Krog k = new Krog();

        //Console.Write("Vnesi polmer kroga: ");
        //k.polmer = double.Parse(Console.ReadLine());
        //Console.WriteLine("Polščina kroga: " + k.Ploscina());

        //*********************************************STUDENT*********************************************

        //Student ena = new Student();
        //ena.ime = "Miha";
        //ena.priimek = "Peternel";
        //ena.vpisnaSt = "123456";
        //ena.letnik = 1;

        //Console.WriteLine("\nŠtudent: \n" + ena.ime + " " + ena.priimek + "\n" + ena.vpisnaSt + "\n" + ena.letnik);

        //Student dva = new Student();
        //dva.ime = "Luka";
        //dva.priimek = "Peternel";
        //dva.vpisnaSt = "79213";
        //dva.letnik = 2;

        //Console.WriteLine("\nŠtudent: \n" + dva.ime + " " + dva.priimek + "\n" + dva.vpisnaSt + "\n" + dva.letnik);

        //Student tri = dva;
        //tri.ime = "Klemen";
        //Console.WriteLine("\nŠtudent: \n" + tri.ime + " " + tri.priimek + "\n" + tri.vpisnaSt + "\n" + tri.letnik);

        /*====================================
                      KONSTRUKTOR
        ====================================*/
        Student s = new Student("Jože", "Mahit", "123456", 1);
        Console.WriteLine("\nStudent: " + s.ime + " " + s.priimek + "\n" + s.vpisnaSt + "\n" + s.letnik);

        Student s1 = new Student("Jože", "Mahit", "123456");
        Console.WriteLine("\nStudent: " + s1.ime + " " + s1.priimek + "\n" + s1.vpisnaSt + "\n" + s1.letnik);
    }//Konec Main
}

