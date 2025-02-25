using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectV
{
    public partial class SaleMan : Form
    {
        public SaleMan(int id)
        {
            UserId = id;
            InitializeComponent();
        }
        int UserId { get; set; }
        List<BuyU> buyUs;
        private void SaleMan_Load(object sender, EventArgs e)
        {

            using (Con db = new())
            {
                buyUs = db.BuyUs.Where(y => y.UserId == UserId).ToList();
                listBox1.Items.Clear();
                foreach (var s in buyUs)
                {
                    listBox1.Items.Add(s.All);
                }

                comboBox1.Items.AddRange(new string[] { "Заказ на рассмотрении", "Заказ собирается", "Заказ собран" });


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                //App aap = new App();
                //aap.Status = comboBox1.SelectedItem.ToString();
                //db.Entry(aap).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                //db.SaveChanges();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                if (listBox1.Text != string.Empty)
                {
                    BuyU buyU = db.BuyUs.Where(buyU => buyU.All == listBox1.Text).First();
                    List<BuyU> BuyUList = db.BuyUs.Where(d => d.UserId == UserId).ToList();
                    foreach (var item in BuyUList)
                    {
                        item.Stat = comboBox1.Text;
                    }
                    db.SaveChanges();

                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            Menu menu = new (form1, UserId);
            menu.Show(this);
        }
    }
}
