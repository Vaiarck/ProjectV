using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectV
{
    public partial class Bucket : Form
    {


        public Bucket()
        {
            InitializeComponent();
        }

        private void Bucket_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;

            using (Con db = new())
            {

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
                    TextBox currentTextBox = this.Controls.Find($"textBox{i + 1}", true).FirstOrDefault() as TextBox;

                    if (currentLabel != null && currentTextBox != null)
                    {


                        string LabelText = $"{sclad.NameP},Жиры:{sclad.Fats},Углеводы:{sclad.Carbohydrates}";
                        string textBoxText = $"{sclad.Quantity}";
                        currentLabel.Text = LabelText;
                        currentTextBox.Text = textBoxText;
                        // Заполнение элементов управления новыми данными
                        //currentLabel.Text = skl1;
                        //currentTextBox.Text = skl2;
                        // Увеличиваем индекс для следующей записи

                    }

                    //}

                }





            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {

                string all = label1.Text;
                string kolVo = textBox1.Text;
                if (all == "label1" || kolVo == "" || all == "") { MessageBox.Show("Неа"); }
                else
                {
                    string output;


                    {
                        BuyU buyU = new() { All = all, KolVo = kolVo };
                        db.BuyUs.Add(buyU);
                        db.SaveChanges();


                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy buy = new(this);
            buy.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {

                string all = label2.Text;
                string kolVo = textBox2.Text;
                if (all == "label2" || kolVo == "" || all == "") { MessageBox.Show("Неа"); }
                else
                {
                    string output;


                    {
                        BuyU buyU = new() { All = all, KolVo = kolVo };
                        db.BuyUs.Add(buyU);
                        db.SaveChanges();


                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {

                string all = label3.Text;
                string kolVo = textBox3.Text;
                if (all == "label3" || kolVo == "" || all == "") { MessageBox.Show("Неа"); }
                else
                {
                    string output;


                    {
                        BuyU buyU = new() { All = all, KolVo = kolVo };
                        db.BuyUs.Add(buyU);
                        db.SaveChanges();


                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {

                string all = label4.Text;
                string kolVo = textBox4.Text;
                if (all == "label4" || kolVo == "" || all == "") { MessageBox.Show("Неа"); }
                else
                {
                    string output;


                    {
                        BuyU buyU = new() { All = all, KolVo = kolVo };
                        db.BuyUs.Add(buyU);
                        db.SaveChanges();


                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Storage storage = new Storage();
            storage.Show();
        }
    }
}