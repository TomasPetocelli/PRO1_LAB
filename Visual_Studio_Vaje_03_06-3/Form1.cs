namespace Visual_Studio_Vaje_03_06_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonAng_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxStudent.Text = "Student Anglescine";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            textBoxVmesna.Clear();
            textBoxKoncna.Clear();
            textBoxSeminar.Clear();
            textBoxUstna.Clear();

            textBoxVmesna.Visible = true;
            textBoxKoncna.Visible = true;
            textBoxSeminar.Visible = true;
            textBoxUstna.Visible = true;

            labelRezultat.Text = "";
        }

        private void radioButtonMat_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxStudent.Text = "Student Matematike";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;

            textBoxVmesna.Clear();
            textBoxKoncna.Clear();
            textBoxSeminar.Clear();
            textBoxUstna.Clear();

            textBoxVmesna.Visible = true;
            textBoxKoncna.Visible = true;
            textBoxSeminar.Visible = false;
            textBoxUstna.Visible = false;

            labelRezultat.Text = "";
        }

        private void radioButtonNar_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxStudent.Text = "Student Naravoslovja";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = false;

            textBoxVmesna.Clear();
            textBoxKoncna.Clear();
            textBoxSeminar.Clear();
            textBoxUstna.Clear();

            textBoxVmesna.Visible = true;
            textBoxKoncna.Visible = true;
            textBoxSeminar.Visible = true;
            textBoxUstna.Visible = false;

            labelRezultat.Text = "";
        }

        private void buttonPonastavi_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            textBoxVmesna.Clear();
            textBoxKoncna.Clear();
            textBoxSeminar.Clear();
            textBoxUstna.Clear();

            labelRezultat.Text = "";
        }

        private void buttonIzhod_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonIzracunaj_Click(object sender, EventArgs e) {
            if (radioButtonAng.Checked) {
                StudentAng ang = new StudentAng();
                try {
                    ang.Vmesna = int.Parse(textBoxVmesna.Text);
                    ang.Koncna = int.Parse(textBoxKoncna.Text);
                    ang.Seminar = int.Parse(textBoxSeminar.Text);
                    ang.Ustna = int.Parse(textBoxUstna.Text);
                    ang.Racunaj();
                    labelRezultat.Text = "Koncna ocena predmeta: " + ang.Ocena;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            

            if (radioButtonMat.Checked) {
                StudentMat mat = new StudentMat();
                try {
                    mat.Vmesna = int.Parse(textBoxVmesna.Text);
                    mat.Koncna = int.Parse(textBoxKoncna.Text);
                    mat.Racunaj();
                    labelRezultat.Text = "Koncna ocena predmeta: " + mat.Ocena;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

            if (radioButtonNar.Checked) {
                StudentNar nar = new StudentNar();
                try {
                    nar.Vmesna = int.Parse(textBoxVmesna.Text);
                    nar.Koncna = int.Parse(textBoxKoncna.Text);
                    nar.Seminar = int.Parse(textBoxSeminar.Text);
                    nar.Racunaj();
                    labelRezultat.Text = "Koncna ocena predmeta: " + nar.Ocena;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
