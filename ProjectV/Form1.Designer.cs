namespace ProjectV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Reg = new Button();
            Voiti = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Lab = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Reg
            // 
            Reg.Location = new Point(86, 287);
            Reg.Name = "Reg";
            Reg.Size = new Size(100, 23);
            Reg.TabIndex = 0;
            Reg.Text = "Рестрация";
            Reg.UseVisualStyleBackColor = true;
            Reg.Click += Reg_Click;
            // 
            // Voiti
            // 
            Voiti.Location = new Point(208, 287);
            Voiti.Name = "Voiti";
            Voiti.Size = new Size(100, 23);
            Voiti.TabIndex = 1;
            Voiti.Text = "Вход";
            Voiti.UseVisualStyleBackColor = true;
            Voiti.Click += Voiti_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Lab
            // 
            Lab.AutoSize = true;
            Lab.Location = new Point(169, 35);
            Lab.Name = "Lab";
            Lab.Size = new Size(76, 15);
            Lab.TabIndex = 4;
            Lab.Text = "Регистрация";
            Lab.Click += Lab_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(78, 132, 230);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(Lab);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 100);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._9055532_bxs_key_icon;
            pictureBox3.Location = new Point(86, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(Reg);
            panel2.Controls.Add(Voiti);
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 353);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 41);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(145, 216);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 3);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._9023606_lock_key_open_fill_icon;
            pictureBox2.Location = new Point(12, 145);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9023606_lock_key_open_fill_icon;
            pictureBox1.Location = new Point(12, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Reg;
        private Button Voiti;
        public TextBox textBox1;
        public TextBox textBox2;
        private Label Lab;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        public TextBox textBox3;
        private Label label3;
    }
}
