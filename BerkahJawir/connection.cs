using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BerkahJawir
{
    internal class connection
    {
        // koneksi database
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        static string host = "localhost";
        static string database = "login-new";
        static string UserDB = "root";
        static string password = "";
        public static string strProvider = "server=" + host + ";Database=" + database + "" + ";UserID=" + UserDB + ";Password=" + password;

        public bool Open()
        {
            try
            {
                strProvider = "server=" + host + ";Database=" + database + "" + ";UserID=" + UserDB + ";Password=" + password;
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Connection Error ! " + err.Message, "Information");
            }
            return false;
        }

        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }

        public DataSet? ExceuteDatSet(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public MySqlDataReader? ExecuteReader(string sql)
        {
            try
            {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuary(string sql)
        {
            try
            {
                int affected;
                MySqlTransaction mySqlTransaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mySqlTransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
}
