using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;

namespace _21133107_Tuan3
{
    public class GiaoVienDAO
    {
        DBConnection dbConn = new DBConnection();

        public DataTable LayDanhSachGiaoVien()
        {
            string sqlStr = string.Format("SELECT * FROM GiaoVien");
            return dbConn.DanhSach(sqlStr);
        }

        public void Them(GiaoVien gv)
        {
            string sqlStr = $"INSERT INTO GiaoVien VALUES ('{gv.MaGV}', '{gv.Ten}', '{gv.QueQuan}','{gv.NgaySinh}'," +
                                            $"'{gv.Cmnd}','{gv.Email}','{gv.Sdt}')";
            dbConn.ThucHien(sqlStr);
        }

        public void Sua(GiaoVien gv)
        {
            string sqlStr = $"UPDATE GiaoVien " +
                            $"SET Ten = '{gv.Ten}', QueQuan = '{gv.QueQuan}', NgaySinh = '{gv.NgaySinh}'," +
                            $" Cmnd = '{gv.Cmnd}', Email = '{gv.Email}', Sdt = '{gv.Sdt}' " +
                            $"WHERE MaGV = '{gv.MaGV}'";
            dbConn.ThucHien(sqlStr);
        }

        public void Xoa(GiaoVien gv)
        {
            string sqlStr = $"DELETE FROM GiaoVien WHERE MaGV = '{gv.MaGV}'";
            dbConn.ThucHien(sqlStr);
        }
    }
}