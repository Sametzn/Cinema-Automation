namespace CinematiX
{
    partial class FrmSalonKayit
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
            groupBox1 = new GroupBox();
            btnresimyukle = new Button();
            cbkoltuksayisi = new ComboBox();
            label3 = new Label();
            txtSalonAdi = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            panelSalon = new FlowLayoutPanel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.TabIndex = 5;
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
            label1.Size = new Size(166, 25);
            label1.TabIndex = 1;
            label1.Text = "Salon Kayıt Ekranı";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnresimyukle);
            groupBox1.Controls.Add(cbkoltuksayisi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSalonAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 103);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // btnresimyukle
            // 
            btnresimyukle.BackColor = Color.Chocolate;
            btnresimyukle.FlatAppearance.BorderSize = 0;
            btnresimyukle.FlatStyle = FlatStyle.Flat;
            btnresimyukle.Location = new Point(383, 39);
            btnresimyukle.Name = "btnresimyukle";
            btnresimyukle.Size = new Size(141, 40);
            btnresimyukle.TabIndex = 20;
            btnresimyukle.Text = "EKLE";
            btnresimyukle.UseVisualStyleBackColor = false;
            btnresimyukle.Click += btnresimyukle_Click;
            // 
            // cbkoltuksayisi
            // 
            cbkoltuksayisi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cbkoltuksayisi.FormattingEnabled = true;
            cbkoltuksayisi.Location = new Point(226, 49);
            cbkoltuksayisi.Name = "cbkoltuksayisi";
            cbkoltuksayisi.Size = new Size(121, 25);
            cbkoltuksayisi.TabIndex = 19;
            cbkoltuksayisi.SelectedIndexChanged += cbkoltuksayisi_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 25);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 2;
            label3.Text = "KOLTUK SAYISI";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSalonAdi
            // 
            txtSalonAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSalonAdi.ForeColor = Color.Black;
            txtSalonAdi.Location = new Point(20, 49);
            txtSalonAdi.Name = "txtSalonAdi";
            txtSalonAdi.Size = new Size(188, 25);
            txtSalonAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 25);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 0;
            label2.Text = "SALON ADI";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelSalon);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(12, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(550, 510);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // panelSalon
            // 
            panelSalon.AutoScroll = true;
            panelSalon.Dock = DockStyle.Fill;
            panelSalon.Location = new Point(3, 25);
            panelSalon.Name = "panelSalon";
            panelSalon.Size = new Size(544, 482);
            panelSalon.TabIndex = 0;
            // 
            // FrmSalonKayit
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(574, 677);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(800, 200);
            Margin = new Padding(5);
            Name = "FrmSalonKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmSalonKayit";
            Load += FrmSalonKayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbkoltuksayisi;
        private Label label3;
        private TextBox txtSalonAdi;
        private Label label2;
        private Button btnresimyukle;
        private GroupBox groupBox2;
        private FlowLayoutPanel panelSalon;
    }
}