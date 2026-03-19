namespace Visual_Studio_Vaje_03_19_1
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxIme = new TextBox();
            textBoxEposta = new TextBox();
            textBoxTelefon = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(38, 49);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(332, 144);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 208);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 248);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "E-posta";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 289);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefon";
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(168, 205);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(202, 27);
            textBoxIme.TabIndex = 4;
            // 
            // textBoxEposta
            // 
            textBoxEposta.Location = new Point(168, 245);
            textBoxEposta.Name = "textBoxEposta";
            textBoxEposta.Size = new Size(202, 27);
            textBoxEposta.TabIndex = 5;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(168, 286);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(202, 27);
            textBoxTelefon.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(38, 357);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 7;
            button1.Text = "Dodaj nov";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 357);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 8;
            button2.Text = "Potrdi vnos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxTelefon);
            Controls.Add(textBoxEposta);
            Controls.Add(textBoxIme);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxIme;
        private TextBox textBoxEposta;
        private TextBox textBoxTelefon;
        private Button button1;
        private Button button2;
    }
}
