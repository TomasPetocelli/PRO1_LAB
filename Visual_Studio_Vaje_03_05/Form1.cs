namespace Visual_Studio_Vaje_03_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioSestej_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonIzracunaj_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textPrvo.Text);
            int b = int.Parse(textDrugo.Text);

            try
            {
                if (radioSestej.Checked == true)
                {
                    textRezultat.Text = (a + b).ToString();
                }//Konec if Sestej

                if (radioOdstej.Checked == true)
                {
                    textRezultat.Text = (a - b).ToString();
                }//Konec if Odstej

                if (radioMnozenje.Checked == true)
                {
                    textRezultat.Text = (a * b).ToString();
                }//Konec if Mnozenje

                if (radioDeljenje.Checked == true)
                {
                    textRezultat.Text = (a / b).ToString();
                }//Konec if Deljenje

                if (double.Parse(textRezultat.Text) < 0 && checkBoxNegativna.Checked)
                {
                    textRezultat.ForeColor = Color.Red;
                }
                else
                {
                    textRezultat.ForeColor = Color.Black;
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Deljenje z 0", "OPOZORILO");
            }

            catch
            {
                MessageBox.Show("Izberi operacijo", "OPOZORILO");
            }
            
        }

        private void buttonIzhod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPocisti_Click(object sender, EventArgs e)
        {
            textPrvo.Clear();
            textDrugo.Clear();
            textRezultat.Clear();

            radioSestej.Checked = false;
            radioOdstej.Checked = false;
            radioMnozenje.Checked = false;
            radioDeljenje.Checked = false;

            checkBoxNegativna.Checked = false;
        }
    }
}
