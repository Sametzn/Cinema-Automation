using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinematiX
{
    public partial class SalonListesi : UserControl
    {
        public SalonListesi()
        {
            InitializeComponent();
        }

        private void gel(object sender, MouseEventArgs e)
        {
            lblSalonAdi.ForeColor = Color.OrangeRed;
            this.BackColor = Color.Orange;
        }

        private void git(object sender, EventArgs e)
        {
            lblSalonAdi.ForeColor = SystemColors.GrayText;
            this.BackColor = Color.White;
        }
    }
}
