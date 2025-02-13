using Microsoft.EntityFrameworkCore;
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
        public Buy()
        {
            InitializeComponent();
        }
        public Buy(Bucket bucket)
        {
            InitializeComponent();
            this.buy = buy;


        }
        private void Buy_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.Coral;
            using (Con db = new())
            {
                label5.Text = db.Apps.First().Status;
                //Раскоментировать когда буду добавлять новые строки и ТАблицы
                //db.Database.EnsureDeleted();

                db.Database.EnsureCreated();
                db.SaveChanges();
                List<BuyU> buyUs = db.BuyUs.ToList();
                for (int i = 0; i < Math.Min(4, buyUs.Count); i++)
                {
                    var buyU = buyUs[i];
                    Label currentLabel = this.Controls.Find($"label{i + 1}", true).FirstOrDefault() as Label;
                    TextBox currentTextBox = this.Controls.Find($"textBox{i + 1}", true).FirstOrDefault() as TextBox;

                    if (currentLabel != null && currentTextBox != null)
                    {


                        string LabelText = $"{buyU.All}";
                        string textBoxText = $"{buyU.KolVo}";
                        currentLabel.Text = LabelText;
                        currentTextBox.Text = textBoxText;


                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                db.BuyUs.RemoveRange(db.BuyUs.Where(product => product.All == label1.Text));
                db.SaveChanges();
                label1.Text = "";
                textBox1.Text = "";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bucket bucket = new Bucket();
            bucket.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                db.BuyUs.RemoveRange(db.BuyUs.Where(product => product.All == label2.Text));
                db.SaveChanges();
                label2.Text = "";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                db.BuyUs.RemoveRange(db.BuyUs.Where(product => product.All == label3.Text));
                db.SaveChanges();
                label3.Text = "";
                textBox3.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                db.BuyUs.RemoveRange(db.BuyUs.Where(product => product.All == label4.Text));
                db.SaveChanges();
                label4.Text = "";
                textBox4.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                //string product = label1.Text;
                //string qq = textBox1.Text;
                //string condition = label5.Text;


                //string output;

                ////if (use) { MessageBox.Show("Такой пльзователь уже есть"); }
                ////else

                //    App app = new() { Product = product, Qq = qq, Condition = condition };
                //    db.Apps.Add(app);
                //    db.SaveChanges();
                //    string text1 = string.Empty;
                //    string text2 = string.Empty;
                //    string text3 = string.Empty;
                //    MessageBox.Show("Ок");

                //    text2 += $"{app.Product}" + '\n';
                //    text1 += $"{app.Qq}" + "\n";
                //    text3 += $"{app.Condition}" + "\n";

                //    label6.Text += text2;
                //    label7.Text += text1;


                App app = new App();
                // Извлекаем данные из меток
                app.Product = label1.Text; // Данные из Label1
                app.Condition = label2.Text; // Данные из Label2
                app.Description = label3.Text; // Данные из Label3
                app.OtherField = label4.Text; // Данные из Label4 (предположим, что у вас есть поле OtherField в классе App)

                // Извлекаем данные из текстовых полей
                app.Qq = textBox1.Text; // Данные из TextBox1
                app.AnotherField = textBox2.Text; // Данные из TextBox2 (предположим, что у вас есть поле AnotherField в классе App)
                app.ExtraInfo = textBox3.Text; // Данные из TextBox3 (предположим, что у вас есть поле ExtraInfo в классе App)
                app.Comments = textBox4.Text; // Данные из TextBox4 (предположим, что у вас есть поле Comments в классе App)
                app.Status = label5.Text;

                // Добавление объекта в базу данных
                db.Apps.Add(app);
                db.SaveChanges();

                // Отображение сообщения об успешном добавлении


                // Обновление меток с новыми данными (если необходимо)
                label6.Text += $"{app.Product + '\n' + app.Condition + '\n' + app.Description + '\n' + app.OtherField}" + '\n';
                label7.Text += $"{app.Qq + '\n' + app.AnotherField + '\n' + app.ExtraInfo + '\n' + app.Comments}" + "\n";






            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
