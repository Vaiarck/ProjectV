using Microsoft.Identity.Client;
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
        public Storage()
        {
            InitializeComponent();
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label1.ForeColor = Color.Coral;
            label2.ForeColor = Color.Coral;
            label3.ForeColor = Color.Coral;
            label4.ForeColor = Color.Coral;
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
                List<Sclad> Sclads = db.Sclads.ToList();
                //string skl1 = string.Join(Environment.NewLine, Sclads.Select(u => $"{u.NameP},Жиры:{u.Fats},Углеводы:{u.Carbohydrates}"));
                //string skl2 = string.Join(Environment.NewLine, Sclads.Select(g => $"{g.Quantity}"));

                for (int i = 0; i < Math.Min(4, Sclads.Count); i++)
                {
                    var sclad = Sclads[i];
                    // Проверяем, есть ли свободное место для заполнения
                    //if (index < 3) // Предполагаем, что у нас есть 3 пары Label и TextBox
                    //{
                    // Используем индекс для доступа к элементам управления
                    Label currentLabel = this.Controls.Find($"label{i + 1}", true).FirstOrDefault() as Label;


                    if (currentLabel != null)
                    {


                        string LabelText = $"{sclad.NameP}";
                        //,Жиры: { sclad.Fats},Углеводы: { sclad.Carbohydrates}, Количетсво { sclad.Quantity}
                        currentLabel.Text = LabelText;

                        // Заполнение элементов управления новыми данными
                        //currentLabel.Text = skl1;
                        //currentTextBox.Text = skl2;
                        // Увеличиваем индекс для следующей записи

                    }

                    //}

                }
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

                        label1.Text += text1;
                        label2.Text += text2;
                        label3.Text += text3;
                        label4.Text += text4;

                        List<Sclad> Sclads = db.Sclads.ToList();
                        //string skl1 = string.Join(Environment.NewLine, Sclads.Select(u => $"{u.NameP},Жиры:{u.Fats},Углеводы:{u.Carbohydrates}"));
                        //string skl2 = string.Join(Environment.NewLine, Sclads.Select(g => $"{g.Quantity}"));

                        for (int i = 0; i < Math.Min(4, Sclads.Count); i++)
                        {
                            sclad = Sclads[i];
                            // Проверяем, есть ли свободное место для заполнения
                            //if (index < 3) // Предполагаем, что у нас есть 3 пары Label и TextBox
                            //{
                            // Используем индекс для доступа к элементам управления
                            Label currentLabel = this.Controls.Find($"label{i + 1}", true).FirstOrDefault() as Label;


                            if (currentLabel != null)
                            {


                                string LabelText = $"{sclad.NameP}";
                                currentLabel.Text = LabelText;
                                //,Жиры:{sclad.Fats},Углеводы:{sclad.Carbohydrates}, Количетсво {sclad.Quantity}


                                // Заполнение элементов управления новыми данными
                                //currentLabel.Text = skl1;
                                //currentTextBox.Text = skl2;
                                // Увеличиваем индекс для следующей записи

                            }

                            //}

                        }






                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bucket bucket = new Bucket();
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
                db.Sclads.RemoveRange(db.Sclads.Where(product => product.NameP == label1.Text));
                db.SaveChanges();
                label1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                db.Sclads.RemoveRange(db.Sclads.Where(product => product.NameP == label2.Text));
                db.SaveChanges();
                label2.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                db.Sclads.RemoveRange(db.Sclads.Where(product => product.NameP == label3.Text));
                db.SaveChanges();
                label3.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                db.Sclads.RemoveRange(db.Sclads.Where(product => product.NameP == label4.Text));
                db.SaveChanges();
                label4.Text = "";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
