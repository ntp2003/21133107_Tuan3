using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21133107_Tuan3
{
    public partial class FGiaoVien : Form
    {
        GiaoVienDAO gvDAO = new GiaoVienDAO();

        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            gvGiaoVien.DataSource = gvDAO.LayDanhSachGiaoVien();
            gvGiaoVien.Columns["MaGV"].HeaderText = "Mã Giáo Viên";
            gvGiaoVien.Columns["Ten"].HeaderText = "Họ Và Tên";
            gvGiaoVien.Columns["QueQuan"].HeaderText = "Quê Quán";
            gvGiaoVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            gvGiaoVien.Columns["Cmnd"].HeaderText = "CMND";
            gvGiaoVien.Columns["Email"].HeaderText = "Email";
            gvGiaoVien.Columns["Sdt"].HeaderText = "Số Điện Thoại";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ThongTinHopLe())
            {
                GiaoVien giaoVien = new GiaoVien(txtMaGV.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Text, txtCmnd.Text, txtEmail.Text, txtSdt.Text);

                gvDAO.Them(giaoVien);
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Thong tin khong hop le", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ThongTinHopLe())
            {
                GiaoVien giaoVien = new GiaoVien(txtMaGV.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Text, txtCmnd.Text, txtEmail.Text, txtSdt.Text);

                gvDAO.Sua(giaoVien);
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Thong tin khong hop le", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ThongTinHopLe())
            {
                GiaoVien giaoVien = new GiaoVien(txtMaGV.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Text, txtCmnd.Text, txtEmail.Text, txtSdt.Text);

                gvDAO.Xoa(giaoVien);
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Thong tin khong hop le", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvGiaoVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rowSelected = gvGiaoVien.Rows[gvGiaoVien.SelectedCells[0].RowIndex];

            txtMaGV.Text = rowSelected.Cells[0].Value.ToString();
            txtTen.Text = rowSelected.Cells[1].Value.ToString();
            txtQueQuan.Text = rowSelected.Cells[2].Value.ToString();
            dtpNgaySinh.Text = rowSelected.Cells[3].Value.ToString();
            txtCmnd.Text = rowSelected.Cells[4].Value.ToString();
            txtEmail.Text = rowSelected.Cells[5].Value.ToString();
            txtSdt.Text = rowSelected.Cells[6].Value.ToString();
        }

        private bool ThongTinHopLe()
        {
            string[] thongTin = new string[7] { txtMaGV.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Text, txtCmnd.Text, txtEmail.Text, txtSdt.Text };

            foreach (string item in thongTin)
            {
                if (string.IsNullOrEmpty(item))
                {
                    return false;
                }
            }
            try
            {
                MailAddress m = new MailAddress(txtEmail.Text);
            }
            catch (FormatException)
            {
                return false;
            }
            return Regex.IsMatch(txtSdt.Text, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
        }
    }
}
