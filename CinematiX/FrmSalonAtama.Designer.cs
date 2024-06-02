namespace CinematiX
{
    partial class FrmSalonAtama
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
            btnBiletAl = new Button();
            groupBox7 = new GroupBox();
            lblKoltukSayisi = new Label();
            cbSalonAdi = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            groupBox6 = new GroupBox();
            PanelSeans = new FlowLayoutPanel();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            groupBox5 = new GroupBox();
            ngun = new NumericUpDown();
            nyil = new NumericUpDown();
            nay = new NumericUpDown();
            lblYonetmenAra = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            groupBox4 = new GroupBox();
            cbFilmAdi = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            cbDoluSaatler = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblSecilen = new Label();
            panel1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ngun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nay).BeginInit();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(881, 40);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 57, 53);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(841, 0);
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
            label1.Size = new Size(179, 25);
            label1.TabIndex = 1;
            label1.Text = "Salon Atama Ekranı";
            // 
            // btnBiletAl
            // 
            btnBiletAl.BackColor = Color.FromArgb(255, 128, 0);
            btnBiletAl.FlatAppearance.BorderSize = 0;
            btnBiletAl.FlatStyle = FlatStyle.Flat;
            btnBiletAl.Location = new Point(25, 263);
            btnBiletAl.Name = "btnBiletAl";
            btnBiletAl.Size = new Size(294, 40);
            btnBiletAl.TabIndex = 31;
            btnBiletAl.Text = "TAMAMLA";
            btnBiletAl.UseVisualStyleBackColor = false;
            btnBiletAl.Click += btnBiletAl_Click;
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
            groupBox7.Location = new Point(19, 116);
            groupBox7.Margin = new Padding(10, 3, 3, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(300, 53);
            groupBox7.TabIndex = 28;
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
            cbSalonAdi.TabIndex = 16;
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
            // groupBox6
            // 
            groupBox6.Controls.Add(PanelSeans);
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(label17);
            groupBox6.Controls.Add(label18);
            groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.Black;
            groupBox6.Location = new Point(349, 52);
            groupBox6.Margin = new Padding(10, 3, 3, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(520, 294);
            groupBox6.TabIndex = 29;
            groupBox6.TabStop = false;
            groupBox6.Text = "FİLM SAATİ";
            // 
            // PanelSeans
            // 
            PanelSeans.AutoScroll = true;
            PanelSeans.Dock = DockStyle.Fill;
            PanelSeans.Location = new Point(3, 25);
            PanelSeans.Name = "PanelSeans";
            PanelSeans.Size = new Size(514, 266);
            PanelSeans.TabIndex = 27;
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
            // groupBox5
            // 
            groupBox5.Controls.Add(ngun);
            groupBox5.Controls.Add(nyil);
            groupBox5.Controls.Add(nay);
            groupBox5.Controls.Add(lblYonetmenAra);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label15);
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.Black;
            groupBox5.Location = new Point(19, 186);
            groupBox5.Margin = new Padding(10, 3, 3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(300, 61);
            groupBox5.TabIndex = 30;
            groupBox5.TabStop = false;
            groupBox5.Text = "TARİH";
            // 
            // ngun
            // 
            ngun.BorderStyle = BorderStyle.None;
            ngun.ForeColor = Color.Black;
            ngun.Location = new Point(26, 28);
            ngun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            ngun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ngun.Name = "ngun";
            ngun.Size = new Size(56, 25);
            ngun.TabIndex = 29;
            ngun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nyil
            // 
            nyil.BorderStyle = BorderStyle.None;
            nyil.ForeColor = Color.Black;
            nyil.Location = new Point(178, 28);
            nyil.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nyil.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            nyil.Name = "nyil";
            nyil.Size = new Size(69, 25);
            nyil.TabIndex = 31;
            nyil.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // nay
            // 
            nay.BorderStyle = BorderStyle.None;
            nay.ForeColor = Color.Black;
            nay.Location = new Point(105, 28);
            nay.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nay.Name = "nay";
            nay.Size = new Size(56, 25);
            nay.TabIndex = 30;
            nay.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            // groupBox4
            // 
            groupBox4.Controls.Add(cbFilmAdi);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(22, 52);
            groupBox4.Margin = new Padding(10, 3, 3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(300, 50);
            groupBox4.TabIndex = 27;
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
            cbFilmAdi.TabIndex = 16;
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
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(22, 309);
            button2.Name = "button2";
            button2.Size = new Size(297, 37);
            button2.TabIndex = 40;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbDoluSaatler);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(45, 369);
            groupBox1.Margin = new Padding(10, 3, 3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 53);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "DOLU SAATLER";
            groupBox1.Visible = false;
            // 
            // cbDoluSaatler
            // 
            cbDoluSaatler.BackColor = Color.White;
            cbDoluSaatler.Dock = DockStyle.Bottom;
            cbDoluSaatler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoluSaatler.FlatStyle = FlatStyle.Flat;
            cbDoluSaatler.FormattingEnabled = true;
            cbDoluSaatler.Location = new Point(3, 21);
            cbDoluSaatler.Name = "cbDoluSaatler";
            cbDoluSaatler.Size = new Size(294, 29);
            cbDoluSaatler.TabIndex = 16;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(460, 233);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(38, 18);
            label3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(350, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 13;
            // 
            // lblSecilen
            // 
            lblSecilen.AutoSize = true;
            lblSecilen.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSecilen.Location = new Point(505, 396);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(65, 19);
            lblSecilen.TabIndex = 32;
            lblSecilen.Text = "gg/aa/yy";
            lblSecilen.Visible = false;
            // 
            // FrmSalonAtama
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(881, 359);
            Controls.Add(lblSecilen);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnBiletAl);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(600, 300);
            Margin = new Padding(5);
            Name = "FrmSalonAtama";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmSalonAtama";
            Load += FrmSalonAtama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ngun).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nay).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button btnBiletAl;
        private GroupBox groupBox7;
        private Label lblKoltukSayisi;
        private ComboBox cbSalonAdi;
        private Label label20;
        private Label label21;
        private Label label22;
        private GroupBox groupBox6;
        private FlowLayoutPanel PanelSeans;
        private Label label16;
        private Label label17;
        private Label label18;
        private GroupBox groupBox5;
        private Label lblYonetmenAra;
        private Label label13;
        private Label label14;
        private Label label15;
        private GroupBox groupBox4;
        private ComboBox cbFilmAdi;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button2;
        private NumericUpDown ngun;
        private NumericUpDown nyil;
        private NumericUpDown nay;
        private GroupBox groupBox1;
        private ComboBox cbDoluSaatler;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblSecilen;
    }
}