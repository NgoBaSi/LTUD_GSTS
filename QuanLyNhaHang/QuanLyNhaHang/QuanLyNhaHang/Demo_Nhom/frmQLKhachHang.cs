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
    public partial class frmQLKhachHang : Form
    {
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhaHangDataSet.QLiNhanVien' table. You can move, or remove it, as needed.
            this.qLiNhanVienTableAdapter.Fill(this.quanLyNhaHangDataSet.QLiNhanVien);

        }
    }
}
