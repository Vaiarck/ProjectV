using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

namespace ProjectV
{
    public partial class Menu : Form
    {
        private Form1 form1;

        public Menu(Form1 form1, int id)
        {
            UserId = id;
            this.form1 = form1;
            InitializeComponent();

        }
        int UserId { get; set; }
        private void Menu_Load(object sender, EventArgs e)
        {
            Font SmallFont = new Font("Arial", 8);
            Font MediumFont = new Font("Arial", 10);
            Font LargeFont = new Font("Arial", 20);

            label1.Font = LargeFont;
            label2.Font = LargeFont;
            label3.Font = LargeFont;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (form1.textBox3.Text == "Покупатель" || form1.textBox3.Text == "Admin")
            {
                MessageBox.Show("Вы покупатель");
                this.Hide();
                Bucket kr = new Bucket(UserId);
                kr.Show();

            }
            else
            {
                MessageBox.Show("У вашей роли нет прав");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (form1.textBox3.Text == "Кладовщик" || form1.textBox3.Text == "Admin")
            {
                MessageBox.Show("Вы кладовщик");
                this.Hide();
                Storage sk = new Storage(UserId);
                sk.Show();
            }
            else
            {
                MessageBox.Show("У вашей роли нет прав");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (form1.textBox3.Text == "Кладовщик" || form1.textBox3.Text == "Admin")
            {
                MessageBox.Show("Вы кладовщик");
                this.Hide();
                Storage sk = new Storage(UserId);
                sk.Show();
            }
            else
            {
                MessageBox.Show("У вашей роли нет прав");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (form1.textBox3.Text == "Продавец" || form1.textBox3.Text == "Admin")
            {
                MessageBox.Show("Вы продавец");
                this.Hide();
                SaleMan pr = new SaleMan(UserId);
                pr.Show();
            }
            else
            {
                MessageBox.Show("У вашей роли нет прав");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (form1.textBox3.Text == "Продавец" || form1.textBox3.Text == "Admin")
            {
                MessageBox.Show("Вы продавец");
                this.Hide();
                SaleMan pr = new SaleMan(UserId);
                pr.Show();
            }
            else
            {
                MessageBox.Show("У вашей роли нет прав");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (form1.textBox3.Text == "Покупатель" || form1.textBox3.Text == "Admin")
            {
                MessageBox.Show("Вы покупатель");
                this.Hide();
                Bucket kr = new Bucket(UserId);
                kr.Show();

            }
            else
            {
                MessageBox.Show("У вашей роли нет прав");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
