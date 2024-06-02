namespace CinematiX
{
    partial class OyuncuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuListesi));
            button1 = new Button();
            lblCinsiyet = new Label();
            pCinsiyet = new PictureBox();
            btnresimyukle = new Button();
            pResimDetay = new PictureBox();
            lblid = new Label();
            lblAdSoyad = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pCinsiyet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pResimDetay).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(494, 41);
            button1.Name = "button1";
            button1.Size = new Size(64, 40);
            button1.TabIndex = 15;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.BackColor = Color.WhiteSmoke;
            lblCinsiyet.ForeColor = Color.CadetBlue;
            lblCinsiyet.Location = new Point(120, 58);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(38, 15);
            lblCinsiyet.TabIndex = 14;
            lblCinsiyet.Text = "label1";
            lblCinsiyet.Visible = false;
            // 
            // pCinsiyet
            // 
            pCinsiyet.ErrorImage = null;
            pCinsiyet.Image = (Image)resources.GetObject("pCinsiyet.Image");
            pCinsiyet.Location = new Point(115, 8);
            pCinsiyet.Name = "pCinsiyet";
            pCinsiyet.Size = new Size(34, 31);
            pCinsiyet.SizeMode = PictureBoxSizeMode.Zoom;
            pCinsiyet.TabIndex = 13;
            pCinsiyet.TabStop = false;
            // 
            // btnresimyukle
            // 
            btnresimyukle.BackColor = Color.Black;
            btnresimyukle.FlatAppearance.BorderSize = 0;
            btnresimyukle.FlatStyle = FlatStyle.Flat;
            btnresimyukle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnresimyukle.ForeColor = Color.White;
            btnresimyukle.Location = new Point(363, 41);
            btnresimyukle.Name = "btnresimyukle";
            btnresimyukle.Size = new Size(127, 40);
            btnresimyukle.TabIndex = 12;
            btnresimyukle.Text = "DETAY";
            btnresimyukle.UseVisualStyleBackColor = false;
            btnresimyukle.Click += btnresimyukle_Click;
            // 
            // pResimDetay
            // 
            pResimDetay.Image = (Image)resources.GetObject("pResimDetay.Image");
            pResimDetay.Location = new Point(20, 3);
            pResimDetay.Name = "pResimDetay";
            pResimDetay.Size = new Size(84, 75);
            pResimDetay.SizeMode = PictureBoxSizeMode.Zoom;
            pResimDetay.TabIndex = 11;
            pResimDetay.TabStop = false;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.BackColor = Color.WhiteSmoke;
            lblid.ForeColor = Color.CadetBlue;
            lblid.Location = new Point(520, 3);
            lblid.Name = "lblid";
            lblid.Size = new Size(38, 15);
            lblid.TabIndex = 10;
            lblid.Text = "label1";
            lblid.Visible = false;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.BackColor = Color.WhiteSmoke;
            lblAdSoyad.ForeColor = Color.CadetBlue;
            lblAdSoyad.Location = new Point(164, 19);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(38, 15);
            lblAdSoyad.TabIndex = 9;
            lblAdSoyad.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 83);
            panel1.TabIndex = 8;
            // 
            // OyuncuListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(lblCinsiyet);
            Controls.Add(pCinsiyet);
            Controls.Add(btnresimyukle);
            Controls.Add(pResimDetay);
            Controls.Add(lblid);
            Controls.Add(lblAdSoyad);
            Controls.Add(panel1);
            Name = "OyuncuListesi";
            Size = new Size(561, 83);
            Load += OyuncuListesi_Load;
            ((System.ComponentModel.ISupportInitialize)pCinsiyet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pResimDetay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public Label lblCinsiyet;
        public PictureBox pCinsiyet;
        private Button btnresimyukle;
        public PictureBox pResimDetay;
        public Label lblid;
        public Label lblAdSoyad;
        private Panel panel1;
    }
}
