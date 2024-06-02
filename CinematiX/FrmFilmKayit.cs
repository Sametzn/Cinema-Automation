using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CinematiX
{

    public partial class FrmFilmKayit : Form
    {

        public FrmFilmKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            verileriSil();

        }
        void verileriSil()
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler ", connection);
            komut.ExecuteNonQuery();
            connection.Close();
        }
        public string resimyolu = "";
        private void FrmFilmKayit_Load(object sender, EventArgs e)
        {
            YListesigetir();
            OListesigetir();
            bugununTarihi();
            txtFilmAdi.Focus();

        }
        void bugununTarihi()
        {
            ngun.Value = DateTime.Today.Day;
            nay.Value = DateTime.Today.Month;
            nyil.Value = DateTime.Today.Year;
        }

        public void YListesigetir()
        {
            fYonetmenPaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY AdSoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                yListeAraci arac = new yListeAraci();
                arac.lblAdi.Text = oku["AdSoyad"].ToString();
                fYonetmenPaneli.Controls.Add(arac);
            }
            connection.Close();

        }
        public void OListesigetir()
        {
            fOyuncuPaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Oyuncular ORDER BY AdSoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListeAraci arac = new oListeAraci();
                arac.lblAdi.Text = oku["AdSoyad"].ToString();
                fOyuncuPaneli.Controls.Add(arac);
            }
            connection.Close();

        }
        private void btnresimyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG - JPEG | *.jpg;*.jpeg | ALL Files | *.*";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pResim.Image = new Bitmap(ofd.FileName);
                resimyolu = ofd.FileName.ToString();
            }
        }

        private void txtdetay_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = txtdetay.Text.Length;
            int gerisayim = 300 - karakterSayisi;
            lblkaraktr.Text = gerisayim.ToString();
            if (gerisayim > 20)
            {

                lblkaraktr.ForeColor = Color.FromArgb(00, 80, 00);
            }

            if (gerisayim < 100)
            {
                lblkaraktr.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void txtOyuncuAra_TextChanged(object sender, EventArgs e)
        {
            OyuncuAra();
        }
        void OyuncuAra()
        {
            fOyuncuPaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Oyuncular WHERE AdSoyad LIKE '%" + txtOyuncuAra.Text + "%' collate Turkish_CI_AS ORDER BY AdSoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListeAraci arac = new oListeAraci();
                arac.lblAdi.Text = oku["AdSoyad"].ToString();
                fOyuncuPaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void txtYonetmenAra_TextChanged(object sender, EventArgs e)
        {
            YonetmenAra();
        }
        void YonetmenAra()
        {
            fYonetmenPaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Yonetmenler WHERE AdSoyad LIKE '%" + txtYonetmenAra.Text + "%' collate Turkish_CI_AS ORDER BY AdSoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListeAraci arac = new yListeAraci();
                arac.lblAdi.Text = oku["AdSoyad"].ToString();
                fYonetmenPaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            if (lblAksiyon.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblAksiyon.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblAksiyon.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }

        private void lblKorku_Click(object sender, EventArgs e)
        {
            if (lblKorku.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblKorku.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblKorku.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }
        private void lblDram_Click(object sender, EventArgs e)
        {
            if (lblDram.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblDram.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblDram.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }

        private void lblBilimkurgu_Click(object sender, EventArgs e)
        {
            if (lblBilimkurgu.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblBilimkurgu.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblBilimkurgu.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }

        private void lblRomantik_Click(object sender, EventArgs e)
        {
            if (lblRomantik.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblRomantik.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblRomantik.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }
        private void lblGerilim_Click(object sender, EventArgs e)
        {
            if (lblGerilim.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblGerilim.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblGerilim.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }
        private void lblMacera_Click(object sender, EventArgs e)
        {
            if (lblMacera.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblMacera.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblMacera.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }

        private void lblKomedi_Click(object sender, EventArgs e)
        {
            if (lblKomedi.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblKomedi.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblKomedi.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }
        private void lblTurkce_Click(object sender, EventArgs e)
        {
            if (lblTurkce.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblTurkce.ForeColor = Color.FromArgb(178, 34, 34);
            }
            else
            {
                lblTurkce.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }
        private void lblingilizce_Click(object sender, EventArgs e)
        {
            if (lblingilizce.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblingilizce.ForeColor = Color.FromArgb(178, 34, 34);
            }
            else
            {
                lblingilizce.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }
        private void lblAltyazi_Click(object sender, EventArgs e)
        {
            if (lblAltyazi.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblAltyazi.ForeColor = Color.FromArgb(178, 34, 34);
            }
            else
            {
                lblAltyazi.ForeColor = Color.FromArgb(17, 28, 43);
            }
        }
        private void lblkorkusiddet_Click(object sender, EventArgs e)
        {
            if (lblkorkusiddet.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblkorkusiddet.ForeColor = Color.FromArgb(0, 255, 0);
                pb1.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\597356.png";
            }
            else
            {
                lblkorkusiddet.ForeColor = Color.FromArgb(17, 28, 43);
                pb1.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\3064155.png";
            }
        }

        private void lblOlumsuz_Click(object sender, EventArgs e)
        {
            if (lblOlumsuz.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblOlumsuz.ForeColor = Color.FromArgb(0, 255, 0);
                pb2.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\597356.png";
            }
            else
            {
                lblOlumsuz.ForeColor = Color.FromArgb(17, 28, 43);
                pb2.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\3064155.png";
            }
        }
        private void lblGenel_Click(object sender, EventArgs e)
        {
            if (lblGenel.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblGenel.ForeColor = Color.FromArgb(0, 255, 0);
                pb3.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\597356.png";
            }
            else
            {
                lblGenel.ForeColor = Color.FromArgb(17, 28, 43);
                pb3.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\3064155.png";
            }
        }
        private void lblYedi_Click(object sender, EventArgs e)
        {
            if (lblYedi.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblYedi.ForeColor = Color.FromArgb(0, 255, 0);
                pb4.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\597356.png";
            }
            else
            {
                lblYedi.ForeColor = Color.FromArgb(17, 28, 43);
                pb4.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\3064155.png";
            }
        }
        private void lblOnuc_Click(object sender, EventArgs e)
        {
            if (lblOnuc.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblOnuc.ForeColor = Color.FromArgb(0, 255, 0);
                pb5.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\597356.png";
            }
            else
            {
                lblOnuc.ForeColor = Color.FromArgb(17, 28, 43);
                pb5.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\3064155.png";
            }
        }

        private void lblonsekiz_Click(object sender, EventArgs e)
        {
            if (lblonsekiz.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblonsekiz.ForeColor = Color.FromArgb(0, 255, 0);
                pb6.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\597356.png";
            }
            else
            {
                lblonsekiz.ForeColor = Color.FromArgb(17, 28, 43);
                pb6.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\3064155.png";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            vizyonTarihiHesapla();
        }
        string vTarih = "";
        string durum = "0";
        void vizyonTarihiHesapla()
        {
            vTarih = ngun.Value + "-" + nay.Value + "-" + nyil.Value;
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime bugununtarihi = DateTime.Today;

            TimeSpan tSpan = dVTarih - bugununtarihi;

            if (tSpan.TotalDays < 0)
            {
                MessageBox.Show("Geçmiş Tarihe Ait Film Eklemesi Yapılamaz");
                bugununTarihi();
            }
            else if (tSpan.TotalDays == 0)
            {
                durum = "1";
                MessageBox.Show(txtFilmAdi.Text.ToUpper() + " " + "Film Bugün Vizyonda");

            }
            else
            {
                durum = "0";
                MessageBox.Show(txtFilmAdi.Text.ToUpper() + " " + tSpan.TotalDays.ToString() + " " + "Gün Sonra Vizyona Girecek");

            }
        }
        string yonetmen = "";
        string oyuncu = "";
        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "select * from Tbl_Secilenler Where TUR='YONETMEN'";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                yonetmen += " ," + oku["KISI"].ToString();
            }
            connection.Close();

        }
        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "select * from Tbl_Secilenler Where TUR='OYUNCU'";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                oyuncu += " ," + oku["KISI"].ToString();
            }
            connection.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if (txtFilmAdi.Text != "" && txtdetay.Text != "" && vTarih != "" && resimyolu != "")
            {
                secilenOyuncu();
                secilenYonetmen();
                tur();
                Bicim();
                Ozellik();

                string sorgu = "insert into Tbl_Filmler (ADI,TURU,OZELLIKLERI,BICIMI,YONETMEN,OYUNCU,DETAY,PUAN,AFIS,TARIH,DURUM) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
                connection.Open();
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@p1", txtFilmAdi.Text.ToUpper());
                if (secilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur.Substring(1));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur);
                }
                if (secilenOzellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik.Substring(1));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik);
                }
                if (secilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim.Substring(1));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim);
                }
                if (yonetmen.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen);
                }
                if (oyuncu.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu);
                }
                komut.Parameters.AddWithValue("@p7", txtdetay.Text.ToUpper());
                komut.Parameters.AddWithValue("@p8", cbRating.Text);
                komut.Parameters.AddWithValue("@p9", resimyolu);
                komut.Parameters.AddWithValue("@p10", vTarih);
                komut.Parameters.AddWithValue("@p11", durum);
                komut.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("FİLM KAYDI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ");
                temizlemeMethodu();

            }
            else
            {
                MessageBox.Show("LÜTFEN BÜTÜN ALANLARI DOLDURUN");
            }
            void temizlemeMethodu()
            {
                txtFilmAdi.Focus();
                this.Controls.Clear();
                this.InitializeComponent();
                verileriSil();
                YListesigetir();
                OListesigetir();
                bugununTarihi();
            }

        }
        string secilenTur = "";
        string secilenOzellik = "";
        string secilenBicim = "";
        public void tur()
        {
            foreach (Control arac in grbTur.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(17, 28, 43))
                    {

                    }
                    else
                    {
                        secilenTur += " " + arac.Text.ToString();
                    }
                }
            }
        }
        public void Ozellik()
        {
            foreach (Control arac in grbOzellikler.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(17, 28, 43))
                    {

                    }
                    else
                    {
                        secilenOzellik += " " + arac.Text.ToString();
                    }
                }
            }
        }
        public void Bicim()
        {
            foreach (Control arac in grbBicim.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(17, 28, 43))
                    {

                    }
                    else
                    {
                        secilenBicim += " " + arac.Text.ToString();
                    }
                }
            }
        }


    }
}
