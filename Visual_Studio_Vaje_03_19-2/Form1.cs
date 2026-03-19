using Visual_Studio_Vaje_03_19_;

namespace Visual_Studio_Vaje_03_19_2 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("trenutna obrestna mera: ...");
        }//Konec button1_Click

        private void button2_Click(object sender, EventArgs e) {
            try {
                double znesek = Convert.ToDouble(textBox1.Text);
                int steviloDni = Convert.ToInt32(numericUpDown1.Value);

                Depozit d = new Depozit("", 0, znesek, steviloDni, dateTimePicker1.Value);
                DateTime konecVezave = dateTimePicker1.Value.AddDays((int)numericUpDown1.Value);

                MessageBox.Show("Izracunane obresti: \n" + d.Obresti().ToString() + " EUR" + "\nDatum poteka vezave" + konecVezave.ToLongDateString());

            }catch {
                MessageBox.Show("Napaka v podatkih", "NAPAKA");
            }//konec try-catch
        }//konec button2_Click
    }
}
