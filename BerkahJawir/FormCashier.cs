using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkahJawir
{
    public partial class FormCashier : Form
    {
        public FormCashier()
        {
            InitializeComponent();
        }

        private void cb_barang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_barang.SelectedIndex == 0)
            {
                cb_barang.Text = "Semen";
                tb_harga.Text = "50000";
                pictureBox1.Image = Image.FromFile(@"D:\XI\SMT 2\KK3\Dokumentasi\semen.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            else if (cb_barang.SelectedIndex == 1)
            {
                cb_barang.Text = "Paku";
                tb_harga.Text = "20000";
                pictureBox1.Image = Image.FromFile(@"D:\XI\SMT 2\KK3\Dokumentasi\paku.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            else if (cb_barang.SelectedIndex == 2)
            {
                cb_barang.Text = "Cat";
                tb_harga.Text = "80000";
                pictureBox1.Image = Image.FromFile(@"D:\XI\SMT 2\KK3\Dokumentasi\cat.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            else if (cb_barang.SelectedIndex == 3)
            {
                cb_barang.Text = "Kawat";
                tb_harga.Text = "45000";
                pictureBox1.Image = Image.FromFile(@"D:\XI\SMT 2\KK3\Dokumentasi\kawat.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            else if (cb_barang.SelectedIndex == 4)
            {
                cb_barang.Text = "Seng";
                tb_harga.Text = "120000";
                pictureBox1.Image = Image.FromFile(@"D:\XI\SMT 2\KK3\Dokumentasi\seng.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void btn_bayar_Click(object sender, EventArgs e)
        {
            int harga, jumlah;
            harga = int.Parse(tb_harga.Text);
            jumlah = int.Parse(tb_jumlah.Text);

            int result = harga * jumlah;
            tb_ttlHarga.Text = result.ToString();
        }

        private void btn_ttlKembali_Click(object sender, EventArgs e)
        {
            int ttlHarga, ttlBayar;
            ttlHarga = int.Parse(tb_ttlHarga.Text);
            ttlBayar = int.Parse(tb_ttlBayar.Text);

            int hasil = ttlBayar - ttlHarga;
            tb_kembalian.Text = hasil.ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cb_barang.ResetText();
            tb_harga.ResetText();
            tb_jumlah.ResetText();
            tb_ttlHarga.ResetText();
            tb_ttlBayar.ResetText();
            tb_kembalian.ResetText();
            pictureBox1.Image = null;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
