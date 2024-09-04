using QuanLyDoiBong.Views;
using QuanLyDoiBong.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDoiBong.SystemFiles;

namespace QuanLyDoiBong
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string _tendangnhap = txbTenDangNhap.Text;
            string _matkhau = HamDungChung.MD5(txbMatKhau.Text);

            //nếu đăng nhập thành công
            if(TaiKhoanController.DangNhap(_tendangnhap, _matkhau) == true) 
            {
                DataTable thongtin = TaiKhoanController.LayThongTin(_tendangnhap);
                HamDungChung._ID = int.Parse(thongtin.Rows[0]["id"].ToString());
                HamDungChung._TENDANGNHAP = thongtin.Rows[0]["TenDangNhap"].ToString().Trim();
                HamDungChung._MATKHAU = thongtin.Rows[0]["MatKhau"].ToString().Trim();
                HamDungChung._LOAI_TK = thongtin.Rows[0]["LoaiTK"].ToString().Trim();
                HamDungChung._NGAYTAO = thongtin.Rows[0]["NgayTao"].ToString().Trim();

                fQuanLyChung f = new fQuanLyChung();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            //nếu đăng nhập thất bại
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
