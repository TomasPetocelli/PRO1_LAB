namespace Visual_Studio_Vaje_03_05
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
            label1 = new Label();
            textPrvo = new TextBox();
            label2 = new Label();
            textDrugo = new TextBox();
            groupBox1 = new GroupBox();
            radioDeljenje = new RadioButton();
            radioMnozenje = new RadioButton();
            radioOdstej = new RadioButton();
            radioSestej = new RadioButton();
            label3 = new Label();
            textRezultat = new TextBox();
            checkBoxNegativna = new CheckBox();
            buttonIzracunaj = new Button();
            buttonIzhod = new Button();
            buttonPocisti = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 39);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Prvo Stevilo";
            // 
            // textPrvo
            // 
            textPrvo.Location = new Point(176, 36);
            textPrvo.Name = "textPrvo";
            textPrvo.Size = new Size(125, 27);
            textPrvo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 71);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 2;
            label2.Text = "Drugo Stevilo";
            // 
            // textDrugo
            // 
            textDrugo.Location = new Point(176, 71);
            textDrugo.Name = "textDrugo";
            textDrugo.Size = new Size(125, 27);
            textDrugo.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioDeljenje);
            groupBox1.Controls.Add(radioMnozenje);
            groupBox1.Controls.Add(radioOdstej);
            groupBox1.Controls.Add(radioSestej);
            groupBox1.Location = new Point(411, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(138, 161);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operacije";
            // 
            // radioDeljenje
            // 
            radioDeljenje.AutoSize = true;
            radioDeljenje.Location = new Point(19, 116);
            radioDeljenje.Name = "radioDeljenje";
            radioDeljenje.Size = new Size(85, 24);
            radioDeljenje.TabIndex = 3;
            radioDeljenje.TabStop = true;
            radioDeljenje.Text = "Deljenje";
            radioDeljenje.UseVisualStyleBackColor = true;
            // 
            // radioMnozenje
            // 
            radioMnozenje.AutoSize = true;
            radioMnozenje.Location = new Point(19, 86);
            radioMnozenje.Name = "radioMnozenje";
            radioMnozenje.Size = new Size(95, 24);
            radioMnozenje.TabIndex = 2;
            radioMnozenje.TabStop = true;
            radioMnozenje.Text = "Mnozenje";
            radioMnozenje.UseVisualStyleBackColor = true;
            // 
            // radioOdstej
            // 
            radioOdstej.AutoSize = true;
            radioOdstej.Location = new Point(19, 56);
            radioOdstej.Name = "radioOdstej";
            radioOdstej.Size = new Size(73, 24);
            radioOdstej.TabIndex = 1;
            radioOdstej.TabStop = true;
            radioOdstej.Text = "Odstej";
            radioOdstej.UseVisualStyleBackColor = true;
            // 
            // radioSestej
            // 
            radioSestej.AutoSize = true;
            radioSestej.Location = new Point(19, 26);
            radioSestej.Name = "radioSestej";
            radioSestej.Size = new Size(69, 24);
            radioSestej.TabIndex = 0;
            radioSestej.TabStop = true;
            radioSestej.Text = "Sestej";
            radioSestej.UseVisualStyleBackColor = true;
            radioSestej.CheckedChanged += radioSestej_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 177);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 5;
            label3.Text = "Rezultat";
            label3.Click += label3_Click;
            // 
            // textRezultat
            // 
            textRezultat.Location = new Point(176, 177);
            textRezultat.Name = "textRezultat";
            textRezultat.Size = new Size(125, 27);
            textRezultat.TabIndex = 6;
            // 
            // checkBoxNegativna
            // 
            checkBoxNegativna.AutoSize = true;
            checkBoxNegativna.Location = new Point(59, 227);
            checkBoxNegativna.Name = "checkBoxNegativna";
            checkBoxNegativna.Size = new Size(253, 24);
            checkBoxNegativna.TabIndex = 7;
            checkBoxNegativna.Text = "Pobarvaj ce je vrednost negativna";
            checkBoxNegativna.UseVisualStyleBackColor = true;
            // 
            // buttonIzracunaj
            // 
            buttonIzracunaj.Location = new Point(59, 290);
            buttonIzracunaj.Name = "buttonIzracunaj";
            buttonIzracunaj.Size = new Size(94, 29);
            buttonIzracunaj.TabIndex = 8;
            buttonIzracunaj.Text = "Izracunaj";
            buttonIzracunaj.UseVisualStyleBackColor = true;
            buttonIzracunaj.Click += buttonIzracunaj_Click;
            // 
            // buttonIzhod
            // 
            buttonIzhod.Location = new Point(259, 290);
            buttonIzhod.Name = "buttonIzhod";
            buttonIzhod.Size = new Size(94, 29);
            buttonIzhod.TabIndex = 9;
            buttonIzhod.Text = "Izhod";
            buttonIzhod.UseVisualStyleBackColor = true;
            buttonIzhod.Click += buttonIzhod_Click;
            // 
            // buttonPocisti
            // 
            buttonPocisti.Location = new Point(159, 290);
            buttonPocisti.Name = "buttonPocisti";
            buttonPocisti.Size = new Size(94, 29);
            buttonPocisti.TabIndex = 10;
            buttonPocisti.Text = "Pocisti";
            buttonPocisti.UseVisualStyleBackColor = true;
            buttonPocisti.Click += buttonPocisti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPocisti);
            Controls.Add(buttonIzhod);
            Controls.Add(buttonIzracunaj);
            Controls.Add(checkBoxNegativna);
            Controls.Add(textRezultat);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(textDrugo);
            Controls.Add(label2);
            Controls.Add(textPrvo);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enostaven Kalkulator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textPrvo;
        private Label label2;
        private TextBox textDrugo;
        private GroupBox groupBox1;
        private RadioButton radioMnozenje;
        private RadioButton radioOdstej;
        private RadioButton radioSestej;
        private RadioButton radioDeljenje;
        private Label label3;
        private TextBox textRezultat;
        private CheckBox checkBoxNegativna;
        private Button buttonIzracunaj;
        private Button buttonIzhod;
        private Button buttonPocisti;
    }
}
