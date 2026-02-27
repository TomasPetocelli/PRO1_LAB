namespace Visual_Studio_Vaje_02_27.Dedovanje {
    internal class Program {
        static void Main(string[] args) {
            Osnovni[] taObj = new Osnovni[4];
            taObj[0] = new Crta();
            taObj[1] = new Krog();
            taObj[2] = new Kvadrat();
            taObj[3] = new Osnovni();

            for (int i = 0; i < taObj.Length; i++) {
                taObj[i].Slika();
            }//Konec for
        }//Konec Main
    }//Konec class Program
}
