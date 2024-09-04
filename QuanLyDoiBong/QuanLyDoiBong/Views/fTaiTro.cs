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
    public partial class fTaiTro : Form
    {
        public fTaiTro()
        {
            InitializeComponent();
        }

        private void fTaiTro_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTaiTro.DataSource = TaiTroController.DanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string _mataitro = txbMaTaiTro.Text.Trim();
            string _nhataitro = txbNhaTaiTro.Text.Trim();
            string _ngaytaitro = dtpkNgayTaiTro.Value.ToShortDateString();

            if(txbMaTaiTro.Text.Length > 0 && txbNhaTaiTro.Text.Length > 0 )
            {
                try
                {
                    if (TaiTroController.Them(_mataitro, _nhataitro, _ngaytaitro) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Nhà tài trợ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string _nhataitro = txbNhaTaiTro.Text.Trim();

            //nếu có nhấn vào dòng dữ liệu
            if(_id > 0)
            {
                if(MessageBox.Show("Bạn có muốn xóa nhà tài trợ [" + _nhataitro + "]?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (TaiTroController.Xoa(_id) == true)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            int _id = (int)numID.Value;
            string _mataitro = txbMaTaiTro.Text.Trim();
            string _nhataitro = txbNhaTaiTro.Text.Trim();
            string _ngaytaitro = dtpkNgayTaiTro.Value.ToShortDateString();

            if (txbMaTaiTro.Text.Length > 0 && txbNhaTaiTro.Text.Length > 0)
            {
                try
                {
                    if (TaiTroController.Sua(_mataitro, _nhataitro, _ngaytaitro, _id) == true)
                    {
                        btnLamMoi.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Nhà tài trợ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvTaiTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numID.Value = int.Parse(dgvTaiTro.CurrentRow.Cells[0].Value.ToString());
            txbMaTaiTro.Text = dgvTaiTro.CurrentRow.Cells[1].Value.ToString().Trim();
            txbNhaTaiTro.Text = dgvTaiTro.CurrentRow.Cells[2].Value.ToString().Trim();
            dtpkNgayTaiTro.Value = DateTime.Parse(dgvTaiTro.CurrentRow.Cells[3].Value.ToString());
        }
    }
}
