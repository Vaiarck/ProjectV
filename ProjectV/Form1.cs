using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices;
using System.Security.Cryptography;
using System.Text;

namespace ProjectV
{

        public class User
        {
            public int Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }

        }
        public class Sclad 
        {
            public int Id { get; set; }
            public string NameP { get; set; }
            public string Fats { get; set; }
            public string Carbohydrates { get; set; }
            public string Quantity { get; set; }

        }
        public class BuyU
    {
        public int Id { get; set; }
        public string All { get; set; }
        public string KolVo { get; set; }
    }
    public class App
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Qq { get; set; }
        public string Condition { get; set; }
        public string OtherField { get; set; }
        public string AnotherField { get; set; }
        public string ExtraInfo { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }

    }


    public class Con: DbContext
    {
            public DbSet<User> Users { get; set; }
            public DbSet<Sclad> Sclads { get; set; }
            public DbSet<BuyU> BuyUs { get; set; }
            public DbSet<App> Apps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=relationsdb;Trusted_Connection=True;");
            }

    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {


            using (Con db = new())
            {
                //Раскоментировать когда буду добавлять новые строки и ТАблицы
                //db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                db.SaveChanges();
            }
        }

        public void Reg_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {

                string name = textBox1.Text;
                string password = textBox2.Text;
                string role = textBox3.Text;
                if (name == "" || password == "" || role == "") { MessageBox.Show("Неа"); }
                else
                {
                    string output;

                    //if (use) { MessageBox.Show("Такой пльзователь уже есть"); }
                    //else
                    {
                        User user = new() { Login = name, Password = password, Role = role };
                        db.Users.Add(user);
                        db.SaveChanges();
                        string text1 = string.Empty;
                        string text2 = string.Empty;
                        string text3 = string.Empty;
                        MessageBox.Show("Ок");
                        MD5 MD5Hash = MD5.Create();
                        byte[] inputBytes = Encoding.ASCII.GetBytes(text2);
                        byte[] hash = MD5Hash.ComputeHash(inputBytes);
                        output = Convert.ToHexString(hash);




                        text2 += output + '\n';
                        text1 += user.Password + "\n";
                        text3 += user.Role + "\n";

                        label1.Text += text2;
                        label2.Text += text1;
                        label3.Text += text3;
                    }


                }

                       
            }
        }




        public void Voiti_Click(object sender, EventArgs e)
        {
            using (Con db = new())
            {
                string name = textBox1.Text; string password = textBox2.Text;
                if (name == "" || password == "") { MessageBox.Show("Тут ничего нет либо зарегестрируйтесь либо введите коректные данные"); }
                else
                {
                    if (db.Users.Where(user => user.Login == name && user.Password == password).Any())
                    {
                        MessageBox.Show("вы авторизированы");
                        this.Hide();
                        Menu menu = new(this);
                        menu.Show();


                    }
                    else
                    {
                        MessageBox.Show("Зарегестрируйтесь пожалуйста");
                    }
                    
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lab_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
    }

}

