using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21133107_Tuan3
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public DataTable DanhSach(string sqlStr)
        {
            DataTable dtDanhSach = new DataTable();
            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtDanhSach);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtDanhSach;
        }

        public void ThucHien(string sqlStr)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thuc hien thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc hien that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}