namespace QuanLyNhaHang.Demo_Nhom
{
    partial class frmTrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQlNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíThựcPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNuocUong = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtTiệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHopDongDatTiec = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTraCuuHopDong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHT,
            this.menuQL,
            this.báoCáoToolStripMenuItem,
            this.đặtTiệcToolStripMenuItem,
            this.tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHT
            // 
            this.menuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangNhap,
            this.menuDangXuat,
            this.menuThoat});
            this.menuHT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuHT.ForeColor = System.Drawing.Color.Red;
            this.menuHT.ImageTransparentColor = System.Drawing.Color.White;
            this.menuHT.Name = "menuHT";
            this.menuHT.Size = new System.Drawing.Size(71, 20);
            this.menuHT.Text = "Hệ &Thống";
            this.menuHT.Click += new System.EventHandler(this.menuHT_Click);
            // 
            // menuDangNhap
            // 
            this.menuDangNhap.BackColor = System.Drawing.Color.Lime;
            this.menuDangNhap.Name = "menuDangNhap";
            this.menuDangNhap.Size = new System.Drawing.Size(152, 22);
            this.menuDangNhap.Text = "Đăng &Nhập";
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.BackColor = System.Drawing.Color.Lime;
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(152, 22);
            this.menuDangXuat.Text = "Đăng &Xuất";
            // 
            // menuThoat
            // 
            this.menuThoat.BackColor = System.Drawing.Color.Lime;
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(152, 22);
            this.menuThoat.Text = "Th&oát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // menuQL
            // 
            this.menuQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQlNhanVien,
            this.quảnLíThựcPhẩmToolStripMenuItem,
            this.menuQLNuocUong,
            this.quảnLýKháchHàngToolStripMenuItem});
            this.menuQL.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuQL.ForeColor = System.Drawing.Color.Red;
            this.menuQL.Name = "menuQL";
            this.menuQL.Size = new System.Drawing.Size(65, 20);
            this.menuQL.Text = "&Quản Lý";
            // 
            // menuQlNhanVien
            // 
            this.menuQlNhanVien.BackColor = System.Drawing.Color.Lime;
            this.menuQlNhanVien.Name = "menuQlNhanVien";
            this.menuQlNhanVien.Size = new System.Drawing.Size(184, 22);
            this.menuQlNhanVien.Text = "Q&uản Lý Nhân Viên";
            this.menuQlNhanVien.Click += new System.EventHandler(this.menuQlNhanVien_Click);
            // 
            // quảnLíThựcPhẩmToolStripMenuItem
            // 
            this.quảnLíThựcPhẩmToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.quảnLíThựcPhẩmToolStripMenuItem.Name = "quảnLíThựcPhẩmToolStripMenuItem";
            this.quảnLíThựcPhẩmToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.quảnLíThựcPhẩmToolStripMenuItem.Text = "Quản &Lý Thực Phẩm";
            // 
            // menuQLNuocUong
            // 
            this.menuQLNuocUong.BackColor = System.Drawing.Color.Lime;
            this.menuQLNuocUong.Name = "menuQLNuocUong";
            this.menuQLNuocUong.Size = new System.Drawing.Size(184, 22);
            this.menuQLNuocUong.Text = "Quản L&ý Nước Uống ";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem,
            this.chiPhíToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.báoCáoToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.báoCáoToolStripMenuItem.Text = "&Báo Cáo";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtHóaĐơnToolStripMenuItem,
            this.tìmHóaĐơnToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hó&a Đơn";
            // 
            // xuấtHóaĐơnToolStripMenuItem
            // 
            this.xuấtHóaĐơnToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.xuấtHóaĐơnToolStripMenuItem.Name = "xuấtHóaĐơnToolStripMenuItem";
            this.xuấtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xuấtHóaĐơnToolStripMenuItem.Text = "Xuất Hóa Đơn";
            // 
            // tìmHóaĐơnToolStripMenuItem
            // 
            this.tìmHóaĐơnToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tìmHóaĐơnToolStripMenuItem.Name = "tìmHóaĐơnToolStripMenuItem";
            this.tìmHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tìmHóaĐơnToolStripMenuItem.Text = "Tìm Hóa Đơn";
            // 
            // chiPhíToolStripMenuItem
            // 
            this.chiPhíToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.chiPhíToolStripMenuItem.Name = "chiPhíToolStripMenuItem";
            this.chiPhíToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chiPhíToolStripMenuItem.Text = "Chi &Phí";
            // 
            // đặtTiệcToolStripMenuItem
            // 
            this.đặtTiệcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHopDongDatTiec});
            this.đặtTiệcToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.đặtTiệcToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.đặtTiệcToolStripMenuItem.Name = "đặtTiệcToolStripMenuItem";
            this.đặtTiệcToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.đặtTiệcToolStripMenuItem.Text = "&Đặt Tiệc";
            // 
            // menuHopDongDatTiec
            // 
            this.menuHopDongDatTiec.BackColor = System.Drawing.Color.Lime;
            this.menuHopDongDatTiec.Name = "menuHopDongDatTiec";
            this.menuHopDongDatTiec.Size = new System.Drawing.Size(175, 22);
            this.menuHopDongDatTiec.Text = "&Hợp Đồng Đặt Tiệc";
            this.menuHopDongDatTiec.Click += new System.EventHandler(this.menuHopDongDatTiec_Click);
            // 
            // tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem
            // 
            this.tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTraCuuHopDong,
            this.menuTimKiemNhanVien});
            this.tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem.Name = "tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem";
            this.tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem.Text = "Tìm &Kiêm Hợp Đồng Đã Đặt";
            // 
            // menuTraCuuHopDong
            // 
            this.menuTraCuuHopDong.BackColor = System.Drawing.Color.Lime;
            this.menuTraCuuHopDong.Name = "menuTraCuuHopDong";
            this.menuTraCuuHopDong.Size = new System.Drawing.Size(188, 22);
            this.menuTraCuuHopDong.Text = "T&ra Cứu Hợp Đồng";
            this.menuTraCuuHopDong.Click += new System.EventHandler(this.menuTraCuuHopDong_Click);
            // 
            // menuTimKiemNhanVien
            // 
            this.menuTimKiemNhanVien.BackColor = System.Drawing.Color.Lime;
            this.menuTimKiemNhanVien.Name = "menuTimKiemNhanVien";
            this.menuTimKiemNhanVien.Size = new System.Drawing.Size(188, 22);
            this.menuTimKiemNhanVien.Text = "Tìm K&iếm Nhân Viên";
            this.menuTimKiemNhanVien.Click += new System.EventHandler(this.menuTimKiemNhanVien_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thôngTinToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.thôngTinToolStripMenuItem.Text = "Thôn&g Tin";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            this.quảnLýKháchHàngToolStripMenuItem.BackColorChanged += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_BackColorChanged);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 510);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
                " Giao Diện Chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHT;
        private System.Windows.Forms.ToolStripMenuItem menuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuQL;
        private System.Windows.Forms.ToolStripMenuItem menuQlNhanVien;
        private System.Windows.Forms.ToolStripMenuItem quảnLíThựcPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuQLNuocUong;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtTiệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHopDongDatTiec;
        private System.Windows.Forms.ToolStripMenuItem tìmKiêmHợpĐồngĐãĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTraCuuHopDong;
        private System.Windows.Forms.ToolStripMenuItem xuấtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuTimKiemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
    }
}