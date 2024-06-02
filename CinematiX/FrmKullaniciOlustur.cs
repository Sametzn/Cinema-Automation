using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinematiX
{
    public partial class FrmKullaniciOlustur : Form
    {
        public FrmKullaniciOlustur()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FrmKullaniciOlustur_KeyDown);
            txtKullaniciAdi.KeyDown += new KeyEventHandler(TxtFields_KeyDown);
            txtSifre.KeyDown += new KeyEventHandler(TxtFields_KeyDown);
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayitOl_Click_1(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                string sorgu = "INSERT INTO Tbl_Kullanicilar (KullaniciAdi, KullaniciSifre, AdSoyad) VALUES (@kadi, @ksifre, @adsoyad)";
                connection.Open();
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text.ToLower());
                komut.Parameters.AddWithValue("@ksifre", txtSifre.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);

                int sonuc = komut.ExecuteNonQuery();
                connection.Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Kayıt başarılı");
                    this.Close();
                    FrmAcilis frm = new FrmAcilis();
                    frm.Show(); //showdialog
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız");
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli yerleri doldurun");
            }
        }

        private void TxtFields_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKayitOl_Click_1(sender, e);
            }
        }

        private void FrmKullaniciOlustur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKayitOl_Click_1(sender, e);
            }
        }
    }
}
