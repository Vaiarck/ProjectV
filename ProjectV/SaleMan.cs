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
        public SaleMan()
        {
            InitializeComponent();
        }

        private void SaleMan_Load(object sender, EventArgs e)
        {


            label1.Text = "";
            label2.Text = "";
            using (Con db = new())
            {
                //List<App> Apps = db.Apps.ToList();
                //App app = new App();
                //label1.Text = $"{app.Product + '\n' + app.Condition + '\n' + app.Description + '\n' + app.OtherField}" + '\n'; ;
                //label2.Text = $"{app.Qq + '\n' + app.AnotherField + '\n' + app.ExtraInfo + '\n' + app.Comments}" + "\n";

                // Извлечение всех записей из таблицы Apps
                var apps = db.Apps.ToList(); // Получаем список всех объектов App

                // Пример: вывод данных в DataGridView

                // Если хотите вывести данные в метках:
                foreach (var app in apps)
                {
                    // Например, выводим данные в метки на форме
                    label1.Text += $"{app.Product + '\n' + app.Condition + '\n' + app.Description + '\n' + app.OtherField}" + '\n';
                    label2.Text += $"{app.Qq + '\n' + app.AnotherField + '\n' + app.ExtraInfo + '\n' + app.Comments + '\n' + app.Status}" + "\n";

                }
                App aap = new App();
                comboBox1.Items.AddRange(new string[] { "Заказ на рассмотрении", "Заказ собирается", "Заказ собран" });
                comboBox1.SelectedItem = aap.Status;

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
                db.Apps.First().Status = comboBox1.Text;
                db.SaveChanges();
            }
        }
    }
}
