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
            frmQLNhanVien nhanvien = new frmQLNhanVien();
            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
        }

        //Hàm chuyển sang form Hợp đồng đặt tiệc
        private void menuHopDongDatTiec_Click(object sender, EventArgs e)
        {
            frmHopDongDatTiec fr = new frmHopDongDatTiec();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        //Hàm chuyển sang form tra cứu hợp đồng(tìm kiếm hợp đồng)
        private void menuTraCuuHopDong_Click(object sender, EventArgs e)
        {
            frmTraCuuHopDong fr = new frmTraCuuHopDong();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        //Hàm chuyển sang form tìm kiếm Nhân viên
        private void menuTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            frmTimKiemNhanVien fr = new frmTimKiemNhanVien();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }
        private void xuấtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon fr = new frmHoaDon();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKhachHang fr = new frmQLKhachHang();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon fr = new frmHoaDon();
            this.Hide();
            fr.ShowDialog();
            this.Show();
        }
    }
}
