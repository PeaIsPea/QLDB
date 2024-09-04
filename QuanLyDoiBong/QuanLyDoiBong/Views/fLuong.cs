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
    public partial class fLuong : Form
    {
        public fLuong()
        {
            InitializeComponent();
        }

        private void fLuong_Load(object sender, EventArgs e)
        {
            //Lấy danh sách đội tuyển vào combobox
            DanhSachCauThu_Combobox();
            //Tự động nhấn vào nút làm mới
            btnLamMoi.PerformClick();
        }

        private void DanhSachCauThu_Combobox()
        {
            cmbMaCauThu.DataSource = CauThuController.DanhSach();
            cmbMaCauThu.DisplayMember = "TenCauThu";
            cmbMaCauThu.ValueMember = "MaCauThu";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvLuong.DataSource = LuongController.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string _macauthu = cmbMaCauThu.SelectedValue.ToString().Trim();
            int _thangluong = (int)numThangLuong.Value;
            float _sotien = float.Parse(txbSoTien.Text);

            if (_macauthu.Length > 0 && _sotien > 0)
            {
                try
                {
                    if (LuongController.Them(_macauthu, _thangluong, _sotien) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi khi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string _macauthu = cmbMaCauThu.SelectedValue.ToString().Trim();
            int _thangluong = (int)numThangLuong.Value;
            float _sotien = float.Parse(txbSoTien.Text);

            if (_id > 0 && _macauthu.Length > 0 && _sotien > 0)
            {
                try
                {
                    if (LuongController.Sua(_macauthu, _thangluong, _sotien, _id) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi khi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (_id > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa [" + _id + "]?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (LuongController.Xoa(_id) == true)
                        {
                            btnLamMoi.PerformClick();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numID.Value = int.Parse(dgvLuong.CurrentRow.Cells[0].Value.ToString());
            cmbMaCauThu.SelectedValue = dgvLuong.CurrentRow.Cells[1].Value.ToString();
            numThangLuong.Value = int.Parse(dgvLuong.CurrentRow.Cells[2].Value.ToString());
            txbSoTien.Text = dgvLuong.CurrentRow.Cells[3].Value.ToString().Trim();
        }
    }
}
