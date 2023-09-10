using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otomasyon
{
    public partial class Form1 : Form
    {
        private string where;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_Update();
            combo_doldur();
        }
        void combo_doldur()
        { 
            cmb_gider_tipi.DataSource = glb.sql.Table("select gdr_Gider_Kod , gdr_Gider_Ad from GIDER_TIPLERI ");
            cmb_gider_tipi.DisplayMember = "gdr_Gider_Ad";
            cmb_gider_tipi.ValueMember = "gdr_Gider_Kod";
        }
        string tip()
        {
            string tip = "";
            if (rad_gelir.Checked == true)
            {
                tip = "Gelir";
            }
            if (rad_gider.Checked == true)
            {
                tip = "Gider";
            }
            return tip;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            if (tip() == "")
            {
                MessageBox.Show("İşlem Tipi seçmediğiniz için işleminizi gerçekleştiremiyoruz! ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                if (Convert.ToInt32(cal_recno.Text) == 0)
                {



                    glb.sql.Command(""
                             + "    INSERT INTO[dbo].[GELIR_GIDER_KAYITLARI]     "
                             + "           ([ggr_tarih]                          "
                             + "           ,[ggr_tipi]                           "
                             + "           ,[ggr_gider_tipi]                     "
                             + "           ,[ggr_cari]                           "
                             + "           ,[ggr_tutar]                          "
                             + "           ,[ggr_aciklama]                       "
                             + "           ,[ggr_kayit_tarih])                   "
                             + "     VALUES                                      "
                             + "           ('" + Convert.ToDateTime(dat_tarih.Value).ToString("yyyyMMdd HH:mm") + "'   " //< ggr_tarih, datetime,>              "
                             + "           ,'" + tip() + "'   " //< ggr_tipi, nvarchar(50),>           "
                             + "           ,'" + cmb_gider_tipi.SelectedValue.ToString() + "'   " //< ggr_gider_tipi, nvarchar(50),>     "
                             + "           ,'" + txt_cari.Text + "'   " //< ggr_cari, nvarchar(500),>          "
                             + "           , " + Convert.ToDouble(cal_tutar.Text).ToString().Replace(",", ".") + "   " //< ggr_tutar, float,>                 "
                             + "           ,'" + txt_Aciklama.Text + "'   " //< ggr_aciklama, nvarchar(max),>      "
                             + "           , getdate()  " //< ggr_kayit_tarih, datetime,> "
                             + " )       "
                             );
                    dgv_Update();
                }
                else
                {
                    glb.sql.Command(""
                            + "    update [dbo].[GELIR_GIDER_KAYITLARI]   set  "
                            + "            [ggr_tarih]        = '" + Convert.ToDateTime(dat_tarih.Value).ToString("yyyyMMdd HH:mm") + "'   " //< ggr_tarih, datetime,>              "                  "
                            + "           ,[ggr_tipi]         = '" + tip() + "'   " //< ggr_tipi, nvarchar(50),>           "                  "
                            + "           ,[ggr_gider_tipi]   = '" + cmb_gider_tipi.SelectedValue.ToString() + "'   " //< ggr_gider_tipi, nvarchar(50),>     "                  "
                            + "           ,[ggr_cari]         = '" + txt_cari.Text + "'   " //< ggr_cari, nvarchar(500),>          "                  "
                            + "           ,[ggr_tutar]        = '" + Convert.ToDouble(cal_tutar.Text).ToString().Replace(",", ".") + "'   " //< ggr_tutar, float,>                 "                  "
                            + "           ,[ggr_aciklama]     = '" + txt_Aciklama.Text + "'   " //< ggr_aciklama, nvarchar(max),>      "                  "
                            + "     where     ggr_RECno = " + Convert.ToInt32(cal_recno.Text) + "                                  "
                            );
                    dgv_Update();
                }
            }
        }
       private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                cal_recno.Text = row.Cells["KAYITNO"].Value.ToString();
                cal_tutar.Text = row.Cells["Tutar"].Value.ToString();
                txt_Aciklama.Text = row.Cells["Açıklama"].Value.ToString();
                txt_cari.Text = row.Cells["Cari"].Value.ToString();
                string gelir_gider = row.Cells["Tipi"].Value.ToString();

                switch (gelir_gider)
                {
                    case "Gelir":
                        rad_gelir.Checked = true;
                        break;
                    case "Gider":
                        rad_gider.Checked = true;
                        break;
                    default:
                        rad_gider.Checked = false;
                        rad_gelir.Checked = false;
                        break;

                }
                dat_tarih.Text = row.Cells["Tarih"].Value.ToString();
                cmb_gider_tipi.SelectedValue = row.Cells["Gider Tip Kod"].Value.ToString();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu " + tip() + " kaydını silmek istediğinzden emin misiniz?", "Onay Verin!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                glb.sql.Command("delete from  [dbo].[GELIR_GIDER_KAYITLARI]    where     ggr_RECno = " + Convert.ToInt32(cal_recno.Text) + "     ");
                dgv_Update();
            }
        }
        void dgv_Update()
        {
            dataGridView1.DataSource = glb.sql.Table("select * from dbo.fn_GelirGiderListesi(0) " + whereClause);
        }

        string whereClause = " ";

        private void rad_f_hepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_f_gelir.Checked == true)
            {
                whereClause = " where Tipi = 'Gelir'  ";
            }
            if (rad_f_gider.Checked == true)
            {
                whereClause = " where Tipi = 'Gider'  ";
            }
            if (rad_f_hepsi.Checked == true)
            {
                whereClause = "   ";
            }
            dgv_Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            combo_doldur();

        }

        private void btn_tip_ekle_Click(object sender, EventArgs e)
        {
            new GiderTipi_Ekle() { }.ShowDialog();
            combo_doldur();
        }

        private void cmb_gider_tipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btn_kapat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
