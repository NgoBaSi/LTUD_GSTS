using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Demo_Nhom
{
    public partial class frmQLNhanVien : Form
    {
        //khởi tạo  
        //NhanVienBLL bllNV;
       
        public frmQLNhanVien()
        {
            InitializeComponent();
          // bllNV = new NhanVienBLL();
        }

        //Hàm Thoát 
        private void btnThoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Hàm thông báo kiểm tra xem bạn có muốn thoát chương trình hay không
        private void frmQLNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //khai bao bien
            DialogResult r;

            //Thông báo Dòng lên lênh cho người dùng xem
            r = MessageBox.Show(" Bạn có chắc chắn muốn thoát?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
           
            //Kiểm tra
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Hàm Chuyển sang form tìm kiếm Nhân viên(frmTimKiemNhanVien)
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
           //khai bao bien
            frmTimKiemNhanVien frmtk = new frmTimKiemNhanVien();
            this.Hide();
            frmtk.ShowDialog();
            this.Show();
        }

        //Hàm ShowAll Tất cả nhân viên từ sql ra form
        //public void ShowAllNhanVien()
        //{
        //    DataTable dt = bllNV.getAllNhanVien();
        //    dataHienThi.DataSource = dt;
        //}




        //Hàm Lấy cở sở dữ liệu
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            //ShowAllNhanVien();
            this.qLiNhanVienTableAdapter.Fill(this.quanLyNhaHangDataSet.QLiNhanVien);

        }


        //kiểm tra và thông báo cho người dùng nhập
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show(" Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show(" Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show(" Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDC.Text))
            {
                MessageBox.Show(" Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGioiTinh.Text))
            {
                MessageBox.Show(" Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGioiTinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtChucVu.Text))
            {
                MessageBox.Show(" Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChucVu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLuong.Text))
            {
                MessageBox.Show(" Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLuong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show(" Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGhiChu.Focus();
                return false;
            }
            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    if (CheckData())
        //    {
        //        QLiNhanvien nv = new QLiNhanvien();
        //        nv.TenNV = txtTenNV.Text;
        //        nv.TaiKhoan = txtTK.Text;
        //        nv.MatKhau = txtMK.Text;
        //        nv.NLMatKhau = txtNLMK.Text;
        //        nv.SDT = Int32.Parse(txtSDT.Text);
        //        nv.DiaChi = txtDC.Text;
        //        nv.ChucVu = txtCV.Text;
        //        nv.TrangThai = txtTrangThai.Text;

        //        if (bllNV.InserNhanVien(nv))
        //        {
        //            //ShowAllNhanVien();

        //            this.qLiNhanVienTableAdapter.Fill(this.quanLyNhaHangDataSet.QLiNhanVien);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Đã có lỗi xảy ra, Xin thử lại sao nhé", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //        }
        //    }
        //}

    }
}
