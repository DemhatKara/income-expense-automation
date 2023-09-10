using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Otomasyon
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=YUKSEL\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kullanici_login where kullanici_adi='" + textBox1.Text + "'And sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();


            if (dr.Read())
            {

                MessageBox.Show("Tebrikler Giriş Başarılı!");
                Form1 gecis = new Form1();
                gecis.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Üzgünüm Hatalı Kullanıcı Adı Veya Şifre!");
            }
            con.Close();
            ;








        }




        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool sifreGizli = true;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreGizli)
            {
                textBox2.UseSystemPasswordChar = false; //Şifreyi görünür yap.
                checkBox1.Text = "Şifreyi Gizle";
            }
            else
            {
                textBox2.UseSystemPasswordChar = true; //Şifreyi gizle.
                checkBox1.Text = "Şifreyi Göster";

            }
            sifreGizli = !sifreGizli; // Değişkeni tersine çevirmek için.







        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            textBox1.Focus();
            textBox1.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            KayitOl frm = new KayitOl();
            frm.Show();
        }

       

        

        
        
    }
}
