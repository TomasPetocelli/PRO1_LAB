internal class Program {
    private static void Main(string[] args) {
        //---------------NALOGA 1 IZPIŠI STOTICE, DESETICE IN ENICE ŠTEVILA---------------
        //int trimestno_število = 586;

        ////stotice
        //int stotice = trimestno_število / 100;
        //Console.WriteLine("Stotice: " + stotice);

        ////desetice
        //int desetice = (trimestno_število % 100) / 10;
        //Console.WriteLine("Desetice: " + desetice);

        ////enice
        //int enice = trimestno_število % 10;
        //Console.WriteLine("Enice: " + enice);

        //---------------NALOGA 2 IZPIŠI OBRNJENO ŠTEVILO---------------
        //int trimestno_stevilo = 138;

        ////enice
        //int enice = trimestno_stevilo % 10;

        ////desetice
        //int desetice = (trimestno_stevilo / 10) % 10;

        ////stotice
        //int stotice = ((trimestno_stevilo / 100));

        //Console.WriteLine("Trimestno število: " + trimestno_stevilo);
        //Console.WriteLine("Obrnjeno število: " + enice + desetice + stotice);

        //---------------NALOGA 3 PLAČILO GORIVA---------------
        //double staraCena = 1.27;
        //double novaCena = staraCena + 0.04;
        //double stariZnesek = 63.5;

        //double noviZnesek;

        //double kolicina = stariZnesek / staraCena;

        //noviZnesek = kolicina * novaCena;

        //Console.WriteLine("Novi znesek: " + noviZnesek);

        //---------------NALOGA 4 PLAČILO MESEČNE VOZOVNICE---------------
        //double cena = 68.6;
        //double novaCena = (cena * (5.0 / 100));

        //Console.WriteLine("Cena po podražitvi: " + (cena + novaCena));

        //---------------NALOGA 5 PRETVARJANJE MED VGRAJENIMI PODATKOVNIMI TIPI---------------
        //short mojeKratko = 17000;
        //Console.WriteLine("Moje kratko število je: " + mojeKratko);

        //int mojeCelo = mojeKratko;
        //Console.WriteLine("Moje celo število je: " + mojeCelo);

        //mojeKratko = (short)(mojeCelo * 2);
        //System.Console.WriteLine("Moje kratko število je: " + mojeKratko);

        //---------------NALOGA 6 FORMATIRANJE IZPISA V KONZOLNEM OKNU---------------
        int st1 = 20;
        double st2 = -13.6667;
        int st3 = 17;
        double st4 = 12.88;
        double st5 = 2222.879;

        Console.WriteLine("{0,20}", st1);
        Console.WriteLine("{0,20:f2}", st2);
        Console.WriteLine("{0,20}", st3);
        Console.WriteLine("{0,20:f2}", st4);
        Console.WriteLine("{0,20:f2}", st5);

        Console.ReadKey();
    }
}

