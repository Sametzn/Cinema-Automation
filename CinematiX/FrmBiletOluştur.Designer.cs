namespace CinematiX
{
    partial class FrmBiletOluştur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletOluştur));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            lblkarakter = new Label();
            txtAdSoyad = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtBarkod = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtTelNo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            cbFilmAdi = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox5 = new GroupBox();
            cbTarih = new ComboBox();
            lblYonetmenAra = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            groupBox6 = new GroupBox();
            lblSeansSec = new Label();
            PanelSeans = new FlowLayoutPanel();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            groupBox7 = new GroupBox();
            lblKoltukSayisi = new Label();
            cbSalonAdi = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            groupBox8 = new GroupBox();
            cbBiletTürü = new ComboBox();
            label23 = new Label();
            label24 = new Label();
            label26 = new Label();
            groupBox9 = new GroupBox();
            txtKoltuklar = new TextBox();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            btnBiletAl = new Button();
            pictureBox1 = new PictureBox();
            label19 = new Label();
            KoltukPaneli = new FlowLayoutPanel();
            ListeGelenKoltuk = new ListBox();
            pictureBox2 = new PictureBox();
            label25 = new Label();
            label30 = new Label();
            label31 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            lblGelenKoltuk = new Label();
            lbBelirlenen = new ListBox();
            button2 = new Button();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel1.Size = new Size(1143, 40);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 57, 53);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1103, 0);
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
            label1.Size = new Size(203, 25);
            label1.TabIndex = 1;
            label1.Text = "Bilet Oluşturma Ekranı";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblkarakter);
            groupBox3.Controls.Add(txtAdSoyad);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(19, 109);
            groupBox3.Margin = new Padding(10, 3, 3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 60);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "AD SOYAD";
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
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BorderStyle = BorderStyle.None;
            txtAdSoyad.Dock = DockStyle.Bottom;
            txtAdSoyad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAdSoyad.ForeColor = Color.Black;
            txtAdSoyad.Location = new Point(3, 34);
            txtAdSoyad.Margin = new Padding(10, 3, 3, 3);
            txtAdSoyad.MaxLength = 300;
            txtAdSoyad.Multiline = true;
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(294, 23);
            txtAdSoyad.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(350, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBarkod);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(19, 46);
            groupBox1.Margin = new Padding(10, 3, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 57);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLET NUMARASI";
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(460, 233);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(38, 18);
            label2.TabIndex = 14;
            // 
            // txtBarkod
            // 
            txtBarkod.BorderStyle = BorderStyle.None;
            txtBarkod.Dock = DockStyle.Bottom;
            txtBarkod.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBarkod.ForeColor = Color.Black;
            txtBarkod.Location = new Point(3, 31);
            txtBarkod.Margin = new Padding(10, 3, 3, 3);
            txtBarkod.MaxLength = 300;
            txtBarkod.Multiline = true;
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(294, 23);
            txtBarkod.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(350, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTelNo);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(19, 175);
            groupBox2.Margin = new Padding(10, 3, 3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 53);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "TELEFON NUMARASI";
            // 
            // txtTelNo
            // 
            txtTelNo.BorderStyle = BorderStyle.None;
            txtTelNo.Dock = DockStyle.Bottom;
            txtTelNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtTelNo.ForeColor = Color.Black;
            txtTelNo.Location = new Point(3, 27);
            txtTelNo.Margin = new Padding(10, 3, 3, 3);
            txtTelNo.MaxLength = 300;
            txtTelNo.Multiline = true;
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(294, 23);
            txtTelNo.TabIndex = 51;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(460, 233);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(38, 18);
            label5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(350, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 21);
            label9.TabIndex = 13;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbFilmAdi);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(19, 231);
            groupBox4.Margin = new Padding(10, 3, 3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 50);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "FİLM ADI";
            // 
            // cbFilmAdi
            // 
            cbFilmAdi.BackColor = Color.White;
            cbFilmAdi.Dock = DockStyle.Bottom;
            cbFilmAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilmAdi.FlatStyle = FlatStyle.Flat;
            cbFilmAdi.FormattingEnabled = true;
            cbFilmAdi.Location = new Point(3, 18);
            cbFilmAdi.Name = "cbFilmAdi";
            cbFilmAdi.Size = new Size(294, 29);
            cbFilmAdi.TabIndex = 52;
            cbFilmAdi.SelectedIndexChanged += cbFilmAdi_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(460, 233);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(38, 18);
            label10.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 21);
            label11.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(255, 128, 0);
            label12.Location = new Point(350, 0);
            label12.Name = "label12";
            label12.Size = new Size(0, 21);
            label12.TabIndex = 13;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbTarih);
            groupBox5.Controls.Add(lblYonetmenAra);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label15);
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.Black;
            groupBox5.Location = new Point(19, 287);
            groupBox5.Margin = new Padding(10, 3, 3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(300, 61);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "TARİH";
            // 
            // cbTarih
            // 
            cbTarih.BackColor = Color.White;
            cbTarih.Dock = DockStyle.Bottom;
            cbTarih.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTarih.FlatStyle = FlatStyle.Flat;
            cbTarih.FormattingEnabled = true;
            cbTarih.Location = new Point(3, 29);
            cbTarih.Name = "cbTarih";
            cbTarih.Size = new Size(294, 29);
            cbTarih.TabIndex = 53;
            cbTarih.SelectedIndexChanged += cbTarih_SelectedIndexChanged;
            // 
            // lblYonetmenAra
            // 
            lblYonetmenAra.AutoSize = true;
            lblYonetmenAra.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYonetmenAra.Location = new Point(209, 2);
            lblYonetmenAra.Name = "lblYonetmenAra";
            lblYonetmenAra.Size = new Size(65, 19);
            lblYonetmenAra.TabIndex = 24;
            lblYonetmenAra.Text = "gg/aa/yy";
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkGreen;
            label13.Location = new Point(460, 233);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(38, 18);
            label13.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 0);
            label14.Name = "label14";
            label14.Size = new Size(0, 21);
            label14.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(255, 128, 0);
            label15.Location = new Point(350, 0);
            label15.Name = "label15";
            label15.Size = new Size(0, 21);
            label15.TabIndex = 13;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblSeansSec);
            groupBox6.Controls.Add(PanelSeans);
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(label18);
            groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.Black;
            groupBox6.Location = new Point(19, 354);
            groupBox6.Margin = new Padding(10, 3, 3, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(300, 110);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "FİLM SAATİ";
            // 
            // lblSeansSec
            // 
            lblSeansSec.AutoSize = true;
            lblSeansSec.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSeansSec.Location = new Point(223, 3);
            lblSeansSec.Name = "lblSeansSec";
            lblSeansSec.Size = new Size(71, 19);
            lblSeansSec.TabIndex = 26;
            lblSeansSec.Text = "Seans Seç";
            lblSeansSec.Visible = false;
            // 
            // PanelSeans
            // 
            PanelSeans.AutoScroll = true;
            PanelSeans.Dock = DockStyle.Fill;
            PanelSeans.Location = new Point(3, 25);
            PanelSeans.Name = "PanelSeans";
            PanelSeans.Size = new Size(294, 82);
            PanelSeans.TabIndex = 54;
            PanelSeans.WrapContents = false;
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DarkGreen;
            label16.Location = new Point(460, 233);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(38, 18);
            label16.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(23, 0);
            label17.Name = "label17";
            label17.Size = new Size(0, 21);
            label17.TabIndex = 13;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(255, 128, 0);
            label18.Location = new Point(350, 0);
            label18.Name = "label18";
            label18.Size = new Size(0, 21);
            label18.TabIndex = 13;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lblKoltukSayisi);
            groupBox7.Controls.Add(cbSalonAdi);
            groupBox7.Controls.Add(label20);
            groupBox7.Controls.Add(label21);
            groupBox7.Controls.Add(label22);
            groupBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.Black;
            groupBox7.Location = new Point(19, 470);
            groupBox7.Margin = new Padding(10, 3, 3, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(300, 53);
            groupBox7.TabIndex = 17;
            groupBox7.TabStop = false;
            groupBox7.Text = "SALON ADI";
            // 
            // lblKoltukSayisi
            // 
            lblKoltukSayisi.AutoSize = true;
            lblKoltukSayisi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKoltukSayisi.Location = new Point(202, 3);
            lblKoltukSayisi.Name = "lblKoltukSayisi";
            lblKoltukSayisi.Size = new Size(86, 19);
            lblKoltukSayisi.TabIndex = 28;
            lblKoltukSayisi.Text = "KoltukSayisi";
            lblKoltukSayisi.Visible = false;
            // 
            // cbSalonAdi
            // 
            cbSalonAdi.BackColor = Color.White;
            cbSalonAdi.Dock = DockStyle.Bottom;
            cbSalonAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSalonAdi.FlatStyle = FlatStyle.Flat;
            cbSalonAdi.FormattingEnabled = true;
            cbSalonAdi.Location = new Point(3, 21);
            cbSalonAdi.Name = "cbSalonAdi";
            cbSalonAdi.Size = new Size(294, 29);
            cbSalonAdi.TabIndex = 55;
            cbSalonAdi.SelectedIndexChanged += cbSalonAdi_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.BackColor = Color.White;
            label20.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.DarkGreen;
            label20.Location = new Point(460, 233);
            label20.Name = "label20";
            label20.RightToLeft = RightToLeft.Yes;
            label20.Size = new Size(38, 18);
            label20.TabIndex = 14;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(23, 0);
            label21.Name = "label21";
            label21.Size = new Size(0, 21);
            label21.TabIndex = 13;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.FromArgb(255, 128, 0);
            label22.Location = new Point(350, 0);
            label22.Name = "label22";
            label22.Size = new Size(0, 21);
            label22.TabIndex = 13;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(cbBiletTürü);
            groupBox8.Controls.Add(label23);
            groupBox8.Controls.Add(label24);
            groupBox8.Controls.Add(label26);
            groupBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox8.ForeColor = Color.Black;
            groupBox8.Location = new Point(19, 529);
            groupBox8.Margin = new Padding(10, 3, 3, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(300, 55);
            groupBox8.TabIndex = 18;
            groupBox8.TabStop = false;
            groupBox8.Text = "BİLET TÜRÜ";
            // 
            // cbBiletTürü
            // 
            cbBiletTürü.BackColor = Color.White;
            cbBiletTürü.Dock = DockStyle.Bottom;
            cbBiletTürü.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBiletTürü.FlatStyle = FlatStyle.Flat;
            cbBiletTürü.FormattingEnabled = true;
            cbBiletTürü.Items.AddRange(new object[] { "YETİŞKİN ", "ÖĞRENCİ" });
            cbBiletTürü.Location = new Point(3, 23);
            cbBiletTürü.Name = "cbBiletTürü";
            cbBiletTürü.Size = new Size(294, 29);
            cbBiletTürü.TabIndex = 56;
            // 
            // label23
            // 
            label23.BackColor = Color.White;
            label23.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.DarkGreen;
            label23.Location = new Point(460, 233);
            label23.Name = "label23";
            label23.RightToLeft = RightToLeft.Yes;
            label23.Size = new Size(38, 18);
            label23.TabIndex = 14;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(23, 0);
            label24.Name = "label24";
            label24.Size = new Size(0, 21);
            label24.TabIndex = 13;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = Color.FromArgb(255, 128, 0);
            label26.Location = new Point(350, 0);
            label26.Name = "label26";
            label26.Size = new Size(0, 21);
            label26.TabIndex = 13;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtKoltuklar);
            groupBox9.Controls.Add(label27);
            groupBox9.Controls.Add(label28);
            groupBox9.Controls.Add(label29);
            groupBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.Black;
            groupBox9.Location = new Point(19, 590);
            groupBox9.Margin = new Padding(10, 3, 3, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(300, 55);
            groupBox9.TabIndex = 19;
            groupBox9.TabStop = false;
            groupBox9.Text = "SEÇİLEN KOLTUK(LAR)";
            // 
            // txtKoltuklar
            // 
            txtKoltuklar.BorderStyle = BorderStyle.None;
            txtKoltuklar.Dock = DockStyle.Bottom;
            txtKoltuklar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKoltuklar.ForeColor = Color.Black;
            txtKoltuklar.Location = new Point(3, 29);
            txtKoltuklar.Margin = new Padding(10, 3, 3, 3);
            txtKoltuklar.MaxLength = 300;
            txtKoltuklar.Multiline = true;
            txtKoltuklar.Name = "txtKoltuklar";
            txtKoltuklar.Size = new Size(294, 23);
            txtKoltuklar.TabIndex = 15;
            // 
            // label27
            // 
            label27.BackColor = Color.White;
            label27.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.DarkGreen;
            label27.Location = new Point(460, 233);
            label27.Name = "label27";
            label27.RightToLeft = RightToLeft.Yes;
            label27.Size = new Size(38, 18);
            label27.TabIndex = 14;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(23, 0);
            label28.Name = "label28";
            label28.Size = new Size(0, 21);
            label28.TabIndex = 13;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.FromArgb(255, 128, 0);
            label29.Location = new Point(350, 0);
            label29.Name = "label29";
            label29.Size = new Size(0, 21);
            label29.TabIndex = 13;
            // 
            // btnBiletAl
            // 
            btnBiletAl.BackColor = Color.Chocolate;
            btnBiletAl.FlatAppearance.BorderSize = 0;
            btnBiletAl.FlatStyle = FlatStyle.Flat;
            btnBiletAl.Location = new Point(25, 650);
            btnBiletAl.Name = "btnBiletAl";
            btnBiletAl.Size = new Size(184, 39);
            btnBiletAl.TabIndex = 26;
            btnBiletAl.Text = "BİLET AL";
            btnBiletAl.UseVisualStyleBackColor = false;
            btnBiletAl.Click += btnBiletAl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(781, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Black;
            label19.ForeColor = Color.White;
            label19.Location = new Point(668, 78);
            label19.Name = "label19";
            label19.Size = new Size(69, 25);
            label19.TabIndex = 28;
            label19.Text = "PERDE";
            // 
            // KoltukPaneli
            // 
            KoltukPaneli.AutoScroll = true;
            KoltukPaneli.Location = new Point(353, 127);
            KoltukPaneli.Name = "KoltukPaneli";
            KoltukPaneli.Size = new Size(710, 562);
            KoltukPaneli.TabIndex = 29;
            // 
            // ListeGelenKoltuk
            // 
            ListeGelenKoltuk.FormattingEnabled = true;
            ListeGelenKoltuk.ItemHeight = 25;
            ListeGelenKoltuk.Location = new Point(1063, 581);
            ListeGelenKoltuk.Name = "ListeGelenKoltuk";
            ListeGelenKoltuk.Size = new Size(65, 79);
            ListeGelenKoltuk.TabIndex = 0;
            ListeGelenKoltuk.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bos;
            pictureBox2.Location = new Point(1069, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label25.ForeColor = SystemColors.MenuHighlight;
            label25.Location = new Point(1077, 276);
            label25.Name = "label25";
            label25.Size = new Size(40, 19);
            label25.TabIndex = 28;
            label25.Text = "BOŞ ";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label30.Location = new Point(1067, 397);
            label30.Name = "label30";
            label30.Size = new Size(61, 19);
            label30.TabIndex = 31;
            label30.Text = "KOLTUK";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label31.ForeColor = Color.FromArgb(255, 128, 0);
            label31.Location = new Point(1067, 486);
            label31.Name = "label31";
            label31.Size = new Size(66, 19);
            label31.TabIndex = 32;
            label31.Text = "SECİLEN ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.secili;
            pictureBox3.Location = new Point(1069, 422);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.dolu;
            pictureBox4.Location = new Point(1069, 318);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label32.ForeColor = SystemColors.MenuHighlight;
            label32.Location = new Point(1062, 293);
            label32.Name = "label32";
            label32.Size = new Size(65, 19);
            label32.TabIndex = 35;
            label32.Text = " KOLTUK";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label33.Location = new Point(1071, 378);
            label33.Name = "label33";
            label33.Size = new Size(51, 19);
            label33.TabIndex = 36;
            label33.Text = "DOLU ";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label34.ForeColor = Color.FromArgb(255, 128, 0);
            label34.Location = new Point(1067, 505);
            label34.Name = "label34";
            label34.Size = new Size(61, 19);
            label34.TabIndex = 37;
            label34.Text = "KOLTUK";
            // 
            // lblGelenKoltuk
            // 
            lblGelenKoltuk.AutoSize = true;
            lblGelenKoltuk.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGelenKoltuk.Location = new Point(171, 343);
            lblGelenKoltuk.Name = "lblGelenKoltuk";
            lblGelenKoltuk.Size = new Size(65, 19);
            lblGelenKoltuk.TabIndex = 26;
            lblGelenKoltuk.Text = "gg/aa/yy";
            lblGelenKoltuk.Visible = false;
            // 
            // lbBelirlenen
            // 
            lbBelirlenen.FormattingEnabled = true;
            lbBelirlenen.ItemHeight = 25;
            lbBelirlenen.Location = new Point(1077, 149);
            lbBelirlenen.Name = "lbBelirlenen";
            lbBelirlenen.Size = new Size(50, 54);
            lbBelirlenen.TabIndex = 38;
            lbBelirlenen.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(215, 651);
            button2.Name = "button2";
            button2.Size = new Size(101, 40);
            button2.TabIndex = 39;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FrmBiletOluştur
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 738);
            Controls.Add(button2);
            Controls.Add(lbBelirlenen);
            Controls.Add(ListeGelenKoltuk);
            Controls.Add(lblGelenKoltuk);
            Controls.Add(label34);
            Controls.Add(label33);
            Controls.Add(label32);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label25);
            Controls.Add(pictureBox2);
            Controls.Add(KoltukPaneli);
            Controls.Add(label19);
            Controls.Add(pictureBox1);
            Controls.Add(btnBiletAl);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 200);
            Margin = new Padding(5);
            Name = "FrmBiletOluştur";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletOluştur";
            Load += FrmBiletOluştur_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox3;
        private Label lblkarakter;
        private TextBox txtAdSoyad;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtBarkod;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label9;
        private TextBox txtTelNo;
        private GroupBox groupBox4;
        private ComboBox cbFilmAdi;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox groupBox5;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label lblYonetmenAra;
        private GroupBox groupBox6;
        private Label label16;
        private Label label17;
        private Label label18;
        private GroupBox groupBox7;
        private ComboBox cbSalonAdi;
        private Label label20;
        private Label label21;
        private Label label22;
        private GroupBox groupBox8;
        private ComboBox cbBiletTürü;
        private Label label23;
        private Label label24;
        private Label label26;
        private GroupBox groupBox9;
        private Label label27;
        private Label label28;
        private Label label29;
        private TextBox txtKoltuklar;
        private Button btnBiletAl;
        private ComboBox cbTarih;
        private FlowLayoutPanel PanelSeans;
        private Label lblSeansSec;
        private Label lblKoltukSayisi;
        private PictureBox pictureBox1;
        private Label label19;
        private FlowLayoutPanel KoltukPaneli;
        private PictureBox pictureBox2;
        private Label label25;
        private Label label30;
        private Label label31;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label lblGelenKoltuk;
        private ListBox ListeGelenKoltuk;
        private ListBox lbBelirlenen;
        private Button button2;
    }
}