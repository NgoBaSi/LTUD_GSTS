using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhaHang.Demo_Nhom
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        //Hàm Thông báo kiểm tra bạn có muốn thoát hay không
        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show(" Bạn có chắc chắn muốn thoát?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Hàm thoát
        private void menuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Hàm Chuyển sang form Quản Lý Nhân viên
        private void menuQlNhanVien_Click(object sender, EventArgs e)
        {
            //Biến kiểm tra form có tồn tại hay không
            bool isExist = false;

            //Kiểm tra form Quản lý nhân viên đã tồn tại hay chưa
            //lập qua tất cả các form con this(cha)
            foreach (Form frmchildForm in this.MdiChildren)
            {
                if (frmchildForm.Name == "frmQLNhanVien")
                {
                    frmchildForm.Activate();
                    isExist = true;
                }
            }

            if (!isExist)
            {
                //Hiển Thị form Quản lý nhân viên
                frmQLNhanVien frmNV = new frmQLNhanVien();

                //Đặt form hiện tại là form cha
                frmNV.MdiParent = this;

                frmNV.Show();
            }
        }

        //Hàm chuyển sang form Hợp đồng đặt tiệc
        private void menuHopDongDatTiec_Click(object sender, EventArgs e)
        {
            //Biến kiểm tra form có tồn tại hay không
            bool isExist = false;

            //Kiểm tra form Hợp đồng đặt tiệc đã tồn tại hay chưa
            //lập qua tất cả các form con this(cha)
            foreach (Form frmchildForm in this.MdiChildren)
            {
                if (frmchildForm.Name == "frmHopDongDatTiec")
                {
                    frmchildForm.Activate();
                    isExist = true;
                }
            }

            if (!isExist)
            {
                //Hiển Thị form Hợp Đồng đặt tiệc
                frmHopDongDatTiec frmHopDongDatTiec = new frmHopDongDatTiec();

                //Đặt form hiện tại là form cha
                frmHopDongDatTiec.MdiParent = this;

                frmHopDongDatTiec.Show();
            }
            //frmHopDongDatTiec frmHopDongDatTiec = new frmHopDongDatTiec();
            //this.Hide();
            //frmHopDongDatTiec.ShowDialog();
            //this.Show();
        }

        //Hàm chuyển sang form tra cứu hợp đồng(tìm kiếm hợp đồng)
        private void menuTraCuuHopDong_Click(object sender, EventArgs e)
        {
            //Biến kiểm tra form có tồn tại hay không
            bool isExist = false;

            //Kiểm tra form Tra cứu Hợp đồng đặt tiệc đã tồn tại hay chưa
            //lập qua tất cả các form con this(cha)
            foreach (Form frmchildForm in this.MdiChildren)
            {
                if (frmchildForm.Name == "frmTraCuuHopDong")
                {
                    frmchildForm.Activate();
                    isExist = true;
                }
            }

            if (!isExist)
            {
                //Hiển Thị form Tra cứu Hợp Đồng đặt tiệc
                frmTraCuuHopDong frmTraCuuHopDong = new frmTraCuuHopDong();

                //Đặt form hiện tại là form cha
                frmTraCuuHopDong.MdiParent = this;

                frmTraCuuHopDong.Show();
            }
        }

        //Hàm chuyển sang form tìm kiếm Nhân viên
        private void menuTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            //Biến kiểm tra form có tồn tại hay không
            bool isExist = false;

            //Kiểm tra form Tìm kiếm nhân viên đã tồn tại hay chưa
            //lập qua tất cả các form con this(cha)
            foreach (Form frmchildForm in this.MdiChildren)
            {
                if (frmchildForm.Name == "frmTimKiemNhanVien")
                {
                    frmchildForm.Activate();
                    isExist = true;
                }
            }

            if (!isExist)
            {
                //Hiển Thị form Tìm kiếm nhân viên
                frmTimKiemNhanVien frmTimKiemNhanVien = new frmTimKiemNhanVien();

                //Đặt form hiện tại là form cha
                frmTimKiemNhanVien.MdiParent = this;

                frmTimKiemNhanVien.Show();
            }
        }
        private void xuấtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon fr = new frmHoaDon();
            fr.Show();
        }
    }
}
