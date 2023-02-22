using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21133107_Tuan3
{
    public abstract class Person
    { 
        protected string ten;
        protected string queQuan;
        protected string ngaySinh;
        protected string cmnd;
        protected string email;
        protected string sdt;

        public Person(string ten, string queQuan, string ngaySinh, string cmnd, string email, string sdt)
        {
            this.ten = ten;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh;
            this.cmnd = cmnd;
            this.email = email;
            this.sdt = sdt;
        }

        public string Ten
        {
            get => ten;
        }

        public string QueQuan
        {
            get => queQuan;
        }

        public string NgaySinh
        {
            get => ngaySinh;
        }

        public string Cmnd
        {
            get => cmnd;
        }

        public string Email
        {
            get => email;
        }

        public string Sdt
        {
            get => sdt;
        }
    }
}