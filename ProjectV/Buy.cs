using Microsoft.EntityFrameworkCore;
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

namespace ProjectV
{
    public partial class Buy : Form
    {
        private Buy buy;
        public Buy(int id)
        {
            UserId = id;
            InitializeComponent();
        }
        int UserId { get; set; }
        List<BuyU> buyUs;
        public Buy(Bucket bucket, int id)
        {
            InitializeComponent();
            this.buy = buy;
            UserId = id;

        }
        private void Buy_Load(object sender, EventArgs e)
        {

            label5.ForeColor = Color.Coral;
            using (Con db = new())
            {
                //Раскоментировать когда буду добавлять новые строки и ТАблицы
                //db.Database.EnsureDeleted();

                db.Database.EnsureCreated();
                db.SaveChanges();
                buyUs = db.BuyUs.Where(y => y.UserId == UserId).ToList();
                listBox1.Items.Clear();
                foreach (var s in buyUs)
                {
                    listBox1.Items.Add(s.All);
                }
                //label5.Text = db.BuyUs.Where(a => a.UserId == UserId).First().Stat;
                var buyU = db.BuyUs.FirstOrDefault(a => a.UserId == UserId);

                // Проверяем, есть ли запись
                if (buyU is not null && buyU.Stat != string.Empty)
                {
                    // Если запись найдена, устанавливаем значение свойства Stat в label5
                    label5.Text = buyU.Stat;
                }
                else
                {
                    // Если запись не найдена, устанавливаем текст по умолчанию
                    label5.Text = "Нет данных для отображения"; // Замените на нужный текст
                }

            }
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bucket bucket = new Bucket(UserId);

            bucket.Show();
        }





        private void button4_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                db.BuyUs.RemoveRange(db.BuyUs.Where(product => product.All == listBox1.Text));
                db.SaveChanges();
                buyUs = db.BuyUs.Where(y => y.UserId == UserId).ToList();
                listBox1.Items.Clear();
                foreach (var s in buyUs)
                {
                    listBox1.Items.Add(s.All);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listBox1.Text != string.Empty)
            {
                BuyU buyU = buyUs.Where(f => f.All == listBox1.Text).First();
                label8.Text = buyU.KolVo;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
