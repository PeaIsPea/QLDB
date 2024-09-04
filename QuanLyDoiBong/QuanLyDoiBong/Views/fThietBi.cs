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

namespace QuanLyDoiBong.Views
{
    public partial class fThietBi : Form
    {
        public fThietBi()
        {
            InitializeComponent();
        }

        private void fThietBi_Load(object sender, EventArgs e)
        {
            //Lấy danh sách nhà tại trợ vào combobox
            DanhSachNhaTaiTro_Combobox();
            //Tự động nhấn vào nút làm mới
            btnLamMoi.PerformClick();
        }

        private void DanhSachNhaTaiTro_Combobox()
        {
            cmbNhaTaiTro.DataSource = TaiTroController.DanhSach();
            cmbNhaTaiTro.DisplayMember = "TenNhaTaiTro";
            cmbNhaTaiTro.ValueMember = "MaNhaTaiTro";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvThietBi.DataSource = ThietBiController.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string _mathietbi = txbMaThietBi.Text.Trim();
            string _tenthietbi = txbTenThietBi.Text.Trim();
            int _soluong = (int)numSoLuong.Value;
            string _manhataitro = cmbNhaTaiTro.SelectedValue.ToString().Trim();

            if (txbMaThietBi.Text.Length > 0 && txbTenThietBi.Text.Length > 0 && _manhataitro.Length > 0)
            {
                try
                {
                    if (ThietBiController.Them(_mathietbi, _tenthietbi, _soluong, _manhataitro) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Thiết bị đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int _id = (int)numID.Value;
            string _mathietbi = txbMaThietBi.Text.Trim();
            string _tenthietbi = txbTenThietBi.Text.Trim();
            int _soluong = (int)numSoLuong.Value;
            string _manhataitro = cmbNhaTaiTro.SelectedValue.ToString().Trim();

            if (_id > 0 && txbMaThietBi.Text.Length > 0 && txbTenThietBi.Text.Length > 0 && _manhataitro.Length > 0)
            {
                try
                {
                    if (ThietBiController.Sua(_mathietbi, _tenthietbi, _soluong, _manhataitro, _id) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Thiết bị đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int _id = (int)numID.Value;
            string _tenthietbi = txbTenThietBi.Text.Trim();

            if (_id > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa [" + _tenthietbi + "]?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (ThietBiController.Xoa(_id) == true)
                        {
                            btnLamMoi.PerformClick();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu đã tồn tại ở bảng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numID.Value = int.Parse(dgvThietBi.CurrentRow.Cells[0].Value.ToString());
            txbMaThietBi.Text = dgvThietBi.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenThietBi.Text = dgvThietBi.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoLuong.Value = int.Parse(dgvThietBi.CurrentRow.Cells[3].Value.ToString().Trim());
            cmbNhaTaiTro.SelectedValue = dgvThietBi.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
