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
    public partial class fCauThu : Form
    {
        public fCauThu()
        {
            InitializeComponent();
        }

        private void fCauThu_Load(object sender, EventArgs e)
        {
            //Lấy danh sách đội tuyển vào combobox
            DanhSachDoiTuyen_Combobox();
            //Tự động nhấn vào nút làm mới
            btnLamMoi.PerformClick();
        }

        private void DanhSachDoiTuyen_Combobox()
        {
            cmbMaDoiTuyen.DataSource = DoiTuyenController.DanhSach();
            cmbMaDoiTuyen.DisplayMember = "TenDoiTuyen";
            cmbMaDoiTuyen.ValueMember = "MaDoiTuyen";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvCauThu.DataSource = CauThuController.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string _macauthu = txbMaCauThu.Text.Trim();
            string _tencauthu = txbTenCauThu.Text.Trim();
            string _ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string _diachi = txbDiaChi.Text.Trim();
            string _sdt = txbSDT.Text.Trim();
            string _vitri = txbViTri.Text.Trim();
            int _soao = (int)numSoAo.Value;
            string _madoituyen = cmbMaDoiTuyen.SelectedValue.ToString().Trim();

            if (txbMaCauThu.Text.Length > 0 && txbTenCauThu.Text.Length > 0 && _madoituyen.Length > 0)
            {
                try
                {
                    if (CauThuController.Them(_macauthu, _tencauthu, _ngaysinh, _diachi, _sdt, _vitri, _soao, _madoituyen) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Cầu thủ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string _macauthu = txbMaCauThu.Text.Trim();
            string _tencauthu = txbTenCauThu.Text.Trim();
            string _ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string _diachi = txbDiaChi.Text.Trim();
            string _sdt = txbSDT.Text.Trim();
            string _vitri = txbViTri.Text.Trim();
            int _soao = (int)numSoAo.Value;
            string _madoituyen = cmbMaDoiTuyen.SelectedValue.ToString().Trim();

            if (_id > 0 && txbMaCauThu.Text.Length > 0 && txbTenCauThu.Text.Length > 0 && _madoituyen.Length > 0)
            {
                try
                {
                    if (CauThuController.Sua(_macauthu, _tencauthu, _ngaysinh, _diachi, _sdt, _vitri, _soao, _madoituyen, _id) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Cầu thủ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string _tencauthu = txbTenCauThu.Text.Trim();

            if (_id > 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa [" + _tencauthu + "]?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (CauThuController.Xoa(_id) == true)
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

        private void dgvCauThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numID.Value = int.Parse(dgvCauThu.CurrentRow.Cells[0].Value.ToString());
            txbMaCauThu.Text = dgvCauThu.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenCauThu.Text = dgvCauThu.CurrentRow.Cells[2].Value.ToString().Trim();
            dtpkNgaySinh.Value = DateTime.Parse(dgvCauThu.CurrentRow.Cells[3].Value.ToString().Trim());
            txbDiaChi.Text = dgvCauThu.CurrentRow.Cells[4].Value.ToString().Trim();
            txbSDT.Text = dgvCauThu.CurrentRow.Cells[5].Value.ToString().Trim();
            txbViTri.Text = dgvCauThu.CurrentRow.Cells[6].Value.ToString().Trim();
            numSoAo.Value = int.Parse(dgvCauThu.CurrentRow.Cells[7].Value.ToString().Trim());
            cmbMaDoiTuyen.SelectedValue = dgvCauThu.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
