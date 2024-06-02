using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinematiX
{
    public partial class FrmSalonAtama : Form
    {
        public FrmSalonAtama()
        {
            InitializeComponent();

        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalonAtama_Load(object sender, EventArgs e)
        {
            bugununTarihi();
            FilmAdiGetir();
            SalonAdiGetir();
        }
        void bugununTarihi()
        {
            ngun.Value = DateTime.Today.Day;
            nay.Value = DateTime.Today.Month;
            nyil.Value = DateTime.Today.Year;
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
        void SalonAdiGetir()
        {
            string sorgu = "select* from Tbl_Salonlar ORDER BY SalonAdi ASC";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbSalonAdi.Items.Add(oku["SalonAdi"].ToString());
            }
            connection.Close();

        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if (btnBiletAl.Text == "TAMAMLA")
            {
                btnBiletAl.Text = "OLUSTUR";
                btnBiletAl.BackColor = Color.FromArgb(255, 255, 128);
                string sorgu = "select DISTINCT Saat from Tbl_Kontrol WHERE Tarih=@tarih AND SalonAdi=@salonadi";
                string tarih = ngun.Value + "-" + nay.Value + "-" + nyil.Value;
                connection.Open();
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@salonadi", cbSalonAdi.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cbDoluSaatler.Items.Add(oku["Saat"].ToString());
                }
                connection.Close();
                seanskontrol();
            }
            else
            {
                Kaydet();
                temizle();
                btnBiletAl.Text = "TAMAMLA";
                btnBiletAl.BackColor = Color.FromArgb(255, 128, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void temizle()
        {
            cbFilmAdi.Items.Clear();
            cbSalonAdi.Items.Clear();
            cbDoluSaatler.Items.Clear();
            lblSecilen.Text = "";
            bugununTarihi();
            FilmAdiGetir();
            SalonAdiGetir();
            PanelSeans.Controls.Clear();
            btnBiletAl.Text = "TAMAMLA";
            btnBiletAl.BackColor = Color.FromArgb(255, 128, 0);
        }
        private void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in PanelSeans.Controls)
            {
                if (item.Checked)
                {
                    lblSecilen.Text = item.Text.ToString();
                }
            }
        }
        void Kaydet()
        {
            string sorgu = "insert into Tbl_Kontrol (FilmAdi,Tarih,Saat,SalonAdi) Values (@filmadi,@tarih,@saat,@salonadi)";
            string tarih = ngun.Value + "-" + nay.Value + "-" + nyil.Value;
            connection.Open();
            SqlCommand ekle = new SqlCommand(sorgu, connection);
            ekle.Parameters.AddWithValue("@filmadi", cbFilmAdi.Text);
            ekle.Parameters.AddWithValue("@tarih", tarih);
            ekle.Parameters.AddWithValue("@saat", lblSecilen.Text);
            ekle.Parameters.AddWithValue("@salonadi", cbSalonAdi.Text);
            ekle.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Salon Atama İşlemi Gerçekleşti");
        }
        void seanskontrol()
        {
            PanelSeans.Controls.Clear();
            for (int i = 10; i <= 22; i++)
            {
                for (int j = 0; j <= 30; j += 30)
                {
                    RadioButton rnd = new RadioButton();
                    rnd.ForeColor = Color.FromArgb(249, 164, 28);
                    rnd.FlatStyle = FlatStyle.Flat;
                    rnd.Font = new System.Drawing.Font("Segoe UI Semibold", 12);
                    rnd.CheckedChanged += new EventHandler(SeansSaatler);
                    if (j == 0)
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString();
                    }
                    if (cbDoluSaatler.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                    }

                    PanelSeans.Controls.Add(rnd);
                }
            }
        }

        
    }
}
