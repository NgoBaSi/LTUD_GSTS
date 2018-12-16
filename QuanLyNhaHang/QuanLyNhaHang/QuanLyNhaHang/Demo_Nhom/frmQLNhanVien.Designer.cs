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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.grbHienThiThongTinNV = new System.Windows.Forms.GroupBox();
            this.dataHienThi = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaHangTiecCuoiDataSet = new QuanLyNhaHang.QLNhaHangTiecCuoiDataSet();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat1 = new System.Windows.Forms.Button();
            this.spLayDSNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_LayDSNhanVienTableAdapter = new QuanLyNhaHang.QLNhaHangTiecCuoiDataSetTableAdapters.sp_LayDSNhanVienTableAdapter();
            this.nhanVienTableAdapter = new QuanLyNhaHang.QLNhaHangTiecCuoiDataSetTableAdapters.NhanVienTableAdapter();
            this.grbThongTinNhanVien.SuspendLayout();
            this.grbHienThiThongTinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangTiecCuoiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLayDSNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // grbThongTinNhanVien
            // 
            this.grbThongTinNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.grbThongTinNhanVien.Controls.Add(this.btnXoa);
            this.grbThongTinNhanVien.Controls.Add(this.btnSua);
            this.grbThongTinNhanVien.Controls.Add(this.txtGhiChu);
            this.grbThongTinNhanVien.Controls.Add(this.txtLuong);
            this.grbThongTinNhanVien.Controls.Add(this.txtChucVu);
            this.grbThongTinNhanVien.Controls.Add(this.txtGioiTinh);
            this.grbThongTinNhanVien.Controls.Add(this.txtDC);
            this.grbThongTinNhanVien.Controls.Add(this.btnThem);
            this.grbThongTinNhanVien.Controls.Add(this.txtTenNV);
            this.grbThongTinNhanVien.Controls.Add(this.txtSDT);
            this.grbThongTinNhanVien.Controls.Add(this.lblGhiChu);
            this.grbThongTinNhanVien.Controls.Add(this.lblDiaChi);
            this.grbThongTinNhanVien.Controls.Add(this.lblLuong);
            this.grbThongTinNhanVien.Controls.Add(this.lblTenNV);
            this.grbThongTinNhanVien.Controls.Add(this.lblChucVu);
            this.grbThongTinNhanVien.Controls.Add(this.lblSDT);
            this.grbThongTinNhanVien.Controls.Add(this.lblGioiTinh);
            this.grbThongTinNhanVien.Controls.Add(this.txtMaNV);
            this.grbThongTinNhanVien.Controls.Add(this.lblMaNV);
            this.grbThongTinNhanVien.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTinNhanVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grbThongTinNhanVien.Location = new System.Drawing.Point(1, 41);
            this.grbThongTinNhanVien.Name = "grbThongTinNhanVien";
            this.grbThongTinNhanVien.Size = new System.Drawing.Size(859, 186);
            this.grbThongTinNhanVien.TabIndex = 1;
            this.grbThongTinNhanVien.TabStop = false;
            this.grbThongTinNhanVien.Text = "Thông Tin Nhân Viên";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Lime;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.ImageKey = "(none)";
            this.btnXoa.Location = new System.Drawing.Point(773, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Lime;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.ImageKey = "(none)";
            this.btnSua.Location = new System.Drawing.Point(773, 79);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 35);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.AutoCompleteCustomSource.AddRange(new string[] {
            "Tốt",
            "Bình Thường",
            "Yếu"});
            this.txtGhiChu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGhiChu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhiChu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGhiChu.Location = new System.Drawing.Point(520, 153);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(216, 23);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtLuong
            // 
            this.txtLuong.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.txtLuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLuong.Location = new System.Drawing.Point(520, 111);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(216, 23);
            this.txtLuong.TabIndex = 8;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChucVu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtChucVu.Location = new System.Drawing.Point(520, 70);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(216, 23);
            this.txtChucVu.TabIndex = 7;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGioiTinh.Location = new System.Drawing.Point(520, 27);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(216, 23);
            this.txtGioiTinh.TabIndex = 6;
            // 
            // txtDC
            // 
            this.txtDC.AutoCompleteCustomSource.AddRange(new string[] {
            "123 VVN Thu Duc",
            "456 Binh Duong",
            "789 Vung Tau"});
            this.txtDC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDC.Location = new System.Drawing.Point(151, 111);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(216, 23);
            this.txtDC.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Lime;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.ImageKey = "(none)";
            this.btnThem.Location = new System.Drawing.Point(773, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 35);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.txtTenNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenNV.Location = new System.Drawing.Point(151, 70);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(216, 23);
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
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSDT.Location = new System.Drawing.Point(151, 152);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(216, 23);
            this.txtSDT.TabIndex = 3;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGhiChu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGhiChu.Location = new System.Drawing.Point(431, 156);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(60, 16);
            this.lblGhiChu.TabIndex = 9;
            this.lblGhiChu.Text = "Ghi Chú:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiaChi.Location = new System.Drawing.Point(11, 156);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 16);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa Chỉ:";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLuong.Location = new System.Drawing.Point(431, 114);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(53, 16);
            this.lblLuong.TabIndex = 7;
            this.lblLuong.Text = "Lương:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTenNV.Location = new System.Drawing.Point(11, 73);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(104, 16);
            this.lblTenNV.TabIndex = 6;
            this.lblTenNV.Text = "Tên Nhân Viên:";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChucVu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChucVu.Location = new System.Drawing.Point(431, 73);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(66, 16);
            this.lblChucVu.TabIndex = 5;
            this.lblChucVu.Text = "Chức Vụ:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSDT.Location = new System.Drawing.Point(11, 114);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(50, 16);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số ĐT:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGioiTinh.Location = new System.Drawing.Point(429, 30);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(65, 16);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.txtMaNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaNV.Location = new System.Drawing.Point(151, 27);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(216, 23);
            this.txtMaNV.TabIndex = 2;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaNV.Location = new System.Drawing.Point(11, 30);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(100, 16);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // grbHienThiThongTinNV
            // 
            this.grbHienThiThongTinNV.BackColor = System.Drawing.Color.Transparent;
            this.grbHienThiThongTinNV.Controls.Add(this.dataHienThi);
            this.grbHienThiThongTinNV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbHienThiThongTinNV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grbHienThiThongTinNV.Location = new System.Drawing.Point(1, 233);
            this.grbHienThiThongTinNV.Name = "grbHienThiThongTinNV";
            this.grbHienThiThongTinNV.Size = new System.Drawing.Size(859, 180);
            this.grbHienThiThongTinNV.TabIndex = 13;
            this.grbHienThiThongTinNV.TabStop = false;
            this.grbHienThiThongTinNV.Text = "Hiển Thị Thông Tin Nhân Viên";
            // 
            // dataHienThi
            // 
            this.dataHienThi.AllowUserToOrderColumns = true;
            this.dataHienThi.AutoGenerateColumns = false;
            this.dataHienThi.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.luongDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dataHienThi.DataSource = this.nhanVienBindingSource;
            this.dataHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHienThi.Location = new System.Drawing.Point(3, 19);
            this.dataHienThi.Name = "dataHienThi";
            this.dataHienThi.Size = new System.Drawing.Size(853, 158);
            this.dataHienThi.TabIndex = 14;
            this.dataHienThi.Click += new System.EventHandler(this.dataHienThi_Click_1);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            // 
            // luongDataGridViewTextBoxColumn
            // 
            this.luongDataGridViewTextBoxColumn.DataPropertyName = "Luong";
            this.luongDataGridViewTextBoxColumn.HeaderText = "Luong";
            this.luongDataGridViewTextBoxColumn.Name = "luongDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLNhaHangTiecCuoiDataSet;
            // 
            // qLNhaHangTiecCuoiDataSet
            // 
            this.qLNhaHangTiecCuoiDataSet.DataSetName = "QLNhaHangTiecCuoiDataSet";
            this.qLNhaHangTiecCuoiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.Lime;
            this.btnTimkiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Red;
            this.btnTimkiem.ImageKey = "(none)";
            this.btnTimkiem.Location = new System.Drawing.Point(377, 419);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(97, 36);
            this.btnTimkiem.TabIndex = 15;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Lime;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.ImageKey = "(none)";
            this.btnLuu.Location = new System.Drawing.Point(499, 419);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 36);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.UseVisualStyleBackColor = false;
            //this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Lime;
            this.btnLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Red;
            this.btnLamMoi.ImageKey = "(none)";
            this.btnLamMoi.Location = new System.Drawing.Point(629, 419);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(93, 36);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThoat1
            // 
            this.btnThoat1.BackColor = System.Drawing.Color.Lime;
            this.btnThoat1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat1.ForeColor = System.Drawing.Color.Red;
            this.btnThoat1.ImageKey = "(none)";
            this.btnThoat1.Location = new System.Drawing.Point(763, 419);
            this.btnThoat1.Name = "btnThoat1";
            this.btnThoat1.Size = new System.Drawing.Size(73, 36);
            this.btnThoat1.TabIndex = 18;
            this.btnThoat1.Text = "Thoát";
            this.btnThoat1.UseVisualStyleBackColor = false;
            this.btnThoat1.Click += new System.EventHandler(this.btnThoat1_Click);
            // 
            // spLayDSNhanVienBindingSource
            // 
            this.spLayDSNhanVienBindingSource.DataMember = "sp_LayDSNhanVien";
            this.spLayDSNhanVienBindingSource.DataSource = this.qLNhaHangTiecCuoiDataSet;
            // 
            // sp_LayDSNhanVienTableAdapter
            // 
            this.sp_LayDSNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 468);
            this.Controls.Add(this.btnThoat1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.grbHienThiThongTinNV);
            this.Controls.Add(this.grbThongTinNhanVien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            this.grbThongTinNhanVien.ResumeLayout(false);
            this.grbThongTinNhanVien.PerformLayout();
            this.grbHienThiThongTinNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaHangTiecCuoiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLayDSNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTinNhanVien;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grbHienThiThongTinNV;
        private System.Windows.Forms.DataGridView dataHienThi;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat1;
        
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private QLNhaHangTiecCuoiDataSet qLNhaHangTiecCuoiDataSet;
        private System.Windows.Forms.BindingSource spLayDSNhanVienBindingSource;
        private QLNhaHangTiecCuoiDataSetTableAdapters.sp_LayDSNhanVienTableAdapter sp_LayDSNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLNhaHangTiecCuoiDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;

    }
}