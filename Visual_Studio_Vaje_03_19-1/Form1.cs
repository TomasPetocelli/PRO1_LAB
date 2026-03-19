namespace Visual_Studio_Vaje_03_19_1 {
    public partial class Form1 : Form {
        Kontakti[] mojiKontakti = {
            new Kontakti{ime = "Peter Klepec", eposta = "peter@klepec.si", telefon = "00111222"},
            new Kontakti{ime = "Jana Koren", eposta = "jana@koren.si", telefon = "111222333"},
            new Kontakti{ime = "Klemen Saksida", eposta = "klemen@saksida.si", telefon = "56518165181"},
            new Kontakti{ime = "Anja Marlot", eposta = "anja@marlot.si", telefon = "989565489165"},
            null
        };
        public Form1() {
            InitializeComponent();
            Izpis();
        }//Konec Form1

        public void Izpis() {
            listBox1.Items.Clear();

            foreach (Kontakti k in mojiKontakti) {
                if (k != null) {
                    listBox1.Items.Add(k.ime);
                }//Konec if 
            }//Konec foreach
        }//Konec Izpis

        private void label2_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) {
            textBoxIme.Clear();
            textBoxEposta.Clear();
            textBoxTelefon.Clear();

            textBoxIme.Focus();
        }//Konec button1_Click

        private void button2_Click(object sender, EventArgs e) {
            mojiKontakti[4] = new Kontakti { ime = textBoxIme.Text, eposta = textBoxEposta.Text, telefon = textBoxTelefon.Text };
            Izpis();
        }//Konec button2_Click
    }
}
