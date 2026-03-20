namespace Visual_Studio_Vaje_03_20_1
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
            risalniPanel = new Panel();
            buttonPocisti = new Button();
            radioButtonRdeca = new RadioButton();
            radioButtonModra = new RadioButton();
            radioButtonCrna = new RadioButton();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // risalniPanel
            // 
            risalniPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            risalniPanel.BackColor = SystemColors.ButtonHighlight;
            risalniPanel.Location = new Point(108, 59);
            risalniPanel.Name = "risalniPanel";
            risalniPanel.Size = new Size(500, 300);
            risalniPanel.TabIndex = 0;
            risalniPanel.MouseDown += risalniPanel_MouseDown;
            risalniPanel.MouseMove += risalniPanel_MouseMove;
            risalniPanel.MouseUp += risalniPanel_MouseUp;
            // 
            // buttonPocisti
            // 
            buttonPocisti.Location = new Point(12, 12);
            buttonPocisti.Name = "buttonPocisti";
            buttonPocisti.Size = new Size(94, 29);
            buttonPocisti.TabIndex = 1;
            buttonPocisti.Text = "Pocisti";
            buttonPocisti.UseVisualStyleBackColor = true;
            buttonPocisti.Click += buttonPocisti_Click;
            // 
            // radioButtonRdeca
            // 
            radioButtonRdeca.AutoSize = true;
            radioButtonRdeca.Location = new Point(47, 392);
            radioButtonRdeca.Name = "radioButtonRdeca";
            radioButtonRdeca.Size = new Size(71, 24);
            radioButtonRdeca.TabIndex = 2;
            radioButtonRdeca.TabStop = true;
            radioButtonRdeca.Text = "Rdeca";
            radioButtonRdeca.UseVisualStyleBackColor = true;
            radioButtonRdeca.CheckedChanged += radioButtonRdeca_CheckedChanged;
            // 
            // radioButtonModra
            // 
            radioButtonModra.AutoSize = true;
            radioButtonModra.Location = new Point(148, 392);
            radioButtonModra.Name = "radioButtonModra";
            radioButtonModra.Size = new Size(74, 24);
            radioButtonModra.TabIndex = 3;
            radioButtonModra.TabStop = true;
            radioButtonModra.Text = "Modra";
            radioButtonModra.UseVisualStyleBackColor = true;
            radioButtonModra.CheckedChanged += radioButtonModra_CheckedChanged;
            // 
            // radioButtonCrna
            // 
            radioButtonCrna.AutoSize = true;
            radioButtonCrna.Location = new Point(252, 392);
            radioButtonCrna.Name = "radioButtonCrna";
            radioButtonCrna.Size = new Size(60, 24);
            radioButtonCrna.TabIndex = 4;
            radioButtonCrna.TabStop = true;
            radioButtonCrna.Text = "Crna";
            radioButtonCrna.UseVisualStyleBackColor = true;
            radioButtonCrna.CheckedChanged += radioButtonCrna_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2", "4", "6", "8", "10" });
            comboBox1.Location = new Point(580, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(radioButtonCrna);
            Controls.Add(radioButtonModra);
            Controls.Add(radioButtonRdeca);
            Controls.Add(buttonPocisti);
            Controls.Add(risalniPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel risalniPanel;
        private Button buttonPocisti;
        private RadioButton radioButtonRdeca;
        private RadioButton radioButtonModra;
        private RadioButton radioButtonCrna;
        private ComboBox comboBox1;
    }
}
