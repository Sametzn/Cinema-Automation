using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CinematiX
{
    public partial class FrmBiletOluştur : Form
    {
        public FrmBiletOluştur()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBiletOluştur_Load(object sender, EventArgs e)
        {
            FilmAdiGetir();
            BiletNoOlustur();
        }
        void BiletNoOlustur()
        {
            Random random = new Random();
            string karakterler = "01234567894564891561489465121981870";
            string kod = "";

            for (int i = 0; i < 10; i++)
            {
                kod += karakterler[random.Next(karakterler.Length)];
            }
            txtBarkod.Text = kod.ToString();
        }
        void FilmAdiGetir()
        {
            string sorgu = "select* from Tbl_Filmler ORDER BY ADI ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string gelentarih = oku["TARIH"].ToString();
                DateTime ftarih = Convert.ToDateTime(gelentarih);
                DateTime bugun = DateTime.Today;
                TimeSpan timespan = ftarih - bugun;
                if (timespan.TotalDays >= 0)
                {
                    cbFilmAdi.Items.Add(oku["ADI"].ToString());
                }
            }
            connection.Close();

        }

        private void cbFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTarih.Items.Clear();
            string sorgu = "select DISTINCT Tarih from Tbl_Kontrol WHERE FilmAdi=@filmadi";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbTarih.Items.Add(oku["Tarih"].ToString());
            }
            connection.Close();
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtBarkod.Text != "" && txtKoltuklar.Text != "" && txtTelNo.Text != "" && cbFilmAdi.Text != "" && cbBiletTürü.Text != "" && cbTarih.Text != "" && cbSalonAdi.Text != "")
            {
                biletNoSorgula();

            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Eksiksiz Doldurun");
            }
        }
        void biletNoSorgula()
        {
            string sorgu = "select * from Tbl_Biletler where BKod=@kod";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@kod", txtBarkod.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {

                kaydet();
            }
            else
            {
                BiletNoOlustur();
                connection.Close();
                biletNoSorgula();
            }
            connection.Close();
        }
        void kaydet()
        {

            string sorgu = "insert into Tbl_Biletler (BKod, AdSoyad, TelNo, KoltukNo, FilmAdi, Tarih, Saat, Salon, Tur, IslemSaati) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            connection.Close();
            connection.Open();
            SqlCommand kayit = new SqlCommand(sorgu, connection);
            kayit.Parameters.AddWithValue("@p1", txtBarkod.Text.ToString());
            kayit.Parameters.AddWithValue("@p2", txtAdSoyad.Text.ToUpper().ToString());
            kayit.Parameters.AddWithValue("@p3", txtTelNo.Text.ToString());
            kayit.Parameters.AddWithValue("@p4", txtKoltuklar.Text.ToString());
            kayit.Parameters.AddWithValue("@p5", cbFilmAdi.Text.ToString());
            kayit.Parameters.AddWithValue("@p6", cbTarih.Text.ToString());
            kayit.Parameters.AddWithValue("@p7", lblSeansSec.Text.ToString());
            kayit.Parameters.AddWithValue("@p8", cbSalonAdi.Text.ToString());
            kayit.Parameters.AddWithValue("@p9", cbBiletTürü.Text.ToString());
            kayit.Parameters.AddWithValue("@p10", DateTime.Now.ToString());
            kayit.ExecuteNonQuery();

            connection.Close();
            string sorgu2 = "UPDATE Tbl_Kontrol SET Koltuklar=@numara Where FilmAdi=@filmadi AND Tarih=@tarih AND Saat=@saat AND SalonAdi=@salonadi";
            connection.Open();
            SqlCommand guncelle = new SqlCommand(sorgu2, connection);
            if (lblGelenKoltuk.Text.ToString() == "")
            {
                guncelle.Parameters.AddWithValue("@numara", txtKoltuklar.Text.ToString());
            }
            else
            {
                guncelle.Parameters.AddWithValue("@numara", lblGelenKoltuk.Text.ToString() + "," + txtKoltuklar.Text.ToString());
            }

            guncelle.Parameters.AddWithValue("@salonadi", cbSalonAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            guncelle.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Bilet Satışı Başarılı");
            temizle();
        }
        void Secilenler()
        {
            txtKoltuklar.Text = "";
            foreach (string item in lbBelirlenen.Items)
            {
                txtKoltuklar.Text += "," + item;
            }
            if (txtKoltuklar.Text.Length > 1)
            {
                txtKoltuklar.Text = txtKoltuklar.Text.Substring(1);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.ForeColor == Color.Red)
            {
                MessageBox.Show("Bu Koltuk Doludur");
            }
            else
            {
                if (btn.ForeColor == Color.Black)
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.secili);
                    btn.ForeColor = Color.Blue;
                    lbBelirlenen.Items.Add(btn.Text);
                    Secilenler();

                }
                else
                {
                    btn.ForeColor = Color.Black;
                    btn.Image = (System.Drawing.Image)(Properties.Resources.bos);
                    lbBelirlenen.Items.Remove(btn.Text);
                    Secilenler();
                }
            }
        }
        private void cbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelSeans.Controls.Clear();
            string saatler = "";
            string sorgu = "select DISTINCT Saat from Tbl_Kontrol WHERE FilmAdi=@filmadi AND Tarih=@tarih";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saatler = oku["Saat"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.Chocolate;
                rnd.FlatStyle = FlatStyle.Flat;
                PanelSeans.Controls.Add(rnd);
                rnd.CheckedChanged += new EventHandler(SeansSaatler);
            }
            connection.Close();
        }
        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in PanelSeans.Controls)
            {
                if (item.Checked)
                {
                    lblSeansSec.Text = item.Text;
                    cbSalonAdi.Items.Clear();

                    string sorgu = "select DISTINCT SalonAdi from Tbl_Kontrol WHERE FilmAdi=@filmadi AND Tarih=@tarih AND Saat=@saat";
                    connection.Open();
                    SqlCommand komut = new SqlCommand(sorgu, connection);
                    komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
                    komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        cbSalonAdi.Items.Add(oku["SalonAdi"].ToString());
                    }
                    connection.Close();
                }
            }
        }

        private void cbSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from Tbl_Salonlar WHERE SalonAdi=@salonadi";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@salonadi", cbSalonAdi.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKoltukSayisi.Text = oku["KoltukSayisi"].ToString();
            }
            connection.Close();
            KoltukGetir();
            DOLDUR();
        }
        void DOLDUR()
        {
            KoltukPaneli.Controls.Clear();
            int sayi = Convert.ToInt16(lblKoltukSayisi.Text);
            for (int i = 1; i <= sayi; i++)
            {

                Button btn = new Button();
                if (i <= 12)
                {
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 24)
                {
                    btn.Text = "B" + (i - 12).ToString();
                    btn.Name = "B" + (i - 12).ToString();
                }
                else if (i <= 36)
                {
                    btn.Text = "C" + (i - 24).ToString();
                    btn.Name = "C" + (i - 24).ToString();
                }
                else if (i <= 48)
                {
                    btn.Text = "D" + (i - 36).ToString();
                    btn.Name = "D" + (i - 36).ToString();
                }
                else if (i <= 60)
                {
                    btn.Text = "E" + (i - 48).ToString();
                    btn.Name = "E" + (i - 48).ToString();
                }
                else if (i <= 72)
                {
                    btn.Text = "F" + (i - 60).ToString();
                    btn.Name = "F" + (i - 60).ToString();
                }
                else if (i <= 84)
                {
                    btn.Text = "G" + (i - 72).ToString();
                    btn.Name = "G" + (i - 72).ToString();
                }
                else if (i <= 96)
                {
                    btn.Text = "H" + (i - 84).ToString();
                    btn.Name = "H" + (i - 84).ToString();
                }
                btn.Width = 50;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12);
                btn.BackColor = Color.Purple;
                btn.BackColor = Color.White;
                btn.Click += Btn_Click;
                if (ListeGelenKoltuk.Items.Contains(btn.Text))
                {

                    btn.Image = (System.Drawing.Image)(Properties.Resources.dolu);
                    btn.ForeColor = Color.Red;
                }
                else
                {

                    btn.Image = (System.Drawing.Image)(Properties.Resources.bos);
                    btn.ForeColor = Color.Black;


                }
                KoltukPaneli.Controls.Add(btn);
            }
        }
        void KoltukGetir()
        {
            lblGelenKoltuk.Text = "";
            string sorgu = "select * from Tbl_Kontrol WHERE FilmAdi=@filmadi AND Tarih=@tarih AND Saat=@saat AND SalonAdi=@salonadi";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            komut.Parameters.AddWithValue("@salonadi", cbSalonAdi.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblGelenKoltuk.Text += " ," + oku["Koltuklar"].ToString();
                if (lblGelenKoltuk.Text.Length > 2)
                {
                    lblGelenKoltuk.Text = lblGelenKoltuk.Text.Substring(2);

                }
                else
                {
                    lblGelenKoltuk.Text = "";
                }
            }

            connection.Close();
            KoltukAyirma();
        }
        void KoltukAyirma()
        {
            ListeGelenKoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblGelenKoltuk.Text.ToString();
            sec = no.Split(',');
            foreach (string bulunan in sec)
            {
                ListeGelenKoltuk.Items.Add(bulunan);
            }
        }
        void temizle()
        {
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            cbTarih.Items.Clear();
            PanelSeans.Controls.Clear();
            cbSalonAdi.Items.Clear();
            cbBiletTürü.Items.Clear();
            txtKoltuklar.Text = "";
            KoltukPaneli.Controls.Clear();
            BiletNoOlustur();
            txtAdSoyad.Focus();
            cbFilmAdi.Items.Clear();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
