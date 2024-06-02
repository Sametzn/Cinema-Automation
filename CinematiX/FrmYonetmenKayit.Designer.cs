namespace CinematiX
{
    partial class FrmYonetmenKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYonetmenKayit));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rKadin = new RadioButton();
            rErkek = new RadioButton();
            label5 = new Label();
            nyil = new NumericUpDown();
            nay = new NumericUpDown();
            ngun = new NumericUpDown();
            label4 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnresimyukle = new Button();
            pResim = new PictureBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblkarakter = new Label();
            txtbiyografi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnkaydet = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nyil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ngun).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pResim).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 40);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 57, 53);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(534, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 1;
            label1.Text = "Yönetmen  Kayıt Ekranı";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rKadin);
            groupBox1.Controls.Add(rErkek);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nyil);
            groupBox1.Controls.Add(nay);
            groupBox1.Controls.Add(ngun);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(33, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 286);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rKadin
            // 
            rKadin.AutoSize = true;
            rKadin.Location = new Point(136, 249);
            rKadin.Name = "rKadin";
            rKadin.Size = new Size(69, 25);
            rKadin.TabIndex = 12;
            rKadin.Text = "Kadın";
            rKadin.UseVisualStyleBackColor = true;
            rKadin.CheckedChanged += rKadin_CheckedChanged;
            // 
            // rErkek
            // 
            rErkek.AutoSize = true;
            rErkek.Checked = true;
            rErkek.Location = new Point(23, 249);
            rErkek.Name = "rErkek";
            rErkek.Size = new Size(74, 25);
            rErkek.TabIndex = 11;
            rErkek.TabStop = true;
            rErkek.Text = "ERKEK";
            rErkek.UseVisualStyleBackColor = true;
            rErkek.CheckedChanged += eErkek_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 215);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 9;
            label5.Text = "CİNSİYET";
            // 
            // nyil
            // 
            nyil.ForeColor = Color.Black;
            nyil.Location = new Point(182, 171);
            nyil.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            nyil.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            nyil.Name = "nyil";
            nyil.Size = new Size(69, 29);
            nyil.TabIndex = 8;
            nyil.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // nay
            // 
            nay.ForeColor = Color.Black;
            nay.Location = new Point(111, 171);
            nay.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nay.Name = "nay";
            nay.Size = new Size(56, 29);
            nay.TabIndex = 7;
            nay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ngun
            // 
            ngun.ForeColor = Color.Black;
            ngun.Location = new Point(41, 171);
            ngun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            ngun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ngun.Name = "ngun";
            ngun.Size = new Size(56, 29);
            ngun.TabIndex = 6;
            ngun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 147);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 4;
            label4.Text = "DOĞUM TARİHİ";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSoyad.ForeColor = Color.Black;
            txtSoyad.Location = new Point(41, 109);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(188, 25);
            txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 85);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 2;
            label3.Text = "SOYAD";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.ForeColor = Color.Black;
            txtAd.Location = new Point(41, 49);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(188, 25);
            txtAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 25);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 0;
            label2.Text = "AD";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnresimyukle);
            groupBox2.Controls.Add(pResim);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(320, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(225, 286);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // btnresimyukle
            // 
            btnresimyukle.BackColor = Color.Chocolate;
            btnresimyukle.FlatAppearance.BorderSize = 0;
            btnresimyukle.FlatStyle = FlatStyle.Flat;
            btnresimyukle.Location = new Point(22, 234);
            btnresimyukle.Name = "btnresimyukle";
            btnresimyukle.Size = new Size(190, 40);
            btnresimyukle.TabIndex = 2;
            btnresimyukle.Text = "YÜKLE";
            btnresimyukle.UseVisualStyleBackColor = false;
            btnresimyukle.Click += btnresimyukle_Click;
            // 
            // pResim
            // 
            pResim.Image = (Image)resources.GetObject("pResim.Image");
            pResim.Location = new Point(22, 49);
            pResim.Name = "pResim";
            pResim.Size = new Size(190, 163);
            pResim.SizeMode = PictureBoxSizeMode.Zoom;
            pResim.TabIndex = 14;
            pResim.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 25);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 13;
            label6.Text = "RESİM";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblkarakter);
            groupBox3.Controls.Add(txtbiyografi);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(33, 353);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(512, 267);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // lblkarakter
            // 
            lblkarakter.BackColor = Color.White;
            lblkarakter.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblkarakter.ForeColor = Color.DarkGreen;
            lblkarakter.Location = new Point(460, 233);
            lblkarakter.Name = "lblkarakter";
            lblkarakter.RightToLeft = RightToLeft.Yes;
            lblkarakter.Size = new Size(38, 18);
            lblkarakter.TabIndex = 14;
            lblkarakter.Text = "300";
            lblkarakter.Click += lblkarakter_Click;
            // 
            // txtbiyografi
            // 
            txtbiyografi.Dock = DockStyle.Fill;
            txtbiyografi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtbiyografi.ForeColor = Color.Black;
            txtbiyografi.Location = new Point(3, 25);
            txtbiyografi.MaxLength = 300;
            txtbiyografi.Multiline = true;
            txtbiyografi.Name = "txtbiyografi";
            txtbiyografi.Size = new Size(506, 239);
            txtbiyografi.TabIndex = 13;
            txtbiyografi.TextChanged += txtbiyografi_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 13;
            label8.Text = "BİYOGRAFİ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(350, 0);
            label7.Name = "label7";
            label7.Size = new Size(147, 21);
            label7.TabIndex = 13;
            label7.Text = "(Max 300 Karakter)";
            // 
            // btnkaydet
            // 
            btnkaydet.BackColor = Color.Gold;
            btnkaydet.Dock = DockStyle.Bottom;
            btnkaydet.FlatAppearance.BorderSize = 0;
            btnkaydet.FlatStyle = FlatStyle.Flat;
            btnkaydet.Location = new Point(0, 637);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(574, 40);
            btnkaydet.TabIndex = 15;
            btnkaydet.Text = "KAYIT TAMAMLA";
            btnkaydet.UseVisualStyleBackColor = false;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(201, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // FrmYonetmenKayit
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 677);
            Controls.Add(btnkaydet);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(800, 200);
            Margin = new Padding(5);
            Name = "FrmYonetmenKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmYonetmenKayit";
            Load += FrmYonetmenKayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nyil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nay).EndInit();
            ((System.ComponentModel.ISupportInitialize)ngun).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pResim).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label4;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private NumericUpDown nyil;
        private NumericUpDown nay;
        private NumericUpDown ngun;
        private RadioButton rKadin;
        private RadioButton rErkek;
        private Label label5;
        private PictureBox pResim;
        private Label label6;
        private Button btnresimyukle;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox txtbiyografi;
        private Label label8;
        private Label lblkarakter;
        private Button btnkaydet;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}