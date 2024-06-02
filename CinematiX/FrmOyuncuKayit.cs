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

namespace CinematiX
{
    public partial class FrmOyuncuKayit : Form
    {

        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string resimyolu = "";
        private void btnresimyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seçme Ekranı";
            ofd.Filter = "PNG | *.png |JPG-JPEG |*.jpg;*.jpeg | ALL Files | *.*";
            ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pResim.Image = new Bitmap(ofd.FileName);
                resimyolu = ofd.FileName.ToString();
            }
        }
        public string cinsiyet = "0";
        private void rErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void rKadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }

        public string byas = "00";
        void yasHesaplama()
        {
            string dogum = ngun.Value.ToString() + "-" + nay.Value.ToString() + "-" + nyil.Value.ToString();

            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;

            if (yas < 0)
            {
                MessageBox.Show("Yaşınız Negatif Olamaz");
            }
            else if (yas < 18)
            {
                MessageBox.Show("Yaşınız 18 den küçük olamaz");

            }
            else
            {
                byas = yas.ToString();
            }

        }
        private void txtbiyografi_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = txtbiyografi.Text.Length;
            int gerisayim = 300 - karakterSayisi;
            lblkarakter.Text = gerisayim.ToString();
            if (gerisayim > 20)
            {

                lblkarakter.ForeColor = Color.FromArgb(00, 80, 00);
            }

            if (gerisayim < 100)
            {
                lblkarakter.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            yasHesaplama();
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtbiyografi.Text != "" && resimyolu != "")
            {
                if (Convert.ToInt32(byas) >= 18) // Yaş kontrolü
                {
                    //toupper küçük harfleri büyük harfe çeviriyor
                    string adSoyad = txtAd.Text.ToString().ToUpper() + " " + txtSoyad.Text.ToString().ToUpper();
                    connection.Open();
                    SqlCommand kayit = new SqlCommand("insert into Tbl_Oyuncular (AdSoyad, Cinsiyet, Yas, Biyografi, Resim) VALUES (@adsoyad, @cinsiyet,@yas, @biyografi, @resim)", connection);
                    kayit.Parameters.AddWithValue("@adsoyad", adSoyad);
                    kayit.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    kayit.Parameters.AddWithValue("@yas", byas);
                    kayit.Parameters.AddWithValue("@biyografi", txtbiyografi.Text.ToString().ToUpper());
                    kayit.Parameters.AddWithValue("@resim", resimyolu);
                    kayit.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("OYUNCU KAYIT İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ");
                    aractemizle();
                }
            }

            else
            {
                MessageBox.Show("Boş olanlar alanları doldurup tekrar deneyiniz");

            }
        }
        void aractemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtbiyografi.Text = "";
            ngun.Value = 1;
            nay.Value = 1;
            nyil.Value = 2024;
            rKadin.Checked = false;
            rErkek.Checked = true;
            lblkarakter.Text = "300";
            cinsiyet = "0";
            byas = "0";
            pResim.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\photo-camera.png";
            txtAd.Focus();
        }

      
    }
}
