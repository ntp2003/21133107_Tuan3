using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21133107_Tuan3
{
    public class GiaoVien : Person
    {
        private string maGV;

        public GiaoVien(string maGV, string ten, string queQuan, string ngaySinh, string cmnd, string email, string sdt) : base(ten, queQuan, ngaySinh, cmnd, email, sdt)
        {
            this.maGV = maGV;
        }

        public string MaGV
        {
            get => maGV;
        }
    }
}