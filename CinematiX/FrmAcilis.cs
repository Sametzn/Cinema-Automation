using System.Data;
using System.Data.SqlClient;
namespace CinematiX
{
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisyap_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sorgula = new SqlCommand("select * from Tbl_Kullanicilar WHERE KullaniciAdi=@username AND KullaniciSifre=@password", connection);
            sorgula.Parameters.AddWithValue("@username",txtKullaniciAdi.Text);
            sorgula.Parameters.AddWithValue("@password",txtSifre.Text);
            SqlDataReader oku = sorgula.ExecuteReader();
            if(oku.Read())
            {
                //MessageBox.Show("Giris Basarýlý");
                FrmAna frm = new FrmAna();
                frm.kisiAdiSoyadi = oku["AdSoyad"].ToString();
                frm.Show(); //showdialog
                this.Hide();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanýcý bulunamadý");
            }
            connection.Close();

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtKullaniciAdi.Focus();
            //connection.Open();
            //if(connection.State==ConnectionState.Open) {
            //    MessageBox.Show("Giris Basarýlý");
            //}
            //connection.Close();
        }
    }
}
