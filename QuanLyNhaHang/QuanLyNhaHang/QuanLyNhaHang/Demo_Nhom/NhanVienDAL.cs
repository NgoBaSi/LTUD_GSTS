using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QuanLyNhaHang.Demo_Nhom
{
    //class NhanVienDAL
    //{
    //    //khai báo biến
    //    DataConnection dc;
    //    SqlDataAdapter da;
    //    SqlCommand cmd;

    //    //Khởi tạo 
    //    public NhanVienDAL()
    //    {
    //        dc = new DataConnection();
    //    }

    //    //Hàm Lấy tất cả dữ liệu nhân viên có trong sql 
    //    //<summary>
    //    //Hàm lấy tất cả dữ liệu nhân viên trong sql ra form
    //    //</summary>
    //    //<returns>getAllNhanVien</returns>
    //    public DataTable getAllNhanVien()
    //    {

    //        //B1: Tạo Câu Lệnh sql để lấy toàn bộ sinh viên
    //        string sql = "SELECT * FROM QLiNhanVien";

    //        //B2: Tạo Một kết nối đến sql
    //        SqlConnection conn = dc.getConnect();

    //        //Khởi tạo đối tượng của lớp DataAdapter
    //        da = new SqlDataAdapter(sql, conn);

    //        //B4: Mở kết nối
    //        conn.Open();

    //        //B5: Đổ dữ liệu từ DataAdapter vào DataTable
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);

    //        //B6: Đoang kết nối lại
    //        conn.Close();
    //        return dt;
    //    }

    //    //Hàm Thêm sinh viên 
    //    // <summary>
    //    // Hàm thêm sinh viên bằng form vào sql
    //    // </summary>
    //    // <param name="nv">chuỗi</param>
    //    // <returns>InserNhanVien</returns>
    //    public bool InserNhanVien(QLiNhanvien nv)
    //    {
    //        string sql = "INSERT INTO QLiNhanVien(TenNV, TaiKhoan, MatKhau, NLMatKhau, SDT, DiaChi, ChucVu, TrangThai) VALUES (@TenNV, @TaiKhoan, @MatKhau, @NLMatKhau, @SDT, @DiaChi, @ChucVu, @TrangThai)";
    //        SqlConnection conn = dc.getConnect();

    //        //Hàm sửa lỗi try catch
    //        try
    //        {
    //            //khởi tạo
    //            cmd = new SqlCommand(sql, conn);
    //            conn.Open();

    //            //thêm thông tin nhân viên
    //            cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV;//thêm tên nhân viên
    //            cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = nv.TaiKhoan;//thêm tài khoản nhân viên
    //            cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = nv.MatKhau;//thêm mật khẩu nhân viên
    //            cmd.Parameters.Add("@NLMatKhau", SqlDbType.NVarChar).Value = nv.NLMatKhau;//thêm nhập lại mật khẩu cho nhân viên
    //            cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = nv.SDT;//thêm số điện thoại cho nhân viên
    //            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;//thêm ddaiajc hỉ cho nhân viên
    //            cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nv.ChucVu;//thêm chức vụ cho nhân viên
    //            cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = nv.TrangThai;//thêm trạng thái cho nhân viên
    //            cmd.ExecuteNonQuery();

    //            //Đóng phương thức kết nối lại
    //            conn.Close();

    //        }
    //        catch (Exception e)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }

    //    //Hàm sửa Thông tin nhân viên
    //    /// <summary>
    //    /// Hàm sửa thông tin sinh viên từ form vào sql
    //    /// </summary>
    //    /// <param name="nv">chuỗi</param>
    //    /// <returns>UpdateNhanVien</returns>
    //    public bool UpdateNhanVien(QLiNhanvien nv)
    //    {
    //        string sql = "UPDATE QLiNhanvien SET TenNV = @TenNV, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau, NLMatKhau = @NLMatKhau, SDT = @SDT, DiaChi = @DiaChi, ChucVu = @ChucVu, TrangThai = @TrangThai WHERE id = @id";
    //        SqlConnection conn = dc.getConnect();

    //        //Hàm sửa lỗi try catch
    //        try
    //        {
    //            //khởi tạo
    //            cmd = new SqlCommand(sql, conn);
    //            conn.Open();

    //            //sửa thông tin nhân viên
    //            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = nv.id;//Sửa tên nhân viên
    //            cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = nv.TaiKhoan;//Sửa tài khoản nhân viên
    //            cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = nv.MatKhau;//Sửa mật khẩu nhân viên
    //            cmd.Parameters.Add("@NLMatKhau", SqlDbType.NVarChar).Value = nv.NLMatKhau;//Sửa nhập lại mật khẩu cho nhân viên
    //            cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = nv.SDT;//Sửa số điện thoại cho nhân viên
    //            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nv.DiaChi;//Sửa ddaiajc hỉ cho nhân viên
    //            cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nv.ChucVu;//Sửa chức vụ cho nhân viên
    //            cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = nv.TrangThai;//Sửa trạng thái cho nhân viên
    //            cmd.ExecuteNonQuery();

    //            //Đóng phương thức kết nối lại
    //            conn.Close();

    //        }
    //        catch (Exception e)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }

    //    //Hàm xóa thông tin nhân viên
    //    /// <summary>
    //    /// Hàm xóa thông tin nhân viên mà bạn cần muốn xóa
    //    /// </summary>
    //    /// <param name="nv">Chuỗi</param>
    //    /// <returns>DeleteNhanvien</returns>
    //    public bool DeleteNhanvien(QLiNhanvien nv)
    //    {
    //        string sql = "DELETE QLiNhanVien WHERE id = @id";
    //        SqlConnection conn = dc.getConnect();

    //        //Hàm sửa lỗi try catch
    //        try
    //        {
    //            //khởi tạo
    //            cmd = new SqlCommand(sql, conn);
    //            conn.Open();

    //            //Xóa thông tin nhân viên
    //            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = nv.id;//Xóa tên nhân viên
    //            cmd.ExecuteNonQuery();

    //            //Đóng phương thức kết nối lại
    //            conn.Close();

    //        }
    //        catch (Exception e)
    //        {
    //            return false;
    //        }
    //        return true;
    //    }
    //}
}
