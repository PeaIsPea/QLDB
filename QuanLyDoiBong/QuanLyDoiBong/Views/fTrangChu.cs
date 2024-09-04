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
    public partial class fTrangChu : Form
    {
        public fTrangChu()
        {
            InitializeComponent();
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            lbNgayThang.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbXinChao.Text = "Xin chào: " + HamDungChung._TENDANGNHAP;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDongHo.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
