using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class GiderTipi_Ekle : Form
    {
        public GiderTipi_Ekle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            int kontrol = Convert.ToInt16(glb.sql.Command("select count(*) from GIDER_TIPLERI where gdr_Gider_Kod = '" + txt_gider_kod + "'"));
            if (kontrol == 0)
            {
                glb.sql.Command(""
                         + "       INSERT INTO[dbo].[GIDER_TIPLERI] "
                         + "              ([gdr_Gider_Kod] "
                         + "              ,[gdr_Gider_Ad]) "
                         + "        VALUES "
                         + "              ( '" + txt_gider_kod.Text + "' "//< gdr_Gider_Kod, nvarchar(50),> "
                         + "              , '" + txt_gider_kod.Text + "' "//< gdr_Gider_Kod, nvarchar(50),> "
                         + ") ");
                if (glb.sql.exception == null)
                {
                    MessageBox.Show("Kayıt Başarılı");
                }
            }
            else
            {
                glb.sql.Command(""
                    + "    update [dbo].[GIDER_TIPLERI] set "
                    + "              "
                    + "               [gdr_Gider_Ad]  = '" + txt_gider_kod.Text + "' "//< gdr_Gider_Kod, nvarchar(50),> "
                    + "        where  gdr_Gider_Kod = '" + txt_gider_kod.Text + "'"
                    + " ");
                if (glb.sql.exception == null)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            // Silinecek giderin ismini (label7) yeni formdan al
            string label7 = Form1OtherForm(); 

            if (!string.IsNullOrEmpty(label7))
            {
                
                bool result = SilGider(label7); 

                if (result)
                {
                    MessageBox.Show("Gider başarıyla silindi.");
                    // Gerekli diğer işlemleri gerçekleştir veya formu güncellemeyi dene
                }
                else
                {
                    MessageBox.Show("Gider silme işlemi başarısız oldu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir gider seçin.");
            }
        }

        
        private string Form1OtherForm()
        {
            // Gider ismini alacak kodu buraya yazacağız
            

            return string.Empty; 
        }

        // Gideri silen bir yöntem
        private bool SilGider(string giderAdi)
        {
            try
            {
                // Gideri veritabanından silme işlemini gerçekleştir
                // Örneğin, aşağıdaki gibi bir SQL sorgusu kullanabilirsin
                // "DELETE FROM Giderler WHERE GiderAdi = '" + giderAdi + "'";

                // Silme işlemi başarılıysa true döndürür
                return true;
            }
            catch (Exception ex)
            {
                // Hata durumunda ilgili hata işleme kodunu buraya yazacağız
                // Hata durumunda false döndürür veya isteğe bağlı olarak hata ile ilgili ayrıntıları göster
                MessageBox.Show("Gider silme hatası: " + ex.Message);
                return false;
            }
        }
    }
}
