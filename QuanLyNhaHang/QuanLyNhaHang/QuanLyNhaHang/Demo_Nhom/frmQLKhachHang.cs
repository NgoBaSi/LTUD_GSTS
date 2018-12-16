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
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=HVGIANG\SQLEXPRESS;Initial Catalog=QLNhaHangTiecCuoi;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from KhachHang";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataHienThi.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNhaHangTiecCuoiDataSet.sp_LayDSKhachHang' table. You can move, or remove it, as needed.
            this.sp_LayDSKhachHangTableAdapter.Fill(this.qLNhaHangTiecCuoiDataSet.sp_LayDSKhachHang);
            // TODO: This line of code loads data into the 'qLNhaHangTiecCuoiDataSet1.KhachHang' table. You can move, or remove it, as needed.
            ketnoicsdl();
        }
        int index;
        private void dataHienThi_Click(object sender, EventArgs e)
        {
            index = dataHienThi.CurrentRow.Index;
            txtMaKH.Text = dataHienThi.Rows[index].Cells[0].Value.ToString();
            txtTenKH.Text = dataHienThi.Rows[index].Cells[1].Value.ToString();
            //dtNgaySinh.Value = dataHienThi.Rows[index].Cells[2].Value.ToString();
            txtGioiTinh.Text = dataHienThi.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = dataHienThi.Rows[index].Cells[4].Value.ToString();
            txtEmail.Text = dataHienThi.Rows[index].Cells[5].Value.ToString();
            txtSDT.Text = dataHienThi.Rows[index].Cells[6].Value.ToString();
            txtGhiChu.Text = dataHienThi.Rows[index].Cells[7].Value.ToString();
        }
        string them;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=HVGIANG\SQLEXPRESS;Initial Catalog=QLNhaHangTiecCuoi;Integrated Security=True");
                cnn.Open();
                them = "insert into KhachHang values('" + txtMaKH.Text + "','" + txtTenKH.Text + "','" + dtNgaySinh.Value.ToShortDateString()+ "','" + txtGioiTinh.Text + "','" + txtDiaChi.Text + "','" + txtEmail.Text + "','" + txtSDT.Text + "','" + txtGhiChu.Text + "')";
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
                xoa = "delete KhachHang where MaKH = '" + txtMaKH.Text + "'";
                SqlCommand commandthem = new SqlCommand(xoa, cnn);
                commandthem.ExecuteNonQuery();
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
    }
}
