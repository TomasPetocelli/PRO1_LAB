namespace Visual_Studio_Vaje_03_20_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            PosodobiBarvo();
        }//Konec Form1

        private void PosodobiBarvo() {
            int r = trackBar1.Value;
            int g = trackBar2.Value;
            int b = trackBar3.Value;

            textBox1.Text = $"R={r} G={g} B={b}";
            panel1.BackColor = Color.FromArgb(r, g, b);
        }//Konec PosodobiBarvo

        private void Form1_Load(object sender, EventArgs e) { }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            PosodobiBarvo();
        }//Konec trackBar1_Scroll

        private void trackBar2_Scroll(object sender, EventArgs e) {
            PosodobiBarvo();
        }//Konec trackBar2_Scroll

        private void trackBar3_Scroll(object sender, EventArgs e) {
            PosodobiBarvo();
        }//Konec trackBar3_Scroll

        private void button1_Click(object sender, EventArgs e) {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;

            PosodobiBarvo();
        }//Konec button1_Click
    }//Konec Form1
}
