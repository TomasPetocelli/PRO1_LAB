namespace Visual_Studio_Vaje_02_27.Naloga13._10 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("-----KROG-----");
            Krog k = new Krog(2, 5, 5.0f);
            Console.WriteLine("X = " + k.X + " Y = " + k.Y + " r = " + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Ploscina = " + k.Ploscina());

            k.X = 3;
            k.Y = 6;
            k.Radij = 10;
            Console.WriteLine("X = " + k.X + " Y = " + k.Y + " r = " + k.Radij);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Ploscina = " + k.Ploscina());

            Console.WriteLine("\n-----VALJ-----");
            Valj v = new Valj(1, 1, 5, 10);
            Console.WriteLine("X = " + v.X + " Y = " + v.Y + " r = " + v.Radij + " v = " + v.Visina);
            Console.WriteLine("Premer = " + v.Premer());
            Console.WriteLine("Povrsina = " + v.Povrsina());
            Console.WriteLine("Prostornina = " + v.Volumen());

        }//Konec Main
    }//Konec class Program
}
