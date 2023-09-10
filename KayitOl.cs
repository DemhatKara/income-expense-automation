using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Otomasyon
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=YUKSEL\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True"); //Veri Tabanı Bağlantısı
        private bool sifreGizli;

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Kullanici_login(kullanici_adi,sifre) values (@kul,@sifre)";
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@kul", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı!");
            textBox1.Clear();
            textBox2.Clear();
            baglanti.Close();
            
            try
            {
                baglanti.Open();
            }
            catch (Exception ex)  
            {
            MessageBox.Show("Bağlantı açma hatası" + ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreGizli)
            {
                textBox2.PasswordChar = '\0'; // Şifreyi görünür yap
                checkBox1.Text = "Şifreyi Gizle";
            }
            else
            {
                textBox2.PasswordChar = '*'; // Şifreyi gizle
                checkBox1.Text = "Şifreyi Göster";
            }
            sifreGizli = !sifreGizli; // Değişkeni tersine çevirmek için.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            textBox1.Focus();
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
        }
    }
}
