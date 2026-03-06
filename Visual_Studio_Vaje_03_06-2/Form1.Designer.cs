namespace Visual_Studio_Vaje_03_06_2
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
            radioButtonGBP = new RadioButton();
            radioButtonCHF = new RadioButton();
            radioButtonUSD = new RadioButton();
            textBoxVnos = new TextBox();
            label1 = new Label();
            textBoxRezultat = new TextBox();
            labelRezultat = new Label();
            buttonIzracunaj = new Button();
            buttonPocisti = new Button();
            buttonIzhod = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonGBP);
            groupBox1.Controls.Add(radioButtonCHF);
            groupBox1.Controls.Add(radioButtonUSD);
            groupBox1.Location = new Point(28, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(136, 228);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tecaj";
            // 
            // radioButtonGBP
            // 
            radioButtonGBP.AutoSize = true;
            radioButtonGBP.Location = new Point(42, 148);
            radioButtonGBP.Name = "radioButtonGBP";
            radioButtonGBP.Size = new Size(57, 24);
            radioButtonGBP.TabIndex = 2;
            radioButtonGBP.TabStop = true;
            radioButtonGBP.Text = "GBP";
            radioButtonGBP.UseVisualStyleBackColor = true;
            // 
            // radioButtonCHF
            // 
            radioButtonCHF.AutoSize = true;
            radioButtonCHF.Location = new Point(42, 90);
            radioButtonCHF.Name = "radioButtonCHF";
            radioButtonCHF.Size = new Size(57, 24);
            radioButtonCHF.TabIndex = 1;
            radioButtonCHF.TabStop = true;
            radioButtonCHF.Text = "CHF";
            radioButtonCHF.UseVisualStyleBackColor = true;
            // 
            // radioButtonUSD
            // 
            radioButtonUSD.AutoSize = true;
            radioButtonUSD.Location = new Point(42, 42);
            radioButtonUSD.Name = "radioButtonUSD";
            radioButtonUSD.Size = new Size(59, 24);
            radioButtonUSD.TabIndex = 0;
            radioButtonUSD.TabStop = true;
            radioButtonUSD.Text = "USD";
            radioButtonUSD.UseVisualStyleBackColor = true;
            // 
            // textBoxVnos
            // 
            textBoxVnos.Location = new Point(216, 70);
            textBoxVnos.Name = "textBoxVnos";
            textBoxVnos.Size = new Size(125, 27);
            textBoxVnos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 73);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "EUR";
            // 
            // textBoxRezultat
            // 
            textBoxRezultat.Location = new Point(216, 125);
            textBoxRezultat.Name = "textBoxRezultat";
            textBoxRezultat.Size = new Size(125, 27);
            textBoxRezultat.TabIndex = 3;
            // 
            // labelRezultat
            // 
            labelRezultat.AutoSize = true;
            labelRezultat.Location = new Point(367, 128);
            labelRezultat.Name = "labelRezultat";
            labelRezultat.Size = new Size(0, 20);
            labelRezultat.TabIndex = 4;
            // 
            // buttonIzracunaj
            // 
            buttonIzracunaj.BackColor = SystemColors.ActiveBorder;
            buttonIzracunaj.Location = new Point(216, 186);
            buttonIzracunaj.Name = "buttonIzracunaj";
            buttonIzracunaj.Size = new Size(134, 80);
            buttonIzracunaj.TabIndex = 5;
            buttonIzracunaj.Text = "Izracunaj";
            buttonIzracunaj.UseVisualStyleBackColor = false;
            buttonIzracunaj.Click += buttonIzracunaj_Click;
            // 
            // buttonPocisti
            // 
            buttonPocisti.Location = new Point(367, 184);
            buttonPocisti.Name = "buttonPocisti";
            buttonPocisti.Size = new Size(94, 29);
            buttonPocisti.TabIndex = 6;
            buttonPocisti.Text = "Pocisti";
            buttonPocisti.UseVisualStyleBackColor = true;
            buttonPocisti.Click += buttonPocisti_Click;
            // 
            // buttonIzhod
            // 
            buttonIzhod.Location = new Point(367, 237);
            buttonIzhod.Name = "buttonIzhod";
            buttonIzhod.Size = new Size(94, 29);
            buttonIzhod.TabIndex = 7;
            buttonIzhod.Text = "Izhod";
            buttonIzhod.UseVisualStyleBackColor = true;
            buttonIzhod.Click += buttonIzhod_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonIzhod);
            Controls.Add(buttonPocisti);
            Controls.Add(buttonIzracunaj);
            Controls.Add(labelRezultat);
            Controls.Add(textBoxRezultat);
            Controls.Add(label1);
            Controls.Add(textBoxVnos);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonGBP;
        private RadioButton radioButtonCHF;
        private RadioButton radioButtonUSD;
        private TextBox textBoxVnos;
        private Label label1;
        private TextBox textBoxRezultat;
        private Label labelRezultat;
        private Button buttonIzracunaj;
        private Button buttonPocisti;
        private Button buttonIzhod;
    }
}
