namespace Visual_Studio_Vaje_03_20_1 {
    public partial class Form1 : Form
    {
        private bool seRise = false;
        private Point prejsnjaTocka;
        private Bitmap risalnaPovrsina;
        private Graphics g;

        private Pen trenutnaBarva = Pens.Black;
        private float trenutnaDebelina = 1.0f;
        public Form1()
        {
            InitializeComponent();
            risalnaPovrsina = new Bitmap(risalniPanel.Width, risalniPanel.Height);
            g = Graphics.FromImage(risalnaPovrsina);
            g.Clear(Color.White);
            risalniPanel.BackgroundImage = risalnaPovrsina;
        }//Konec Form1

        private void Form1_Load(object sender, EventArgs e) { }

        private void risalniPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                seRise = true;
                prejsnjaTocka = e.Location;
            }//Konec if
        }//Konec risalniPanel_MouseDown

        private void risalniPanel_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left)
            {
                seRise = false;
            }//Konec if
        }//Konec risalniPanel_MouseUp

        private void risalniPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (seRise)
            {
                g.DrawLine(trenutnaBarva, prejsnjaTocka, e.Location);
                risalniPanel.BackgroundImage = risalnaPovrsina;
                risalniPanel.Invalidate();
                prejsnjaTocka = e.Location;
            }//Konec if
        }//Konec risalniPanel_MouseMove

        private void Form1_Click(object sender, EventArgs e) { }

        private void buttonPocisti_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            risalniPanel.BackgroundImage = risalnaPovrsina;
            risalniPanel.Invalidate();
        }//Konec buttonPocisti_Click

        private void radioButtonRdeca_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRdeca.Checked)
            {
                trenutnaBarva = new Pen(Color.Red, trenutnaDebelina);
            }//Konec if
        }//Konec radioButtonRdeca_CheckedChanged

        private void radioButtonModra_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonModra.Checked)
            {
                trenutnaBarva = new Pen(Color.Blue, trenutnaDebelina);
            }//Konec if
        }//Konec radioButtonModra_CheckedChanged

        private void radioButtonCrna_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCrna.Checked)
            {
                trenutnaBarva = new Pen(Color.Black, trenutnaDebelina);
            }//Konec if
        }//Konec radioButtonCrna_CheckedChanged

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (float.TryParse(comboBox1.SelectedItem.ToString(), out float novaDebelina))
            {
               trenutnaDebelina = novaDebelina;
                Color barva = trenutnaBarva.Color;
                trenutnaBarva = new Pen(barva, trenutnaDebelina);
            }//Konec if
        }//Konec comboBox1_SelectedIndexChanged
    }//Konec class Form1
}
