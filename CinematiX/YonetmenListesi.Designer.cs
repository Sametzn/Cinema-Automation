namespace CinematiX
{
    partial class YonetmenListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetmenListesi));
            panel1 = new Panel();
            lblAdSoyad = new Label();
            lblid = new Label();
            pResimDetay = new PictureBox();
            btnresimyukle = new Button();
            pCinsiyet = new PictureBox();
            lblCinsiyet = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pResimDetay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pCinsiyet).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 81);
            panel1.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.BackColor = Color.WhiteSmoke;
            lblAdSoyad.ForeColor = Color.CadetBlue;
            lblAdSoyad.Location = new Point(155, 19);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(38, 15);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "label1";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.BackColor = Color.WhiteSmoke;
            lblid.ForeColor = Color.CadetBlue;
            lblid.Location = new Point(511, 3);
            lblid.Name = "lblid";
            lblid.Size = new Size(38, 15);
            lblid.TabIndex = 2;
            lblid.Text = "label1";
            lblid.Visible = false;
            // 
            // pResimDetay
            // 
            pResimDetay.Image = (Image)resources.GetObject("pResimDetay.Image");
            pResimDetay.Location = new Point(11, 3);
            pResimDetay.Name = "pResimDetay";
            pResimDetay.Size = new Size(84, 75);
            pResimDetay.SizeMode = PictureBoxSizeMode.Zoom;
            pResimDetay.TabIndex = 3;
            pResimDetay.TabStop = false;
            pResimDetay.Click += pResimDetay_Click;
            // 
            // btnresimyukle
            // 
            btnresimyukle.BackColor = Color.Chocolate;
            btnresimyukle.FlatAppearance.BorderSize = 0;
            btnresimyukle.FlatStyle = FlatStyle.Flat;
            btnresimyukle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnresimyukle.ForeColor = Color.White;
            btnresimyukle.Location = new Point(354, 41);
            btnresimyukle.Name = "btnresimyukle";
            btnresimyukle.Size = new Size(127, 40);
            btnresimyukle.TabIndex = 4;
            btnresimyukle.Text = "DETAY";
            btnresimyukle.UseVisualStyleBackColor = false;
            btnresimyukle.Click += btnresimyukle_Click;
            // 
            // pCinsiyet
            // 
            pCinsiyet.ErrorImage = null;
            pCinsiyet.Image = (Image)resources.GetObject("pCinsiyet.Image");
            pCinsiyet.Location = new Point(106, 8);
            pCinsiyet.Name = "pCinsiyet";
            pCinsiyet.Size = new Size(34, 31);
            pCinsiyet.SizeMode = PictureBoxSizeMode.Zoom;
            pCinsiyet.TabIndex = 5;
            pCinsiyet.TabStop = false;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.BackColor = Color.WhiteSmoke;
            lblCinsiyet.ForeColor = Color.CadetBlue;
            lblCinsiyet.Location = new Point(111, 58);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(38, 15);
            lblCinsiyet.TabIndex = 6;
            lblCinsiyet.Text = "label1";
            lblCinsiyet.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(485, 41);
            button1.Name = "button1";
            button1.Size = new Size(64, 40);
            button1.TabIndex = 7;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // YonetmenListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(button1);
            Controls.Add(lblCinsiyet);
            Controls.Add(pCinsiyet);
            Controls.Add(btnresimyukle);
            Controls.Add(pResimDetay);
            Controls.Add(lblid);
            Controls.Add(lblAdSoyad);
            Controls.Add(panel1);
            Name = "YonetmenListesi";
            Size = new Size(549, 81);
            Load += YonetmenListesi_Load;
            ((System.ComponentModel.ISupportInitialize)pResimDetay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pCinsiyet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label lblAdSoyad;
        public Label lblid;
        public PictureBox pResimDetay;
        private Button btnresimyukle;
        public Label lblCinsiyet;
        public PictureBox pCinsiyet;
        private Button button1;
    }
}
