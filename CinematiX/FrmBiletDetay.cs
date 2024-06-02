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
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
        public string biletNo = "";
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            lblBiletNo2.Text = biletNo;
            BarkodNoOlustur();
            bilgiGetir();
        }
        void BarkodNoOlustur()
        {
            Random random = new Random();
            string karakterler = "01234567894564891561489465121981870";
            string kod = "";

            for (int i = 0; i < 10; i++)
            {
                kod += karakterler[random.Next(karakterler.Length)];
            }
            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();
        }
        void bilgiGetir()
        {
            string sorgu = "select * from  Tbl_Biletler where BKod=@kod";
            connection.Open();

            SqlCommand getir = new SqlCommand(sorgu, connection);
            getir.Parameters.AddWithValue("@kod", biletNo);
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                lbLFilmAdi.Text = oku["FilmAdi"].ToString();
                lblFilmAdi1.Text = oku["FilmAdi"].ToString();
                lblTelNo.Text = oku["TelNo"].ToString();
                lblAdSoyad.Text = oku["AdSoyad"].ToString();
                lblTur2.Text = oku["Tur"].ToString();
                lblSalonAdi.Text = oku["Salon"].ToString();
                lblSeans2.Text = oku["Salon"].ToString()+ " " + oku["Saat"].ToString();
                lblTarih2.Text = oku["Tarih"].ToString();
                lblIslemTarihi.Text = oku["IslemSaati"].ToString();
                lblTarihSaat.Text = oku["Tarih"].ToString() + " " + oku["Saat"].ToString();

            }
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
