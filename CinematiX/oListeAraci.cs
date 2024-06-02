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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CinematiX
{
    public partial class oListeAraci : UserControl
    {
        public oListeAraci()
        {
            InitializeComponent();
        }
        private void lblAdi_MouseLeave(object sender, EventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 14, FontStyle.Regular);
        }
        private void lblAdi_MouseMove(object sender, MouseEventArgs e)
        {
            lblAdi.Font = new Font(lblAdi.Font.Name, 14, FontStyle.Underline);
        }
        private void lblAdi_Click(object sender, EventArgs e)
        {
            if (lblAdi.ForeColor == Color.FromArgb(17, 28, 43))
            {

                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);
                pictureBox1.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\4210903.png";
                connection.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Secilenler (KISI,TUR) values (@kisi,@tur)", connection);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 28, 43);
                pictureBox1.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\3416075.png";
                connection.Open();
                SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler where KISI=@kisi AND TUR=@tur", connection);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                connection.Close();
            }
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");
        private void oListeAraci_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Secilenler Where KISI=@kisi AND TUR=@tur", connection);
            komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
            komut.Parameters.AddWithValue("@tur", "OYUNCU");
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);
                pictureBox1.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\4210903.png";
            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 28, 43);
                pictureBox1.ImageLocation = @"C:\Users\Samet TÜZEN\Desktop\Bu Sene Çalışılıcaklar\3.sınıf 2.dönem\Database Project\3416075.png";
            }
            connection.Close();
        }
    }
}
