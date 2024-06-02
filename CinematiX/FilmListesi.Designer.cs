namespace CinematiX
{
    partial class FilmListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmListesi));
            groupBox9 = new GroupBox();
            button1 = new Button();
            lblID = new Label();
            lblFilmAdi = new Label();
            btnFilm = new Button();
            pResim = new PictureBox();
            textBox8 = new TextBox();
            label26 = new Label();
            label27 = new Label();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pResim).BeginInit();
            SuspendLayout();
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(button1);
            groupBox9.Controls.Add(lblID);
            groupBox9.Controls.Add(lblFilmAdi);
            groupBox9.Controls.Add(btnFilm);
            groupBox9.Controls.Add(pResim);
            groupBox9.Controls.Add(textBox8);
            groupBox9.Controls.Add(label26);
            groupBox9.Controls.Add(label27);
            groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.Black;
            groupBox9.Location = new Point(10, 3);
            groupBox9.Margin = new Padding(10, 3, 3, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(161, 230);
            groupBox9.TabIndex = 21;
            groupBox9.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 188);
            button1.Name = "button1";
            button1.Size = new Size(138, 36);
            button1.TabIndex = 28;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(6, 110);
            lblID.Name = "lblID";
            lblID.Size = new Size(45, 21);
            lblID.TabIndex = 27;
            lblID.Text = "label";
            lblID.Visible = false;
            // 
            // lblFilmAdi
            // 
            lblFilmAdi.AutoSize = true;
            lblFilmAdi.Location = new Point(0, 0);
            lblFilmAdi.Name = "lblFilmAdi";
            lblFilmAdi.Size = new Size(83, 21);
            lblFilmAdi.TabIndex = 26;
            lblFilmAdi.Text = "FİLM AFİS";
            // 
            // btnFilm
            // 
            btnFilm.BackColor = Color.Chocolate;
            btnFilm.FlatAppearance.BorderSize = 0;
            btnFilm.FlatStyle = FlatStyle.Flat;
            btnFilm.Location = new Point(6, 147);
            btnFilm.Name = "btnFilm";
            btnFilm.Size = new Size(138, 35);
            btnFilm.TabIndex = 25;
            btnFilm.Text = "DETAY";
            btnFilm.UseVisualStyleBackColor = false;
            btnFilm.Click += btnFilm_Click;
            // 
            // pResim
            // 
            pResim.Image = (Image)resources.GetObject("pResim.Image");
            pResim.Location = new Point(6, 24);
            pResim.Name = "pResim";
            pResim.Size = new Size(138, 107);
            pResim.SizeMode = PictureBoxSizeMode.Zoom;
            pResim.TabIndex = 24;
            pResim.TabStop = false;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Dock = DockStyle.Bottom;
            textBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(3, 13);
            textBox8.Margin = new Padding(10, 3, 3, 3);
            textBox8.MaxLength = 300;
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(155, 214);
            textBox8.TabIndex = 13;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(23, 0);
            label26.Name = "label26";
            label26.Size = new Size(0, 21);
            label26.TabIndex = 13;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.FromArgb(255, 128, 0);
            label27.Location = new Point(350, 0);
            label27.Name = "label27";
            label27.Size = new Size(0, 21);
            label27.TabIndex = 13;
            // 
            // FilmListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox9);
            Name = "FilmListesi";
            Size = new Size(173, 236);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pResim).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox8;
        private Label label26;
        private Label label27;
        public GroupBox groupBox9;
        public Label lblFilmAdi;
        public Button btnFilm;
        public PictureBox pResim;
        public Label lblID;
        private Button button1;
    }
}
