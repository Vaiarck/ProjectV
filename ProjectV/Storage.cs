using Microsoft.Identity.Client;
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
    public partial class Storage : Form
    {
        public Storage(int id)
        {
            UserId = id;
            InitializeComponent();
        }
        int UserId { get; set; }
        private void Storage_Load(object sender, EventArgs e)
        {
           
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;

            using (Con db = new())
            {
                //Раскоментировать когда буду добавлять новые строки и ТАблицы
                //db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                db.SaveChanges();
                List<Sclad> sclads = db.Sclads.ToList();

                // Очищаем ListBox перед добавлением новых элементов
                listBox1.Items.Clear();

                // Добавляем все названия продуктов в ListBox
                foreach (var sclad in sclads)
                {
                    listBox1.Items.Add(sclad.NameP);
                }


                //List<Sclad> Sclads = db.Sclads.ToList();


                //for (int i = 0; i < Math.Min(4, Sclads.Count); i++)
                //{
                //    var sclad = Sclads[i];
                //    Label currentLabel = this.Controls.Find($"label{i + 1}", true).FirstOrDefault() as Label;


                //    if (currentLabel != null)
                //    {


                //        string LabelText = $"{sclad.NameP}";
                //        currentLabel.Text = LabelText;



                //    }



            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {

                string name = textBox1.Text;
                string fats = textBox2.Text;
                string carbohydrates = textBox3.Text;
                string quantity = textBox4.Text;
                if (name == "" || fats == "" || carbohydrates == "" || quantity == "") { MessageBox.Show("Неа"); }
                else
                {
                    string output;

                    //if (use) { MessageBox.Show("Такой пльзователь уже есть"); }
                    //else
                    {
                        Sclad sclad = new() { NameP = name, Fats = fats, Carbohydrates = carbohydrates, Quantity = quantity };
                        db.Sclads.Add(sclad);
                        db.SaveChanges();
                        string text1 = string.Empty;
                        string text2 = string.Empty;
                        string text3 = string.Empty;
                        string text4 = string.Empty;
                        string text5 = string.Empty;

                        text1 = $"{sclad.NameP}";
                        text2 = $"{sclad.Fats}";
                        text3 = $"{sclad.Quantity}";
                        text4 = $"{sclad.Carbohydrates}";

                        

                        List<Sclad> Sclads = db.Sclads.ToList();
                        //listBox1.Items.Clear(); 
                        listBox1.Items.Add(sclad.NameP);
                        db.SaveChanges();

                        //for (int i = 0; i < Math.Min(4, Sclads.Count); i++)
                        //{
                        //    sclad = Sclads[i];

                        //    Label currentLabel = this.Controls.Find($"label{i + 1}", true).FirstOrDefault() as Label;


                        //    if (currentLabel != null)
                        //    {


                        //        string LabelText = $"{sclad.NameP}";
                        //        currentLabel.Text = LabelText;


                        //    }



                        //}






                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bucket bucket = new Bucket(UserId);
            bucket.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                db.Sclads.RemoveRange(db.Sclads.Where(product => product.NameP == listBox1.Text));
                db.SaveChanges();
                
            }
        }

      
        

        

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //using (Con db = new())
            //{
            //    if (listBox1.Text != string.Empty)
            //    {
            //        List<Sclad> Sclads;
            //        Sclads = db.Sclads.Where(q => q.NameP == textBox1.Text).ToList();
            //        Sclad sclad1 = Sclads.Where(a => a.NameP == listBox1.Text).First();
            //        label9.Text = sclad1.NameP;
            //    }
            //}
        }
    }
}
