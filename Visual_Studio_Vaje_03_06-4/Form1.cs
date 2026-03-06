namespace Visual_Studio_Vaje_03_06_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            comboBox1.Items.Add("CD");
            comboBox1.Items.Add("Video");
            comboBox1.Items.Add("DVD");
        }

        private void label1_Click(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == 0) {
                CD cd = new CD();
                labelZnesek.Text = cd.Izracun((int)numericUpDown1.Value).ToString() + "EUR";
            } else if (comboBox1.SelectedIndex == 1) {
                Video v = new Video(0.5);
                labelZnesek.Text = v.Izracun((int)numericUpDown1.Value).ToString() + "EUR";
            } else if (comboBox1.SelectedIndex == 2) {
                DVD dvd = new DVD(0.5, 5);
                labelZnesek.Text = dvd.Izracun((int)numericUpDown1.Value).ToString() + "EUR";
            }
        }
    }
}
