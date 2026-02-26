namespace Visual_Studio_Vaje_02_26 {
    internal class Program {
        static void Main(string[] args) {
            //Krog k = new Krog();
            //k.Polmer = 5.0;
            //Console.WriteLine("KROG");
            //Console.WriteLine("Polmer: " +k.Polmer);
            //Console.WriteLine("Obseg: " + k.Obseg);
            //Console.WriteLine("Ploščina: " + k.Kvadratura);

            //Krogla kr = new Krogla();
            //kr.Polmer = 10.0;
            //Console.WriteLine("\nKROGLA");
            //Console.WriteLine("Polmer: " + kr.Polmer);
            //Console.WriteLine("Obseg: " + kr.Obseg);
            //Console.WriteLine("Površina: " + kr.Kvadratura);
            //Console.WriteLine("Prostornina: " + kr.Volumen);

            //Tocka t = new Tocka();
            //t.X = 5;
            //t.Y = 10;
            //t.Koordinate();

            //Console.WriteLine("\n");

            //Tocka3D t3 = new Tocka3D();
            //t3.X = 1;
            //t3.Y = 2;
            //t3.Z = 3;
            //t3.Koordinate();

            //Krog_V13 k13 = new Krog_V13();
            //k13.Polmer = 5.0;
            //Console.WriteLine("KROG-13");
            //Console.WriteLine("Polmer: " + k13.Polmer);
            //Console.WriteLine("Ploščina: " + k13.Ploscina);

            //Kolobar kb = new Kolobar();
            //kb.Polmer = 5.0;
            //Console.WriteLine("KROG-13");
            //Console.WriteLine("Polmer: " + kb.Polmer);
            //Console.WriteLine("Ploščina: " + kb.Ploscina);

            Oseba Andrej = new Oseba("Andrej");
            Console.WriteLine(Andrej.ToString());

            Kmetovalec Bine = new Kmetovalec("Bine" , 10);
            Console.WriteLine(Bine.ToString());

        }//Konec Main
    }//konec class Program
}//Konec namespace