namespace Visual_Studio_Vaje_02_27.Naloga13._9 {
    internal class Program {
        static void Main(string[] args) {
            Oseba student = new Oseba();
            student.NastaviIme("Janez", "Novak");
            Console.WriteLine(student.PolnoIme);
            student.PolnoIme = "Peter Petric";
            Console.WriteLine(student.PolnoIme);

        }//Konec Main
    }//Konec class Program
}
