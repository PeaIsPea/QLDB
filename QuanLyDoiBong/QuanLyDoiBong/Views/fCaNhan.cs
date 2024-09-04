using QuanLyDoiBong.Controllers;
using QuanLyDoiBong.SystemFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoiBong.Views
{
    public partial class fCaNhan : Form
    {
        public fCaNhan()
        {
            InitializeComponent();
        }

        private void fCaNhan_Load(object sender, EventArgs e)
        {
            txbInfo_ID.Text = HamDungChung._ID.ToString();
            txbInfo_TenDangNhap.Text = HamDungChung._TENDANGNHAP;
            txbInfo_MatKhau.Text = HamDungChung._MATKHAU;
            txbInfo_LoaiTK.Text = HamDungChung._LOAI_TK;
            txbInfo_NgayTao.Text = HamDungChung._NGAYTAO;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string _tendangnhap = txbTenDangNhap.Text.Trim();
            string _matkhaumoi = HamDungChung.MD5(txbMatKhauMoi.Text);
            string _matkhaucu = HamDungChung.MD5(txbMatKhauCu.Text);

            //Chỉ cập nhật -> tên đăng nhập
            if(txbTenDangNhap.Text.Length > 0 && txbMatKhauCu.Text.Length == 0 && txbMatKhauMoi.Text.Length == 0)
            {
                if(TaiKhoanController.CapNhat_TenDangNhap(_tendangnhap, HamDungChung._ID) == true)
                {
                    if(MessageBox.Show("Cập nhật tên đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        HamDungChung._TENDANGNHAP = _tendangnhap;
                        txbInfo_TenDangNhap.Text = _tendangnhap;
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Chỉ cập nhật -> mật khẩu
            else if(txbTenDangNhap.Text.Length == 0 && txbMatKhauCu.Text.Length > 0 && txbMatKhauMoi.Text.Length > 0)
            {
                if (TaiKhoanController.CapNhat_MatKhau(_matkhaumoi, _matkhaucu, HamDungChung._ID) == true)
                {
                    if (MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        HamDungChung._MATKHAU = _matkhaumoi;
                        txbInfo_MatKhau.Text = _matkhaumoi;
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (TaiKhoanController.CapNhat_TenDangNhap_MatKhau(_tendangnhap, _matkhaumoi, _matkhaucu, HamDungChung._ID) == true)
                {
                    if (MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        HamDungChung._TENDANGNHAP = _tendangnhap;
                        txbInfo_TenDangNhap.Text = _tendangnhap;
                        HamDungChung._MATKHAU = _matkhaumoi;
                        txbInfo_MatKhau.Text = _matkhaumoi;
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
