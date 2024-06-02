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
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnresimyukle_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && cbkoltuksayisi.Text != "")
            {
                connection.Open();
                SqlCommand kaydet = new SqlCommand("insert into Tbl_Salonlar (SalonAdi, KoltukSayisi) Values (@p1,@p2) ", connection);
                kaydet.Parameters.AddWithValue("@p1", txtSalonAdi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cbkoltuksayisi.Text);
                kaydet.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("KAYDETME İSLEMİ BAŞARIYLA GERÇEKLEŞTİRİLDİ");
                txtSalonAdi.Text = "";
                cbkoltuksayisi.Text = "";
                txtSalonAdi.Focus();
                Listegetir();
               
            }
            else
            {
                MessageBox.Show("Lütfen bir değer giriniz.");
            }
        }



        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            kOlustur();
            Listegetir();
        }
        void kOlustur()
        {
            for (int i = 1;i<=200;i++)
            {
                cbkoltuksayisi.Items.Add(i);
            }
        }
        void Listegetir()
        {
            panelSalon.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Salonlar ORDER BY SalonAdi ASC ", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                SalonListesi arac = new SalonListesi();
                arac.lblSalonAdi.Text = oku["SalonAdi"].ToString();
                arac.lblKoltukSayisi.Text = oku["Koltuksayisi"].ToString();
                panelSalon.Controls.Add(arac);

            }
            connection.Close();
        }

        private void cbkoltuksayisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
