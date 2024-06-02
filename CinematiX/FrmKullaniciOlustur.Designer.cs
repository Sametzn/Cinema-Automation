namespace CinematiX
{
    partial class FrmKullaniciOlustur
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            btnKayitOl = new Button();
            txtSifre = new TextBox();
            txtAdSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(475, 40);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 57, 53);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(435, 0);
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
            label1.Size = new Size(101, 25);
            label1.TabIndex = 1;
            label1.Text = "CinematiX";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Crimson;
            btnKayitOl.Cursor = Cursors.Hand;
            btnKayitOl.FlatAppearance.BorderSize = 0;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Location = new Point(255, 162);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(184, 50);
            btnKayitOl.TabIndex = 11;
            btnKayitOl.Text = "KAYIT EKLE";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click_1;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(255, 124);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(184, 25);
            txtSifre.TabIndex = 10;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAdSoyad.Location = new Point(255, 61);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(184, 25);
            txtAdSoyad.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 124);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 7;
            label3.Text = "YETKİLİ ŞİFRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 61);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 6;
            label2.Text = "YETKİLİ AD SOYAD";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(255, 92);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(184, 25);
            txtKullaniciAdi.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 92);
            label4.Name = "label4";
            label4.Size = new Size(214, 25);
            label4.TabIndex = 11;
            label4.Text = "YETKİLİ KULLANICI ADI";
            // 
            // FrmKullaniciOlustur
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(475, 235);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label4);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifre);
            Controls.Add(txtAdSoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FrmKullaniciOlustur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmKullaniciOlustur";
            KeyDown += FrmKullaniciOlustur_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button btnKayitOl;
        private TextBox txtSifre;
        private TextBox txtAdSoyad;
        private Label label3;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private Label label4;
    }
}