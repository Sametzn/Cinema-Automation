namespace CinematiX
{
    partial class FrmBiletSorgula
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
            label2 = new Label();
            txtBiletNo = new TextBox();
            btnSorgula = new Button();
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
            panel1.Size = new Size(463, 40);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 57, 53);
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(423, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 25);
            label1.TabIndex = 1;
            label1.Text = "Bilet Sorgulama Ekranı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 6;
            label2.Text = "BİLET NUMARASI";
            // 
            // txtBiletNo
            // 
            txtBiletNo.BackColor = SystemColors.ScrollBar;
            txtBiletNo.BorderStyle = BorderStyle.FixedSingle;
            txtBiletNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBiletNo.ForeColor = Color.White;
            txtBiletNo.Location = new Point(198, 62);
            txtBiletNo.MaxLength = 10;
            txtBiletNo.Name = "txtBiletNo";
            txtBiletNo.Size = new Size(219, 29);
            txtBiletNo.TabIndex = 7;
            // 
            // btnSorgula
            // 
            btnSorgula.BackColor = Color.Black;
            btnSorgula.FlatAppearance.BorderSize = 0;
            btnSorgula.FlatStyle = FlatStyle.Flat;
            btnSorgula.ForeColor = Color.White;
            btnSorgula.Location = new Point(198, 97);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(219, 40);
            btnSorgula.TabIndex = 8;
            btnSorgula.Text = "SORGULA";
            btnSorgula.UseVisualStyleBackColor = false;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // FrmBiletSorgula
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(463, 167);
            Controls.Add(btnSorgula);
            Controls.Add(txtBiletNo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(750, 400);
            Margin = new Padding(5);
            Name = "FrmBiletSorgula";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletSorgula";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtBiletNo;
        private Button btnSorgula;
    }
}