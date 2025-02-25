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


        public Bucket(int id)
        {
            UserId = id;

            InitializeComponent();
        }
        int UserId { get; set; }
        private void Bucket_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            

            using (Con db = new())
            {
                List<Sclad> Sclads = db.Sclads.ToList();
                //string skl1 = string.Join(Environment.NewLine, Sclads.Select(u => $"{u.NameP},Жиры:{u.Fats},Углеводы:{u.Carbohydrates}"));
                //string skl2 = string.Join(Environment.NewLine, Sclads.Select(g => $"{g.Quantity}"));

                for (int i = 0; i < Math.Min(6, Sclads.Count); i++)
                {
                    var sclad = Sclads[i];
                    listBox1.Items.Add($"{sclad.NameP},Жиры:{sclad.Fats},Углеводы:{sclad.Carbohydrates}");
                    
                    // Проверяем, есть ли свободное место для заполнения
                    //if (index < 3) // Предполагаем, что у нас есть 3 пары Label и TextBox
                    //{
                    // Используем индекс для доступа к элементам управления
                    //Label currentLabel = this.Controls.Find($"label{i + 1}", true).FirstOrDefault() as Label;
                    //TextBox currentTextBox = this.Controls.Find($"textBox{i + 1}", true).FirstOrDefault() as TextBox;

                    //if (currentLabel != null && currentTextBox != null)
                    //{


                    //    string LabelText = $"{sclad.NameP},Жиры:{sclad.Fats},Углеводы:{sclad.Carbohydrates}";
                    //    string textBoxText = $"{sclad.Quantity}";
                    //    currentLabel.Text = LabelText;
                    //    currentTextBox.Text = textBoxText;
                    //    // Заполнение элементов управления новыми данными
                    //    //currentLabel.Text = skl1;
                    //    //currentTextBox.Text = skl2;
                    //    // Увеличиваем индекс для следующей записи

                    //}

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

        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy buy = new(this, UserId);
            buy.Show();
        }

        
        

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    using (Con db = new())
        //    {

        //        string all = label3.Text;
        //        string kolVo = textBox3.Text;
        //        if (all == "label3" || kolVo == "" || all == "") { MessageBox.Show("Неа"); }
        //        else
        //        {
        //            string output;


        //            if (!db.BuyUs.Any(o => o.UserId == UserId && o.All == all))
        //            {
        //                User user = db.Users.Where(user => user.Id == UserId).First();
        //                BuyU buyU = new() { All = all, KolVo = kolVo, User = user, Stat = string.Empty };
        //                db.BuyUs.Add(buyU);
        //                db.SaveChanges();
        //            }
        //            else
        //            {
        //                BuyU buyU = db.BuyUs.Where(o => o.UserId == UserId && o.All == all).First();
        //                int OldKolvo = int.Parse(buyU.KolVo);
        //                int NewKolvo = int.Parse(kolVo);
        //                buyU.KolVo = $"{OldKolvo + NewKolvo}";
        //                db.SaveChanges();
        //            }
        //        }
        //    }
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    using (Con db = new())
        //    {

        //        string all = label4.Text;
        //        string kolVo = textBox4.Text;
        //        if (all == "label4" || kolVo == "" || all == "") { MessageBox.Show("Неа"); }
        //        else
        //        {
        //            string output;


        //            if (!db.BuyUs.Any(o => o.UserId == UserId && o.All == all))
        //            {
        //                User user = db.Users.Where(user => user.Id == UserId).First();
        //                BuyU buyU = new() { All = all, KolVo = kolVo, User = user, Stat = string.Empty };
        //                db.BuyUs.Add(buyU);
        //                db.SaveChanges();
        //            }
        //            else
        //            {
        //                BuyU buyU = db.BuyUs.Where(o => o.UserId == UserId && o.All == all).First();
        //                int OldKolvo = int.Parse(buyU.KolVo);
        //                int NewKolvo = int.Parse(kolVo);
        //                buyU.KolVo = $"{OldKolvo + NewKolvo}";
        //                db.SaveChanges();
        //            }
        //        }
        //    }
        //}

       

        private void button7_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                string all = listBox1.Text;
                string kolVo = label5.Text;
                if (!db.BuyUs.Any(o => o.UserId == UserId && o.All == all))
                {
                    User user = db.Users.Where(user => user.Id == UserId).First();
                    BuyU buyU = new() { All = all, KolVo = kolVo, User = user, Stat = string.Empty };
                    db.BuyUs.Add(buyU);
                    db.SaveChanges();
                }
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                // Получаем выбранный продукт из listBox
                string selectedProduct = listBox1.SelectedItem.ToString();

                // Извлекаем название продукта из строки
                string productName = selectedProduct.Split(',')[0]; // Предполагаем, что имя продукта - первая часть строки

                // Находим соответствующий Sclad в базе данных
                Sclad sclad = db.Sclads.FirstOrDefault(p => p.NameP == productName);

                // Если продукт найден, обновляем label5
                if (sclad != null)
                {
                    label5.Text = sclad.Quantity.ToString(); // Обновляем текст label5 с количеством
                }
            }
        }
        //$"{sclad.NameP},Жиры:{sclad.Fats},Углеводы:{sclad.Carbohydrates}"
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}