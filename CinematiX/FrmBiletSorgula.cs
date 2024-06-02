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
    public partial class FrmBiletSorgula : Form
    {
        public FrmBiletSorgula()
        {
            InitializeComponent();


        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H0JREM9\\SQLEXPRESS;Initial Catalog=CinematiXDB; Integrated Security=True");

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (txtBiletNo.Text != "")
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("select * from Tbl_Biletler WHERE BKod=@p1", connection);
                komut.Parameters.AddWithValue("@p1", txtBiletNo.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {

                    FrmBiletDetay frm = new FrmBiletDetay();
                    frm.biletNo = txtBiletNo.Text.ToString();
                    txtBiletNo.Text = "";
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kayıtlı Bilet Bulunamadı");
                    connection.Close();
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Lutfen Bilet Numarasını Giriniz");
            }

        }


    }
}
