using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21133107_Tuan3
{
    public class HocSinh : Person
    {
        private string maHS;

        public HocSinh(string maHS, string ten, string queQuan, string ngaySinh, string cmnd, string email, string sdt) : base(ten, queQuan, ngaySinh, cmnd, email, sdt)
        {
            this.maHS = maHS;
        }

        public string MaHS
        {
            get => maHS;
        }
    }
}