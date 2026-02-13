namespace Visual_Studio_Vaje_02_13 {
    internal class Program {
        static void Main(string[] args) {
            Krog k = new Krog();
            k.Polmer = 5.0;
            Console.WriteLine("********************KROG********************");
            Console.WriteLine("Polmer:   " + k.Polmer);
            Console.WriteLine("Premer:   " + k.Premer);
            Console.WriteLine("Obseg:    " + k.Obseg);
            Console.WriteLine("Ploscina: " + k.Kvadratura);

            Krogla kr = new Krogla();
            kr.Polmer = 5.0;
            Console.WriteLine("********************KROGLA********************");
            Console.WriteLine("Polmer:      " + kr.Polmer);
            Console.WriteLine("Premer:      " + kr.Premer);
            Console.WriteLine("Obseg:       " + kr.Obseg);
            Console.WriteLine("Ploscina:    " + kr.Kvadratura);
            Console.WriteLine("Prostornina: " + kr.Volumen);

        }//Konec Main
    }//Konec class Program
}
