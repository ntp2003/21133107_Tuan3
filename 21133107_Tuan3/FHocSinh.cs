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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _21133107_Tuan3
{
    public partial class FHocSinh : Form
    {
        HocSinhDAO hsDAO= new HocSinhDAO();

        public FHocSinh()
        {
            InitializeComponent();
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            gvHocSinh.DataSource = hsDAO.LayDanhSachHocSinh();
            gvHocSinh.Columns["MaHS"].HeaderText = "Mã Học Sinh";
            gvHocSinh.Columns["Ten"].HeaderText = "Họ Và Tên";
            gvHocSinh.Columns["QueQuan"].HeaderText = "Quê Quán";
            gvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            gvHocSinh.Columns["Cmnd"].HeaderText = "CMND";
            gvHocSinh.Columns["Email"].HeaderText = "Email";
            gvHocSinh.Columns["Sdt"].HeaderText = "Số Điện Thoại";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ThongTinHopLe())
            {
                HocSinh hocSinh = new HocSinh(txtMaHS.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Text, txtCmnd.Text, txtEmail.Text, txtSdt.Text);

                hsDAO.Them(hocSinh);
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
                HocSinh hocSinh = new HocSinh(txtMaHS.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Text, txtCmnd.Text, txtEmail.Text, txtSdt.Text);

                hsDAO.Sua(hocSinh);
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
                HocSinh hocSinh = new HocSinh(txtMaHS.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Text, txtCmnd.Text, txtEmail.Text, txtSdt.Text);

                hsDAO.Xoa(hocSinh);
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Thong tin khong hop le", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvHocSinh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow rowSelected = gvHocSinh.Rows[gvHocSinh.SelectedCells[0].RowIndex];
            
            txtMaHS.Text = rowSelected.Cells[0].Value.ToString();
            txtTen.Text = rowSelected.Cells[1].Value.ToString();
            txtQueQuan.Text = rowSelected.Cells[2].Value.ToString();
            dtpNgaySinh.Text = rowSelected.Cells[3].Value.ToString();
            txtCmnd.Text = rowSelected.Cells[4].Value.ToString();
            txtEmail.Text = rowSelected.Cells[5].Value.ToString();
            txtSdt.Text = rowSelected.Cells[6].Value.ToString();
        }

        private bool ThongTinHopLe()
        {
            string[] thongTin = new string[7] { txtMaHS.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Text, txtCmnd.Text, txtEmail.Text, txtSdt.Text };

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
