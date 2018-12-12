using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Demo_Nhom
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        //Hàm đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HVGIANG\SQLEXPRESS;Initial Catalog=QLNHTC;Integrated Security=True");
            try{
                //Mở keest nối
                conn.Open();
                //khai báo biến
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "Select * from Login where Username = '" + tk + "' and Pass = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Lấy dữ liệu về từ câu lệnh
                SqlDataReader dta = cmd.ExecuteReader();
                
                //kiểm tra Đăng nhập
                if (dta.Read() == true)
                {
                    //MessageBox.Show("Đăng nhập Thành công");
                    //khai báo biến
                    frmTrangChu frmTC = new frmTrangChu();
                    this.Hide();
                    frmTC.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại Mời Bạn Đăng Nhập Lại","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }

        //Hàm Thoogn báo và kiểm tra người dùng có muốn thoát hay không
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Thông báo và kiểm tra
            if (MessageBox.Show("Bạn Có Thật sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        //Hàm thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
