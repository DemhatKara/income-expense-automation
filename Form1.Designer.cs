namespace Otomasyon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_tip_ekle = new System.Windows.Forms.GroupBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.cmb_gider_tipi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cal_recno = new Otomasyon.TextBoxNumbersOnly();
            this.label6 = new System.Windows.Forms.Label();
            this.cal_tutar = new Otomasyon.TextBoxNumbersOnly();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dat_tarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rad_gider = new System.Windows.Forms.RadioButton();
            this.rad_gelir = new System.Windows.Forms.RadioButton();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rad_f_hepsi = new System.Windows.Forms.RadioButton();
            this.rad_f_gider = new System.Windows.Forms.RadioButton();
            this.rad_f_gelir = new System.Windows.Forms.RadioButton();
            this.btn_tip_ekle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_tip_ekle
            // 
            this.btn_tip_ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tip_ekle.Controls.Add(this.Button2);
            this.btn_tip_ekle.Controls.Add(this.cmb_gider_tipi);
            this.btn_tip_ekle.Controls.Add(this.label7);
            this.btn_tip_ekle.Controls.Add(this.cal_recno);
            this.btn_tip_ekle.Controls.Add(this.label6);
            this.btn_tip_ekle.Controls.Add(this.cal_tutar);
            this.btn_tip_ekle.Controls.Add(this.btn_kapat);
            this.btn_tip_ekle.Controls.Add(this.btn_kaydet);
            this.btn_tip_ekle.Controls.Add(this.btn_sil);
            this.btn_tip_ekle.Controls.Add(this.label5);
            this.btn_tip_ekle.Controls.Add(this.txt_Aciklama);
            this.btn_tip_ekle.Controls.Add(this.label4);
            this.btn_tip_ekle.Controls.Add(this.dat_tarih);
            this.btn_tip_ekle.Controls.Add(this.label3);
            this.btn_tip_ekle.Controls.Add(this.label2);
            this.btn_tip_ekle.Controls.Add(this.rad_gider);
            this.btn_tip_ekle.Controls.Add(this.rad_gelir);
            this.btn_tip_ekle.Controls.Add(this.txt_cari);
            this.btn_tip_ekle.Controls.Add(this.label1);
            this.btn_tip_ekle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_tip_ekle.Location = new System.Drawing.Point(0, 0);
            this.btn_tip_ekle.Name = "btn_tip_ekle";
            this.btn_tip_ekle.Size = new System.Drawing.Size(580, 573);
            this.btn_tip_ekle.TabIndex = 0;
            this.btn_tip_ekle.TabStop = false;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button2.Location = new System.Drawing.Point(471, 164);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(58, 28);
            this.Button2.TabIndex = 19;
            this.Button2.Text = "Ekle";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.btn_tip_ekle_Click);
            // 
            // cmb_gider_tipi
            // 
            this.cmb_gider_tipi.FormattingEnabled = true;
            this.cmb_gider_tipi.Location = new System.Drawing.Point(265, 167);
            this.cmb_gider_tipi.Name = "cmb_gider_tipi";
            this.cmb_gider_tipi.Size = new System.Drawing.Size(200, 24);
            this.cmb_gider_tipi.TabIndex = 18;
            this.cmb_gider_tipi.SelectedIndexChanged += new System.EventHandler(this.cmb_gider_tipi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(127, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Gider İse Tipi";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cal_recno
            // 
            this.cal_recno.Location = new System.Drawing.Point(265, 49);
            this.cal_recno.Name = "cal_recno";
            this.cal_recno.NumbersOnly = true;
            this.cal_recno.Size = new System.Drawing.Size(152, 22);
            this.cal_recno.TabIndex = 16;
            this.cal_recno.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(127, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "RECno";
            // 
            // cal_tutar
            // 
            this.cal_tutar.Location = new System.Drawing.Point(265, 248);
            this.cal_tutar.Name = "cal_tutar";
            this.cal_tutar.NumbersOnly = true;
            this.cal_tutar.Size = new System.Drawing.Size(152, 22);
            this.cal_tutar.TabIndex = 14;
            this.cal_tutar.Text = "0";
            // 
            // btn_kapat
            // 
            this.btn_kapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.Location = new System.Drawing.Point(3, 505);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(574, 65);
            this.btn_kapat.TabIndex = 13;
            this.btn_kapat.Text = "Programı Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click_1);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(356, 375);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(108, 89);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(176, 375);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(108, 89);
            this.btn_sil.TabIndex = 11;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(127, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(265, 288);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(152, 81);
            this.txt_Aciklama.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(127, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarih";
            // 
            // dat_tarih
            // 
            this.dat_tarih.Location = new System.Drawing.Point(265, 121);
            this.dat_tarih.Name = "dat_tarih";
            this.dat_tarih.Size = new System.Drawing.Size(200, 22);
            this.dat_tarih.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(127, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tutar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(126, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cari";
            // 
            // rad_gider
            // 
            this.rad_gider.AutoSize = true;
            this.rad_gider.Location = new System.Drawing.Point(356, 89);
            this.rad_gider.Name = "rad_gider";
            this.rad_gider.Size = new System.Drawing.Size(61, 20);
            this.rad_gider.TabIndex = 3;
            this.rad_gider.TabStop = true;
            this.rad_gider.Text = "Gider";
            this.rad_gider.UseVisualStyleBackColor = true;
            // 
            // rad_gelir
            // 
            this.rad_gelir.AutoSize = true;
            this.rad_gelir.Location = new System.Drawing.Point(265, 89);
            this.rad_gelir.Name = "rad_gelir";
            this.rad_gelir.Size = new System.Drawing.Size(56, 20);
            this.rad_gelir.TabIndex = 2;
            this.rad_gelir.TabStop = true;
            this.rad_gelir.Text = "Gelir";
            this.rad_gelir.UseVisualStyleBackColor = true;
            // 
            // txt_cari
            // 
            this.txt_cari.Location = new System.Drawing.Point(265, 207);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(152, 22);
            this.txt_cari.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(127, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "işlem Tipi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(580, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 484);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.rad_f_hepsi);
            this.panel1.Controls.Add(this.rad_f_gider);
            this.panel1.Controls.Add(this.rad_f_gelir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(580, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 89);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rad_f_hepsi
            // 
            this.rad_f_hepsi.AutoSize = true;
            this.rad_f_hepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rad_f_hepsi.Location = new System.Drawing.Point(204, 28);
            this.rad_f_hepsi.Name = "rad_f_hepsi";
            this.rad_f_hepsi.Size = new System.Drawing.Size(76, 24);
            this.rad_f_hepsi.TabIndex = 6;
            this.rad_f_hepsi.TabStop = true;
            this.rad_f_hepsi.Text = "Tümü";
            this.rad_f_hepsi.UseVisualStyleBackColor = true;
            this.rad_f_hepsi.CheckedChanged += new System.EventHandler(this.rad_f_hepsi_CheckedChanged);
            // 
            // rad_f_gider
            // 
            this.rad_f_gider.AutoSize = true;
            this.rad_f_gider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rad_f_gider.Location = new System.Drawing.Point(122, 28);
            this.rad_f_gider.Name = "rad_f_gider";
            this.rad_f_gider.Size = new System.Drawing.Size(76, 24);
            this.rad_f_gider.TabIndex = 5;
            this.rad_f_gider.TabStop = true;
            this.rad_f_gider.Text = "Gider";
            this.rad_f_gider.UseVisualStyleBackColor = true;
            this.rad_f_gider.CheckedChanged += new System.EventHandler(this.rad_f_hepsi_CheckedChanged);
            // 
            // rad_f_gelir
            // 
            this.rad_f_gelir.AutoSize = true;
            this.rad_f_gelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rad_f_gelir.Location = new System.Drawing.Point(30, 28);
            this.rad_f_gelir.Name = "rad_f_gelir";
            this.rad_f_gelir.Size = new System.Drawing.Size(71, 24);
            this.rad_f_gelir.TabIndex = 4;
            this.rad_f_gelir.TabStop = true;
            this.rad_f_gelir.Text = "Gelir";
            this.rad_f_gelir.UseVisualStyleBackColor = true;
            this.rad_f_gelir.CheckedChanged += new System.EventHandler(this.rad_f_hepsi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 573);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_tip_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btn_tip_ekle.ResumeLayout(false);
            this.btn_tip_ekle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btn_tip_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rad_gelir;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dat_tarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rad_gider;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private TextBoxNumbersOnly cal_tutar;
        private TextBoxNumbersOnly cal_recno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_gider_tipi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rad_f_hepsi;
        private System.Windows.Forms.RadioButton rad_f_gider;
        private System.Windows.Forms.RadioButton rad_f_gelir;
        private System.Windows.Forms.Button Button2;
    }
}

