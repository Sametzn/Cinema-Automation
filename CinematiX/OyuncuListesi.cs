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
    public partial class OyuncuListesi : UserControl
    {
        public OyuncuListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");
        private void OyuncuListesi_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from Tbl_Oyuncular WHERE ID =@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblCinsiyet.Text = oku["Cinsiyet"].ToString();
            }
            connection.Close();
            if (lblCinsiyet.Text == "1")
            {
                //erkek
                pCinsiyet.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\30380572-3ff1-4c88-81aa-4fcfebd1838c.jpg";
            }
            else
            {
                //kadın
                pCinsiyet.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\depositphotos_286132658-stock-illustration-male-man-symbol-gender-and.jpg";
            }
        }

        private void btnresimyukle_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from Tbl_Oyuncular WHERE ID =@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("BİYOGRAFİ: " + oku["Biyografi"].ToString(), oku["AdSoyad"].ToString());
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_Oyuncular WHERE ID =@p1", connection);
            sil.Parameters.AddWithValue("@p1", lblid.Text);
            sil.ExecuteNonQuery();
            connection.Close();
            this.Hide();
            MessageBox.Show("Kayıt Başarılı bir şekilde silindi");
        }
    }
}

