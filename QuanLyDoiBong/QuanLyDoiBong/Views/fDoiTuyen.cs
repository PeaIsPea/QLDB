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
    public partial class fDoiTuyen : Form
    {
        public fDoiTuyen()
        {
            InitializeComponent();
        }

        private void fDoiTuyen_Load(object sender, EventArgs e)
        {
            //lấy danh sách nhà tài trợ
            DanhSach_TaiTro_Combobox();
            //Tự nhấn nút làm mới
            btnLamMoi.PerformClick();
        }

        private void DanhSach_TaiTro_Combobox()
        {
            cmbNhaTaiTro.DataSource = TaiTroController.DanhSach();
            cmbNhaTaiTro.DisplayMember = "TenNhaTaiTro";
            cmbNhaTaiTro.ValueMember = "MaNhaTaiTro";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDoiTuyen.DataSource = DoiTuyenController.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string _madoituyen = txbMaDoiTuyen.Text.Trim();
            string _tendoituyen = txbTenDoiTuyen.Text.Trim();
            string _manhataitro = cmbNhaTaiTro.SelectedValue.ToString().Trim();

            if (txbMaDoiTuyen.Text.Length > 0 && txbTenDoiTuyen.Text.Length > 0 && _manhataitro.Length > 0)
            {
                try
                {
                    if (DoiTuyenController.Them(_madoituyen, _tendoituyen, _manhataitro) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Đội tuyển đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDoiTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numID.Value = int.Parse(dgvDoiTuyen.CurrentRow.Cells[0].Value.ToString());
            txbMaDoiTuyen.Text = dgvDoiTuyen.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenDoiTuyen.Text = dgvDoiTuyen.CurrentRow.Cells[2].Value.ToString().Trim();
            cmbNhaTaiTro.SelectedValue = dgvDoiTuyen.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int _id = (int)numID.Value;
            string _madoituyen = txbMaDoiTuyen.Text.Trim();
            string _tendoituyen = txbTenDoiTuyen.Text.Trim();
            string _manhataitro = cmbNhaTaiTro.SelectedValue.ToString().Trim();

            if (txbMaDoiTuyen.Text.Length > 0 && txbTenDoiTuyen.Text.Length > 0 && _manhataitro.Length > 0)
            {
                try
                {
                    if (DoiTuyenController.Sua(_madoituyen, _tendoituyen, _manhataitro, _id) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Đội tuyển đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string _tendoituyen = txbTenDoiTuyen.Text.Trim();

            if(_id > 0)
            {
                if(MessageBox.Show("Bạn có muốn xóa [" + _tendoituyen + "]?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if(DoiTuyenController.Xoa(_id) == true)
                        {
                            btnLamMoi.PerformClick();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Đội tuyển đã tồn tại ở bảng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
