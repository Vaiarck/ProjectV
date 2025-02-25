namespace ProjectV
{
    partial class Buy
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
            button4 = new Button();
            button5 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            label8 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button6 = new Button();
            label5 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(487, 237);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 2);
            button5.Name = "button5";
            button5.Size = new Size(28, 28);
            button5.TabIndex = 16;
            button5.Text = "<-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(70, 70, 72);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(listBox1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(-3, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 286);
            panel3.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 34);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 21;
            label2.Text = "Количество выюранного товара";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 34);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 20;
            label1.Text = "Ваши товвары";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(63, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(301, 199);
            listBox1.TabIndex = 17;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 70);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 19;
            label8.Text = "Кол-во";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 53, 57);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 267);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 185);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(60, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 100);
            panel2.TabIndex = 18;
            // 
            // button6
            // 
            button6.Location = new Point(54, 3);
            button6.Name = "button6";
            button6.Size = new Size(543, 37);
            button6.TabIndex = 0;
            button6.Text = "Подать заявку";
            button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 53);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 17;
            label5.Text = "Состояние заказа";
            label5.Click += label5_Click;
            // 
            // Buy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Buy";
            Text = "Buy";
            TopMost = true;
            Load += Buy_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private Button button5;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Button button6;
        private Label label5;
        private ListBox listBox1;
        private Label label8;
        private Label label2;
        private Label label1;
    }
}