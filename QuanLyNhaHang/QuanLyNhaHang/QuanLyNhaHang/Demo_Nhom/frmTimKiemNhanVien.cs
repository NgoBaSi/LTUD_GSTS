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
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        //Hàm kiểm tra xem bạn có muốn thoát khỏi trang này hay không
        private void frmTimKiemNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //khai bao biến
            DialogResult r;
            
            //Thông báo lệnh cho người dùng biết
            r = MessageBox.Show(" Bạn có chắc chắn muốn thoát?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            
            //kiểm tra
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Hàm Thoát 
        private void btnThoat3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaHangTiecCuoiDataSet1.NhanVien' table. You can move, or remove it, as needed.
            

        }
    }
}
