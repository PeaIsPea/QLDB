using QuanLyDoiBong.Controllers;
using QuanLyDoiBong.SystemFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoiBong.Views
{
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            //Combobox loại tài khoản tự chọn vị trí đầu tiên
            cmbLoaiTK.SelectedIndex = 0;
            //Nhấn lại nút làm mới
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = TaiKhoanController.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string _tendangnhap = txbTenDangNhap.Text.Trim();
            string _matkhau = HamDungChung.MD5(txbMatKhau.Text.Trim());
            string _loai_tk = cmbLoaiTK.SelectedItem.ToString();

            if(_tendangnhap.Length > 0 && txbMatKhau.Text.Trim().Length > 0)
            {
                try
                {
                    if (TaiKhoanController.Them(_tendangnhap, _matkhau, _loai_tk) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = (int)numID.Value;
            string _tendangnhap = txbTenDangNhap.Text.Trim();
            string _matkhau = HamDungChung.MD5(txbMatKhau.Text.Trim());
            string _loai_tk = cmbLoaiTK.SelectedItem.ToString();

            if (id > 0 && _tendangnhap.Length > 0 && txbMatKhau.Text.Trim().Length > 0)
            {
                try
                {
                    if (TaiKhoanController.Sua(_tendangnhap, _matkhau, _loai_tk, id) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = (int)numID.Value;
            string _tendangnhap = txbTenDangNhap.Text.Trim();

            if (id > 0 && _tendangnhap.Length > 0)
            {
                if(MessageBox.Show("Bạn có muốn xóa tài khoản [" + _tendangnhap + "]?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (TaiKhoanController.Xoa(id) == true)
                        {
                            btnLamMoi.PerformClick();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Tài khoản đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numID.Value = int.Parse(dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString());
            txbTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            txbMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString().Trim();
            cmbLoaiTK.SelectedItem = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString().Trim();
            dtpkNgayTao.Value = DateTime.Parse(dgvTaiKhoan.CurrentRow.Cells[4].Value.ToString().Trim());
        }
    }
}
