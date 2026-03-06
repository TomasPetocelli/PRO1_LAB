namespace Visual_Studio_Vaje_03_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = colorDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("Barve pisave nisi zamenjal.", "OPOZORILO");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = fontDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
            else
            {
                MessageBox.Show("Pisave nisi zamenjal.", "OPOZORILO");
            }
        }
    }
}
