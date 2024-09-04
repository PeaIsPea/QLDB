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
    public partial class fQuanLyChung : Form
    {
        public fQuanLyChung()
        {
            InitializeComponent();
        }
        
        //Hàm gọi form vào trong panel
        private void AddFormtoPanel(object form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);

            Form hf = form as Form;
            hf.TopLevel = false;
            hf.FormBorderStyle = FormBorderStyle.None;
            hf.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(hf);
            this.panelMain.Tag = hf;
            hf.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            AddFormtoPanel(new fTrangChu());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            AddFormtoPanel(new fTaiKhoan());
        }

        private void btnTaiTro_Click(object sender, EventArgs e)
        {
            AddFormtoPanel(new fTaiTro());
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            AddFormtoPanel(new fCaNhan());
        }

        private void btnDoiTuyen_Click(object sender, EventArgs e)
        {
            AddFormtoPanel(new fDoiTuyen());
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            AddFormtoPanel(new fThietBi());
        }

        private void btnCauThu_Click(object sender, EventArgs e)
        {
            AddFormtoPanel(new fCauThu());
        }

        private void btnSucKhoe_Click(object sender, EventArgs e)
        {
            AddFormtoPanel(new fSucKhoe());
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            AddFormtoPanel(new fLuong());
        }

        private void fQuanLyChung_Load(object sender, EventArgs e)
        {
            lbXinChao.Text = "Xin chào: " + HamDungChung._TENDANGNHAP;
            lbLoaiTK.Text = "Loại tài khoản: " + HamDungChung._LOAI_TK;
            lbDongHo.Text = DateTime.Now.ToShortTimeString();
            lbNgayThang.Text = DateTime.Now.ToString("dd/MM/yyyy");

            if (HamDungChung._LOAI_TK == "Nhân viên")
            {
                btnLuong.BackColor = Color.FromArgb(188, 232, 255);
                btnSucKhoe.BackColor = Color.FromArgb(188, 232, 255);
                btnThietBi.BackColor = Color.FromArgb(188, 232, 255);
                btnTaiTro.BackColor = Color.FromArgb(188, 232, 255);
                btnTaiKhoan.BackColor = Color.FromArgb(188, 232, 255);
                btnDoiTuyen.BackColor = Color.FromArgb(188, 232, 255);

                btnLuong.Enabled = false;
                btnSucKhoe.Enabled = false;
                btnThietBi.Enabled = false;
                btnTaiTro.Enabled = false;
                btnTaiKhoan.Enabled = false;
                btnDoiTuyen.Enabled = false;
            }


            //Tự động nhấn nút "Trang chủ"
            btnTrangChu.PerformClick();
        }
    }
}
