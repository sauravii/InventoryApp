using MySql.Data.MySqlClient;
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
    public partial class btn_save2 : Form
    {
        public btn_save2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // codingan untuk button refresh
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                // sambung database
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=login-new";
                string Query = "select id,namaProduk,hargaProduk, stokProduk from dataproduk";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                da.Fill(dTable);
                dataGridView1.DataSource = dTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // codingan untuk button save
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=login-new";
                MemoryStream ms = new MemoryStream();
                string Query = "insert into dataproduk(id,namaProduk,hargaProduk,stokProduk) values('" + this.tb_id.Text + "','" + this.tb_nama.Text + "','" + this.tb_harga.Text + "','" + this.tb_stok.Text + "');";

                MySqlConnection con = new MySqlConnection(MyConnection2);

                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = cmd.ExecuteReader();     // Save query

                MessageBox.Show("Data tersimpan!");


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_nama.ResetText();
                tb_harga.ResetText();
                tb_stok.ResetText();
            }
        }

        // codingan button delete
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=login-new";

                MySqlConnection con = new MySqlConnection(MyConnection2);
                string sql = "DELETE from dataproduk WHERE id='" + this.tb_id.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Data telah dihapus");
                while (dr.Read())
                {

                }
                con.Close();
            }
            catch (NullReferenceException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // codingan btn edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=login-new";

                MySqlConnection con = new MySqlConnection(MyConnection2);
                string sql = "UPDATE dataproduk set namaProduk='" + this.tb_nama.Text + "',hargaProduk='" + this.tb_harga.Text + "',stokProduk='" + this.tb_stok.Text + "' WHERE id='" + this.tb_id.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (dr.Read())
                {

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_nama.ResetText();
                tb_harga.ResetText();
                tb_stok.ResetText();

            }
        }

        // codingan buttin exit
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=login-new";
                MemoryStream ms = new MemoryStream();
                string Query = "insert into dataproduk(id,namaProduk,hargaProduk,stokProduk) values('" + this.tb_id.Text + "','" + this.tb_nama.Text + "','" + this.tb_harga.Text + "','" + this.tb_stok.Text + "');";

                MySqlConnection con = new MySqlConnection(MyConnection2);

                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = cmd.ExecuteReader();     // Save query

                MessageBox.Show("Data tersimpan!");


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tb_nama.ResetText();
                tb_harga.ResetText();
                tb_stok.ResetText();
            }
        }
    }
}
