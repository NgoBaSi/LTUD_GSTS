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
    public partial class frmTraCuuHopDong : Form
    {
        public frmTraCuuHopDong()
        {
            InitializeComponent();
        }

        //Hàm kiểm tra xem bạn có muốn thoát khỏi trang này hay không
        private void frmTraCuuHopDong_FormClosing(object sender, FormClosingEventArgs e)
        {
            //khai báo biến
            DialogResult r;

            //Thông báo người người dùng biết bạn có muốn thoát hay không
            r = MessageBox.Show(" Bạn có chắc chắn muốn thoát?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            
            //Kiểm tra
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Hàm thoát
        private void btnThoat4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTKHD_Click(object sender, EventArgs e)
        {

        }

        private void frmTraCuuHopDong_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
