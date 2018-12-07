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
    public partial class frmHopDongDatTiec : Form
    {
        public frmHopDongDatTiec()
        {
            InitializeComponent();
        }

        //Hàm kiểm tra xem bạn có muốn thoát khỏi trang này hay không
        private void frmHopDongDatTiec_FormClosing(object sender, FormClosingEventArgs e)
        {
            //khai báo biến
            DialogResult r;

            //Thông báo dòng lệnh cho người dung biết
            r = MessageBox.Show(" Bạn có chắc chắn muốn thoát?", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
           
            //kiểm tra
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //Hàm thoát
        private void btnThoat2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Hàm chuyển sang form tìm kiểm hợp đồng(frmTraCuuHopDong)
        private void btnTim_Click(object sender, EventArgs e)
        {
            //khai báo biến
            frmTraCuuHopDong frmTC = new frmTraCuuHopDong();
            this.Hide();
            frmTC.ShowDialog();
            this.Show();
        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTienCoc_Click(object sender, EventArgs e)
        {

        }

        private void lblPhiDichVu_Click(object sender, EventArgs e)
        {

        }

        private void lblThue_Click(object sender, EventArgs e)
        {

        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void grbKhuyenMai_Enter(object sender, EventArgs e)
        {

        }
    }
}
