using System.Data;
using System.Data.SqlClient;
namespace CinematiX
{
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(FrmAcilis_KeyDown);
            txtKullaniciAdi.KeyDown += new KeyEventHandler(TxtFields_KeyDown);
            txtSifre.KeyDown += new KeyEventHandler(TxtFields_KeyDown);
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
            sorgula.Parameters.AddWithValue("@username", txtKullaniciAdi.Text);
            sorgula.Parameters.AddWithValue("@password", txtSifre.Text);
            SqlDataReader oku = sorgula.ExecuteReader();
            if (oku.Read())
            {
                //MessageBox.Show("Giris Basar�l�");
                FrmAna frm = new FrmAna();
                frm.kisiAdiSoyadi = oku["AdSoyad"].ToString();
                frm.Show(); //showdialog
                this.Hide();
            }
            else
            {
                MessageBox.Show("B�yle bir kullan�c� bulunamad�");
            }
            connection.Close();

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtKullaniciAdi.Focus();
            //imleci konumland�rma
            //connection.Open();
            //if(connection.State==ConnectionState.Open) {
            //    MessageBox.Show("Giris Basar�l�");
            //}
            //connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmKullaniciOlustur frm = new FrmKullaniciOlustur();
            frm.ShowDialog();
        }

        private void FrmAcilis_KeyDown(object sender, KeyEventArgs e)
        {
            btnGirisyap_Click(sender, e);
        }
        private void TxtFields_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGirisyap_Click(sender, e);
            }
        }
    }
}
