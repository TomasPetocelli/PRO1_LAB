namespace Visual_Studio_Vaje_03_06_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioButtonNar = new RadioButton();
            radioButtonMat = new RadioButton();
            radioButtonAng = new RadioButton();
            groupBoxStudent = new GroupBox();
            textBoxUstna = new TextBox();
            textBoxSeminar = new TextBox();
            textBoxKoncna = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxVmesna = new TextBox();
            label1 = new Label();
            buttonIzracunaj = new Button();
            buttonPonastavi = new Button();
            buttonIzhod = new Button();
            labelRezultat = new Label();
            groupBox1.SuspendLayout();
            groupBoxStudent.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonNar);
            groupBox1.Controls.Add(radioButtonMat);
            groupBox1.Controls.Add(radioButtonAng);
            groupBox1.Location = new Point(51, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(158, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oddelek Studenta";
            // 
            // radioButtonNar
            // 
            radioButtonNar.AutoSize = true;
            radioButtonNar.Location = new Point(26, 105);
            radioButtonNar.Name = "radioButtonNar";
            radioButtonNar.Size = new Size(116, 24);
            radioButtonNar.TabIndex = 2;
            radioButtonNar.TabStop = true;
            radioButtonNar.Text = "Naravoslovje";
            radioButtonNar.UseVisualStyleBackColor = true;
            radioButtonNar.CheckedChanged += radioButtonNar_CheckedChanged;
            // 
            // radioButtonMat
            // 
            radioButtonMat.AutoSize = true;
            radioButtonMat.Location = new Point(26, 75);
            radioButtonMat.Name = "radioButtonMat";
            radioButtonMat.Size = new Size(109, 24);
            radioButtonMat.TabIndex = 1;
            radioButtonMat.TabStop = true;
            radioButtonMat.Text = "Matematika";
            radioButtonMat.UseVisualStyleBackColor = true;
            radioButtonMat.CheckedChanged += radioButtonMat_CheckedChanged;
            // 
            // radioButtonAng
            // 
            radioButtonAng.AutoSize = true;
            radioButtonAng.Location = new Point(26, 45);
            radioButtonAng.Name = "radioButtonAng";
            radioButtonAng.Size = new Size(102, 24);
            radioButtonAng.TabIndex = 0;
            radioButtonAng.TabStop = true;
            radioButtonAng.Text = "Anglescina";
            radioButtonAng.UseVisualStyleBackColor = true;
            radioButtonAng.CheckedChanged += radioButtonAng_CheckedChanged;
            // 
            // groupBoxStudent
            // 
            groupBoxStudent.Controls.Add(textBoxUstna);
            groupBoxStudent.Controls.Add(textBoxSeminar);
            groupBoxStudent.Controls.Add(textBoxKoncna);
            groupBoxStudent.Controls.Add(label4);
            groupBoxStudent.Controls.Add(label3);
            groupBoxStudent.Controls.Add(label2);
            groupBoxStudent.Controls.Add(textBoxVmesna);
            groupBoxStudent.Controls.Add(label1);
            groupBoxStudent.Location = new Point(325, 53);
            groupBoxStudent.Name = "groupBoxStudent";
            groupBoxStudent.Size = new Size(402, 225);
            groupBoxStudent.TabIndex = 1;
            groupBoxStudent.TabStop = false;
            // 
            // textBoxUstna
            // 
            textBoxUstna.Location = new Point(218, 131);
            textBoxUstna.Name = "textBoxUstna";
            textBoxUstna.Size = new Size(125, 27);
            textBoxUstna.TabIndex = 7;
            // 
            // textBoxSeminar
            // 
            textBoxSeminar.Location = new Point(218, 98);
            textBoxSeminar.Name = "textBoxSeminar";
            textBoxSeminar.Size = new Size(125, 27);
            textBoxSeminar.TabIndex = 6;
            // 
            // textBoxKoncna
            // 
            textBoxKoncna.Location = new Point(218, 65);
            textBoxKoncna.Name = "textBoxKoncna";
            textBoxKoncna.Size = new Size(125, 27);
            textBoxKoncna.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 131);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 4;
            label4.Text = "UstnaOcena";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 98);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 3;
            label3.Text = "Ocena Seminarja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 65);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 2;
            label2.Text = "Ocena Koncnega Izpita";
            // 
            // textBoxVmesna
            // 
            textBoxVmesna.Location = new Point(218, 32);
            textBoxVmesna.Name = "textBoxVmesna";
            textBoxVmesna.Size = new Size(125, 27);
            textBoxVmesna.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "Ocena Vmesnega Izpita";
            // 
            // buttonIzracunaj
            // 
            buttonIzracunaj.Location = new Point(325, 298);
            buttonIzracunaj.Name = "buttonIzracunaj";
            buttonIzracunaj.Size = new Size(402, 29);
            buttonIzracunaj.TabIndex = 2;
            buttonIzracunaj.Text = "Izracunaj Oceno";
            buttonIzracunaj.UseVisualStyleBackColor = true;
            buttonIzracunaj.Click += buttonIzracunaj_Click;
            // 
            // buttonPonastavi
            // 
            buttonPonastavi.Location = new Point(51, 298);
            buttonPonastavi.Name = "buttonPonastavi";
            buttonPonastavi.Size = new Size(158, 29);
            buttonPonastavi.TabIndex = 3;
            buttonPonastavi.Text = "Pocisti";
            buttonPonastavi.UseVisualStyleBackColor = true;
            buttonPonastavi.Click += buttonPonastavi_Click;
            // 
            // buttonIzhod
            // 
            buttonIzhod.Location = new Point(51, 333);
            buttonIzhod.Name = "buttonIzhod";
            buttonIzhod.Size = new Size(158, 29);
            buttonIzhod.TabIndex = 4;
            buttonIzhod.Text = "Izhod";
            buttonIzhod.UseVisualStyleBackColor = true;
            buttonIzhod.Click += buttonIzhod_Click;
            // 
            // labelRezultat
            // 
            labelRezultat.AutoSize = true;
            labelRezultat.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRezultat.Location = new Point(325, 356);
            labelRezultat.Name = "labelRezultat";
            labelRezultat.Size = new Size(0, 24);
            labelRezultat.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRezultat);
            Controls.Add(buttonIzhod);
            Controls.Add(buttonPonastavi);
            Controls.Add(buttonIzracunaj);
            Controls.Add(groupBoxStudent);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Kalkulator Ocen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxStudent.ResumeLayout(false);
            groupBoxStudent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonNar;
        private RadioButton radioButtonMat;
        private RadioButton radioButtonAng;
        private GroupBox groupBoxStudent;
        private TextBox textBoxSeminar;
        private TextBox textBoxKoncna;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxVmesna;
        private Label label1;
        private TextBox textBoxUstna;
        private Button buttonIzracunaj;
        private Button buttonPonastavi;
        private Button buttonIzhod;
        private Label labelRezultat;
    }
}
