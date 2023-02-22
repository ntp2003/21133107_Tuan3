using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _21133107_Tuan3
{
    public class HocSinhDAO
    {
        DBConnection dbConn = new DBConnection();

        public DataTable LayDanhSachHocSinh()
        {
            string sqlStr = string.Format("SELECT * FROM HocSinh");
            return dbConn.DanhSach(sqlStr);
        }

        public void Them(HocSinh hs)
        {
            string sqlStr = $"INSERT INTO HocSinh VALUES ('{hs.MaHS}', '{hs.Ten}', '{hs.QueQuan}','{hs.NgaySinh}'," +
                                            $"'{hs.Cmnd}','{hs.Email}','{hs.Sdt}')";
            dbConn.ThucHien(sqlStr);
        }

        public void Sua(HocSinh hs)
        {
            string sqlStr = $"UPDATE HocSinh " +
                            $"SET Ten = '{hs.Ten}', QueQuan = '{hs.QueQuan}', NgaySinh = '{hs.NgaySinh}'," +
                            $" Cmnd = '{hs.Cmnd}', Email = '{hs.Email}', Sdt = '{hs.Sdt}' " +
                            $"WHERE MaHS = '{hs.MaHS}'";
            dbConn.ThucHien(sqlStr);
        }

        public void Xoa(HocSinh hs)
        {
            string sqlStr = $"DELETE FROM HocSinh WHERE MaHS = '{hs.MaHS}'";
            dbConn.ThucHien(sqlStr);
        }
    }
}