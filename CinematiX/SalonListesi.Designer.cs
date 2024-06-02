namespace CinematiX
{
    partial class SalonListesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalonListesi));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblSalonAdi = new Label();
            lblKoltukSayisi = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 84);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseLeave += git;
            pictureBox1.MouseMove += gel;
            // 
            // lblSalonAdi
            // 
            lblSalonAdi.AutoSize = true;
            lblSalonAdi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSalonAdi.Location = new Point(106, 15);
            lblSalonAdi.Name = "lblSalonAdi";
            lblSalonAdi.Size = new Size(61, 25);
            lblSalonAdi.TabIndex = 2;
            lblSalonAdi.Text = "label1";
            lblSalonAdi.MouseLeave += git;
            lblSalonAdi.MouseMove += gel;
            // 
            // lblKoltukSayisi
            // 
            lblKoltukSayisi.AutoSize = true;
            lblKoltukSayisi.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKoltukSayisi.Location = new Point(196, 61);
            lblKoltukSayisi.Name = "lblKoltukSayisi";
            lblKoltukSayisi.Size = new Size(64, 25);
            lblKoltukSayisi.TabIndex = 3;
            lblKoltukSayisi.Text = "label2";
            lblKoltukSayisi.MouseLeave += git;
            lblKoltukSayisi.MouseMove += gel;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(91, 62);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 4;
            label1.Text = "Koltuk Sayısı:";
            label1.MouseLeave += git;
            label1.MouseMove += gel;
            // 
            // SalonListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label1);
            Controls.Add(lblKoltukSayisi);
            Controls.Add(lblSalonAdi);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "SalonListesi";
            Size = new Size(254, 84);
            MouseLeave += git;
            MouseMove += gel;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public Label lblSalonAdi;
        public Label lblKoltukSayisi;
        public Label label1;
    }
}
