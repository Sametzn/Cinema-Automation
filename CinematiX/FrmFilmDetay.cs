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
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();
        }
        public string idNo = "";
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");
        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "select *from Tbl_Filmler Where ID=@p1";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", idNo);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                pResim.ImageLocation = oku["AFIS"].ToString();
                lblFilmAdi.Text = oku["ADI"].ToString();
                lblBicim.Text = oku["BICIMI"].ToString();
                lblYonetmen.Text = oku["YONETMEN"].ToString();
                lblOyuncular.Text = oku["OYUNCU"].ToString();
                lblTur.Text = oku["TURU"].ToString();
                lblOzellik.Text = oku["OZELLIKLERI"].ToString();
                lblPuan.Text = oku["PUAN"].ToString();
                lblVizyon.Text = oku["TARIH"].ToString();
                lblDurum.Text = oku["DURUM"].ToString();
                lblDetay.Text = oku["DETAY"].ToString();
            }
            connection.Close();
            if (lblDurum.Text == "0")
            {
                lblDurum.Text = "FİLM VİZYONDA";
            }
            else {
                lblDurum.Text = "FİLM VİZYONA GİRMEDİ !";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
