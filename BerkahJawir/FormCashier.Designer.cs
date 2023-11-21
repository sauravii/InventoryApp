namespace BerkahJawir
{
    partial class FormCashier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_barang = new System.Windows.Forms.ComboBox();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.tb_jumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ttlHarga = new System.Windows.Forms.TextBox();
            this.tb_ttlBayar = new System.Windows.Forms.TextBox();
            this.tb_kembalian = new System.Windows.Forms.TextBox();
            this.btn_bayar = new System.Windows.Forms.Button();
            this.btn_ttlKembali = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(306, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "TB. BERKAH JAWIR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah";
            // 
            // cb_barang
            // 
            this.cb_barang.FormattingEnabled = true;
            this.cb_barang.Items.AddRange(new object[] {
            "Semen",
            "Paku",
            "Cat",
            "Kawat",
            "Seng"});
            this.cb_barang.Location = new System.Drawing.Point(194, 125);
            this.cb_barang.Name = "cb_barang";
            this.cb_barang.Size = new System.Drawing.Size(207, 33);
            this.cb_barang.TabIndex = 4;
            this.cb_barang.SelectedIndexChanged += new System.EventHandler(this.cb_barang_SelectedIndexChanged);
            // 
            // tb_harga
            // 
            this.tb_harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_harga.Location = new System.Drawing.Point(194, 180);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(207, 31);
            this.tb_harga.TabIndex = 5;
            // 
            // tb_jumlah
            // 
            this.tb_jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_jumlah.Location = new System.Drawing.Point(194, 234);
            this.tb_jumlah.Name = "tb_jumlah";
            this.tb_jumlah.Size = new System.Drawing.Size(207, 31);
            this.tb_jumlah.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Bayar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kembalian";
            // 
            // tb_ttlHarga
            // 
            this.tb_ttlHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ttlHarga.Location = new System.Drawing.Point(612, 125);
            this.tb_ttlHarga.Name = "tb_ttlHarga";
            this.tb_ttlHarga.Size = new System.Drawing.Size(228, 31);
            this.tb_ttlHarga.TabIndex = 10;
            // 
            // tb_ttlBayar
            // 
            this.tb_ttlBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ttlBayar.Location = new System.Drawing.Point(612, 180);
            this.tb_ttlBayar.Name = "tb_ttlBayar";
            this.tb_ttlBayar.Size = new System.Drawing.Size(228, 31);
            this.tb_ttlBayar.TabIndex = 11;
            // 
            // tb_kembalian
            // 
            this.tb_kembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_kembalian.Location = new System.Drawing.Point(612, 234);
            this.tb_kembalian.Name = "tb_kembalian";
            this.tb_kembalian.Size = new System.Drawing.Size(228, 31);
            this.tb_kembalian.TabIndex = 12;
            // 
            // btn_bayar
            // 
            this.btn_bayar.BackColor = System.Drawing.Color.Coral;
            this.btn_bayar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bayar.Location = new System.Drawing.Point(194, 292);
            this.btn_bayar.Name = "btn_bayar";
            this.btn_bayar.Size = new System.Drawing.Size(132, 46);
            this.btn_bayar.TabIndex = 13;
            this.btn_bayar.Text = "BAYAR";
            this.btn_bayar.UseVisualStyleBackColor = false;
            this.btn_bayar.Click += new System.EventHandler(this.btn_bayar_Click);
            // 
            // btn_ttlKembali
            // 
            this.btn_ttlKembali.BackColor = System.Drawing.Color.Coral;
            this.btn_ttlKembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ttlKembali.Location = new System.Drawing.Point(612, 292);
            this.btn_ttlKembali.Name = "btn_ttlKembali";
            this.btn_ttlKembali.Size = new System.Drawing.Size(132, 46);
            this.btn_ttlKembali.TabIndex = 14;
            this.btn_ttlKembali.Text = "TOTAL";
            this.btn_ttlKembali.UseVisualStyleBackColor = false;
            this.btn_ttlKembali.Click += new System.EventHandler(this.btn_ttlKembali_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(68, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Gambar Produk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 156);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Turquoise;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.Location = new System.Drawing.Point(424, 420);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(132, 43);
            this.btn_refresh.TabIndex = 17;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Orchid;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(612, 420);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(132, 43);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 642);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_ttlKembali);
            this.Controls.Add(this.btn_bayar);
            this.Controls.Add(this.tb_kembalian);
            this.Controls.Add(this.tb_ttlBayar);
            this.Controls.Add(this.tb_ttlHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_jumlah);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.cb_barang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCashier";
            this.Text = "FormCashier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cb_barang;
        private TextBox tb_harga;
        private TextBox tb_jumlah;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_ttlHarga;
        private TextBox tb_ttlBayar;
        private TextBox tb_kembalian;
        private Button btn_bayar;
        private Button btn_ttlKembali;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btn_refresh;
        private Button btn_exit;
    }
}