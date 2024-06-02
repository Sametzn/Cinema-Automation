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
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Oyuncular ORDER BY AdSoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
                arac.lblAdSoyad.Text = oku["AdSoyad"].ToString();
                arac.lblid.Text = oku["ID"].ToString();
                arac.pResimDetay.ImageLocation = oku["Resim"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }
        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_yonetmenler WHERE AdSoyad LIKE '%" + txtAramaYap.Text + "% ' collate Turkish_CI_AS ORDER BY AdSoyad ASC", connection);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
                arac.lblid.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text = oku["AdSoyad"].ToString();
                arac.pResimDetay.ImageLocation = oku["Resim"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void ListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
