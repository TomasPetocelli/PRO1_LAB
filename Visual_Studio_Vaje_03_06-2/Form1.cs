namespace Visual_Studio_Vaje_03_06_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPocisti_Click(object sender, EventArgs e)
        {
            textBoxVnos.Clear();
            textBoxRezultat.Clear();
            labelRezultat.Text = "";

            radioButtonUSD.Checked = true;
        }

        private void buttonIzhod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIzracunaj_Click(object sender, EventArgs e)
        {
            double vnos = double.Parse(textBoxVnos.Text);

            if (radioButtonUSD.Checked)
            {
                textBoxRezultat.Text=(vnos * 1.16).ToString();
                labelRezultat.Text = "USD";
            }

            if (radioButtonCHF.Checked)
            {
                textBoxRezultat.Text = (vnos * 0.91).ToString();
                labelRezultat.Text = "CHF";
            }

            if (radioButtonGBP.Checked)
            {
                textBoxRezultat.Text = (vnos * 0.87).ToString();
                labelRezultat.Text = "GBP";
            }
        }
    }
}
