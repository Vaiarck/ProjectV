namespace ProjectV
{
    partial class Bucket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button7 = new Button();
            listBox1 = new ListBox();
            label5 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(317, 19);
            button5.Name = "button5";
            button5.Size = new Size(163, 64);
            button5.TabIndex = 12;
            button5.Text = "Корзина покупателя";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(70, 70, 72);
            panel3.Controls.Add(button5);
            panel3.Location = new Point(-3, 335);
            panel3.Name = "panel3";
            panel3.Size = new Size(807, 116);
            panel3.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 53, 57);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 339);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 51);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 18;
            label2.Text = "Количество выюранного товара";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 51);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 17;
            label1.Text = "Товары";
            // 
            // button7
            // 
            button7.Location = new Point(475, 255);
            button7.Name = "button7";
            button7.Size = new Size(99, 45);
            button7.TabIndex = 16;
            button7.Text = "Добавить в карзину";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(72, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(280, 214);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 86);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 14;
            label5.Text = "Кол-во";
            label5.Click += label5_Click;
            // 
            // Bucket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Bucket";
            Text = "Карзина";
            TopMost = true;
            Load += Bucket_Load;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Panel panel3;
        private Panel panel1;
        private Label label5;
        private ListBox listBox1;
        private Button button7;
        private Label label2;
        private Label label1;
    }
}