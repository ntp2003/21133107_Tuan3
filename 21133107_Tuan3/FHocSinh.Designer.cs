namespace _21133107_Tuan3
{
    partial class FHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvHocSinh = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // gvHocSinh
            // 
            this.gvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHocSinh.Location = new System.Drawing.Point(638, 60);
            this.gvHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.gvHocSinh.MultiSelect = false;
            this.gvHocSinh.Name = "gvHocSinh";
            this.gvHocSinh.ReadOnly = true;
            this.gvHocSinh.RowHeadersWidth = 51;
            this.gvHocSinh.RowTemplate.Height = 24;
            this.gvHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHocSinh.Size = new System.Drawing.Size(861, 480);
            this.gvHocSinh.TabIndex = 0;
            this.gvHocSinh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvHocSinh_CellMouseClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 615);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 49);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(214, 615);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 49);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(391, 615);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 49);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(44, 60);
            this.lblMaHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(105, 20);
            this.lblMaHS.TabIndex = 4;
            this.lblMaHS.Text = "Mã học sinh:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(44, 136);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(86, 20);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Họ và tên:";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(44, 220);
            this.lblQueQuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(86, 20);
            this.lblQueQuan.TabIndex = 6;
            this.lblQueQuan.Text = "Quê quán:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(44, 292);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(171, 20);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày tháng năm sinh:";
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Location = new System.Drawing.Point(44, 371);
            this.lblCmnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(65, 20);
            this.lblCmnd.TabIndex = 8;
            this.lblCmnd.Text = "CMND:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 441);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Location = new System.Drawing.Point(44, 512);
            this.lblSdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(111, 20);
            this.lblSdt.TabIndex = 10;
            this.lblSdt.Text = "Số điện thoại:";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(262, 60);
            this.txtMaHS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(343, 26);
            this.txtMaHS.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(262, 136);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(343, 26);
            this.txtTen.TabIndex = 12;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(262, 216);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(343, 26);
            this.txtQueQuan.TabIndex = 13;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(262, 371);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(343, 26);
            this.txtCmnd.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(262, 438);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(343, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(262, 512);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(343, 26);
            this.txtSdt.TabIndex = 16;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(262, 292);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(343, 26);
            this.dtpNgaySinh.TabIndex = 17;
            this.dtpNgaySinh.Value = new System.DateTime(2023, 2, 22, 22, 20, 17, 0);
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 719);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCmnd);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblSdt);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCmnd);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gvHocSinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FHocSinh";
            this.Text = "Quan Ly Hoc Sinh";
            this.Load += new System.EventHandler(this.FHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvHocSinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}