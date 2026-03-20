namespace Visual_Studio_Vaje_03_20_2
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
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 0;
            label1.Text = "R";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(65, 29);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(241, 56);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(65, 91);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(241, 56);
            trackBar2.TabIndex = 2;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(65, 153);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(241, 56);
            trackBar3.TabIndex = 3;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 91);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 4;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 153);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 5;
            label3.Text = "B";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(389, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 144);
            panel1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(389, 200);
            button1.Name = "button1";
            button1.Size = new Size(316, 29);
            button1.TabIndex = 8;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 278);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Barve";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
    }
}
