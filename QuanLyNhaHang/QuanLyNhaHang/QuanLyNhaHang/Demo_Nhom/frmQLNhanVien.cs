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
        SqlConnection cnn = new SqlConnection(@"Data Source=HVGIANG\SQLEXPRESS;Initial Catalog=QLNhaHangTiecCuoi;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from NhanVien";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataHienThi.DataSource = dt; //đổ dữ liệu vào datagridview
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

        //Hàm Lấy cở sở dữ liệu
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaHangTiecCuoiDataSet.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.qLNhaHangTiecCuoiDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qLNhaHangTiecCuoiDataSet.sp_LayDSNhanVien' table. You can move, or remove it, as needed.
            this.sp_LayDSNhanVienTableAdapter.Fill(this.qLNhaHangTiecCuoiDataSet.sp_LayDSNhanVien);
            // TODO: This line of code loads data into the 'qLNhaHangTiecCuoiDataSet1.NhanVien' table. You can move, or remove it, as needed.
           
            ketnoicsdl();
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
        int index;
        private void dataHienThi_Click(object sender, EventArgs e)
        {
            
        }

        private void dataHienThi_Click_1(object sender, EventArgs e)
        {
            index = dataHienThi.CurrentRow.Index;
            txtMaNV.Text = dataHienThi.Rows[index].Cells[0].Value.ToString();
            txtTenNV.Text = dataHienThi.Rows[index].Cells[1].Value.ToString();
            txtGioiTinh.Text = dataHienThi.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dataHienThi.Rows[index].Cells[3].Value.ToString();
            txtDC.Text = dataHienThi.Rows[index].Cells[4].Value.ToString();
            txtChucVu.Text = dataHienThi.Rows[index].Cells[5].Value.ToString();
            txtLuong.Text = dataHienThi.Rows[index].Cells[6].Value.ToString();
            txtGhiChu.Text = dataHienThi.Rows[index].Cells[7].Value.ToString();
        }
        string them;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=HVGIANG\SQLEXPRESS;Initial Catalog=QLNhaHangTiecCuoi;Integrated Security=True");
                cnn.Open();
                them = "INSERT INTO NhanVien VALUES('" + txtMaNV.Text + "','" + txtTenNV.Text + "','" + txtGioiTinh.Text + "','" + txtSDT.Text + "','" + txtDC.Text + "','" + txtChucVu.Text + "','" + txtLuong.Text + "','"+txtGhiChu.Text+"')";
                SqlCommand commandthem = new SqlCommand(them, cnn);
                commandthem.ExecuteNonQuery();
                ketnoicsdl();
            }
            catch
            {
                MessageBox.Show("Lỗi, không thêm được.");
            }
            finally
            {
                cnn.Close();
            }
        }
        string xoa;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=HVGIANG\SQLEXPRESS;Initial Catalog=QLNhaHangTiecCuoi;Integrated Security=True");
                cnn.Open();
                xoa = "delete NhanVien where MaNV = '" + txtMaNV.Text + "'";
                SqlCommand commandxoa = new SqlCommand(xoa, cnn);
                commandxoa.ExecuteNonQuery();
                ketnoicsdl();
            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được.");
            }
            finally
            {
                cnn.Close();
            }
        }
        string sua;
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=HVGIANG\SQLEXPRESS;Initial Catalog=QLNhaHangTiecCuoi;Integrated Security=True");
                cnn.Open();
                sua = "update NhanVien set TenNV = '"+txtTenNV.Text+"',GioiTinh = '"+txtGioiTinh.Text+"',DiaChi = '"+txtSDT.Text+"',SDT = '"+txtDC+"',ChucVu = '"+txtChucVu+"',Luong = '"+txtLuong+"',GhiChu = '"+txtGhiChu+"' where MaNV = '"+txtMaNV.Text+"'";
                SqlCommand commandsua = new SqlCommand(sua, cnn);
                commandsua.ExecuteNonQuery();
                ketnoicsdl();
            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được.");
            }
            finally
            {
                cnn.Close();
            }
        }

    }
}
