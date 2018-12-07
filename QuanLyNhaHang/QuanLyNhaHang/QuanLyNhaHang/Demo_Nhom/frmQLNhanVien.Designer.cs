namespace QuanLyNhaHang.Demo_Nhom
{
    partial class frmQLNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtNLMK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataHienThi = new System.Windows.Forms.DataGridView();
            this.qLiNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaHangDataSet = new QuanLyNhaHang.QuanLyNhaHangDataSet();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.qLiNhanVienTableAdapter = new QuanLyNhaHang.QuanLyNhaHangDataSetTableAdapters.QLiNhanVienTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLiNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaHangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(186, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "                   Quản Lý Nhân Viên\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.txtCV);
            this.groupBox1.Controls.Add(this.txtNLMK);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageKey = "(none)";
            this.btnXoa.Location = new System.Drawing.Point(770, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.ImageKey = "(none)";
            this.btnSua.Location = new System.Drawing.Point(770, 67);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 35);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.AutoCompleteCustomSource.AddRange(new string[] {
            "Tốt",
            "Bình Thường",
            "Yếu"});
            this.txtTrangThai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTrangThai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTrangThai.Location = new System.Drawing.Point(530, 125);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(216, 27);
            this.txtTrangThai.TabIndex = 9;
            // 
            // txtCV
            // 
            this.txtCV.AutoCompleteCustomSource.AddRange(new string[] {
            "Nhân Viên Văn Phòng",
            "Quản Lí",
            "Giám Đốc",
            "Phó Giám Đốc",
            "Thư Kí",
            "Giám Sát",
            "Trợ Lí Giám Sát",
            "Nhân Viên Phục Vụ",
            "Nhân Viên Trang Trí",
            "Nhân Viên Đầu Bếp",
            "Nhân Viên Vận Chuyển",
            "Nhân Viên Hướng Dẫn ",
            "Nhân Viên Bảo Vệ ",
            "Nhân Viên Kế Toán",
            "Nhân Viên Tư Vấn",
            "......"});
            this.txtCV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCV.Location = new System.Drawing.Point(530, 92);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(216, 27);
            this.txtCV.TabIndex = 8;
            // 
            // txtNLMK
            // 
            this.txtNLMK.Location = new System.Drawing.Point(530, 59);
            this.txtNLMK.Name = "txtNLMK";
            this.txtNLMK.PasswordChar = '*';
            this.txtNLMK.Size = new System.Drawing.Size(216, 27);
            this.txtNLMK.TabIndex = 7;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(530, 26);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(216, 27);
            this.txtMK.TabIndex = 6;
            // 
            // txtDC
            // 
            this.txtDC.AutoCompleteCustomSource.AddRange(new string[] {
            "123 VVN Thu Duc",
            "456 Binh Duong",
            "789 Vung Tau"});
            this.txtDC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDC.Location = new System.Drawing.Point(151, 126);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(216, 27);
            this.txtDC.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.ImageKey = "(none)";
            this.btnThem.Location = new System.Drawing.Point(770, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 35);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
           
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoCompleteCustomSource.AddRange(new string[] {
            "Nguyễn Văn A",
            "Nguyễn Minh B",
            "Nguyễn Thị C",
            "Trần Văn A",
            "Bùi Minh C",
            "Lê Văn A"});
            this.txtTenNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTenNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenNV.Location = new System.Drawing.Point(151, 93);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(216, 27);
            this.txtTenNV.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoCompleteCustomSource.AddRange(new string[] {
            "0123456789",
            "01202154174",
            "032155",
            "015544",
            "0166554",
            "01245",
            "032146"});
            this.txtSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSDT.Location = new System.Drawing.Point(151, 59);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(216, 27);
            this.txtSDT.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Trạng Thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chức Vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Nhân Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhập Lại MK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số ĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu:";
            // 
            // txtTK
            // 
            this.txtTK.AutoCompleteCustomSource.AddRange(new string[] {
            "NV001",
            "NV002",
            "NV003",
            "NV004",
            "NV005",
            "NV006",
            "NV188",
            "GS001",
            "GĐ001",
            "PGĐ001",
            "TK001",
            "TLGS001"});
            this.txtTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTK.Location = new System.Drawing.Point(151, 27);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(216, 27);
            this.txtTK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản:\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataHienThi);
            this.groupBox2.Location = new System.Drawing.Point(1, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 167);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển Thị Thông Tin Nhân Viên";
            // 
            // dataHienThi
            // 
            this.dataHienThi.AllowUserToAddRows = false;
            this.dataHienThi.AllowUserToDeleteRows = false;
            this.dataHienThi.AutoGenerateColumns = false;
            this.dataHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenNV,
            this.TaiKhoan,
            this.MatKhau,
            this.NLMatKhau,
            this.SDT,
            this.DiaChi,
            this.ChucVu,
            this.TrangThai});
            this.dataHienThi.DataSource = this.qLiNhanVienBindingSource;
            this.dataHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHienThi.Location = new System.Drawing.Point(3, 23);
            this.dataHienThi.Name = "dataHienThi";
            this.dataHienThi.ReadOnly = true;
            this.dataHienThi.Size = new System.Drawing.Size(843, 141);
            this.dataHienThi.TabIndex = 14;
            // 
            // qLiNhanVienBindingSource
            // 
            this.qLiNhanVienBindingSource.DataMember = "QLiNhanVien";
            this.qLiNhanVienBindingSource.DataSource = this.quanLyNhaHangDataSet;
            // 
            // quanLyNhaHangDataSet
            // 
            this.quanLyNhaHangDataSet.DataSetName = "QuanLyNhaHangDataSet";
            this.quanLyNhaHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.ImageKey = "(none)";
            this.btnTimkiem.Location = new System.Drawing.Point(4, 430);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(97, 35);
            this.btnTimkiem.TabIndex = 15;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageKey = "(none)";
            this.btnLuu.Location = new System.Drawing.Point(126, 430);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 35);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageKey = "(none)";
            this.btnLamMoi.Location = new System.Drawing.Point(256, 430);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(93, 35);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThoat1
            // 
            this.btnThoat1.ImageKey = "(none)";
            this.btnThoat1.Location = new System.Drawing.Point(390, 430);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(73, 35);
            this.btnThoat1.TabIndex = 18;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.UseVisualStyleBackColor = true;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // qLiNhanVienTableAdapter
            // 
            this.qLiNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "TenNV";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "TaiKhoan";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // NLMatKhau
            // 
            this.NLMatKhau.DataPropertyName = "NLMatKhau";
            this.NLMatKhau.HeaderText = "NLMatKhau";
            this.NLMatKhau.Name = "NLMatKhau";
            this.NLMatKhau.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 468);
            this.Controls.Add(this.btnThoat1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
                "                                        Quản Lý Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLiNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaHangDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtNLMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataHienThi;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat1;
        private QuanLyNhaHangDataSet quanLyNhaHangDataSet;
        private System.Windows.Forms.BindingSource qLiNhanVienBindingSource;
        private QuanLyNhaHangDataSetTableAdapters.QLiNhanVienTableAdapter qLiNhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}