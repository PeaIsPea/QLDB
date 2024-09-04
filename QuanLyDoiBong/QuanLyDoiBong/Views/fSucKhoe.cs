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
    public partial class fSucKhoe : Form
    {
        public fSucKhoe()
        {
            InitializeComponent();
        }

        private void fSucKhoe_Load(object sender, EventArgs e)
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
            dgvSucKhoe.DataSource = SucKhoeController.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string _macauthu = cmbMaCauThu.SelectedValue.ToString().Trim();
            string _ngaykham = dtpkNgayKham.Value.ToShortDateString();
            string _tinhtrang = txbTinhTrang.Text.Trim();

            if (txbTinhTrang.Text.Length > 0 && _ngaykham.Length > 0 && _macauthu.Length > 0)
            {
                try
                {
                    if (SucKhoeController.Them(_macauthu, _ngaykham, _tinhtrang) == true)
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
            string _ngaykham = dtpkNgayKham.Value.ToShortDateString();
            string _tinhtrang = txbTinhTrang.Text.Trim();

            if (_id > 0 && txbTinhTrang.Text.Length > 0 && _ngaykham.Length > 0 && _macauthu.Length > 0)
            {
                try
                {
                    if (SucKhoeController.Sua(_macauthu, _ngaykham, _tinhtrang, _id) == true)
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
                        if (SucKhoeController.Xoa(_id) == true)
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

        private void dgvSucKhoe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numID.Value = int.Parse(dgvSucKhoe.CurrentRow.Cells[0].Value.ToString());
            cmbMaCauThu.SelectedValue = dgvSucKhoe.CurrentRow.Cells[1].Value.ToString();
            dtpkNgayKham.Value = DateTime.Parse(dgvSucKhoe.CurrentRow.Cells[2].Value.ToString());
            txbTinhTrang.Text = dgvSucKhoe.CurrentRow.Cells[3].Value.ToString().Trim();
        }
    }
}
