using QuanLyDoiBong.Model;
using QuanLyDoiBong.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Controllers
{
    public class TaiKhoanController
    {
        public static bool DangNhap(string tendangnhap, string matkhau)
        {
            return TaiKhoanModel.DangNhap(tendangnhap, matkhau);
        }

        public static DataTable LayThongTin(string tendangnhap)
        {
            return TaiKhoanModel.LayThongTin(tendangnhap);
        }

        public static DataTable DanhSach()
        {
            return TaiKhoanModel.DanhSach();
        }

        public static bool Them(string tendangnhap, string matkhau, string loaitk)
        {
            return TaiKhoanModel.Them(tendangnhap, matkhau, loaitk);
        }

        public static bool Sua(string tendangnhap, string matkhau, string loaitk, int id)
        {
            return TaiKhoanModel.Sua(tendangnhap, matkhau, loaitk, id);
        }

        public static bool Xoa(int id)
        {
            return TaiKhoanModel.Xoa(id);
        }

        public static bool CapNhat_TenDangNhap(string tendangnhap, int id)
        {
            return TaiKhoanModel.CapNhat_TenDangNhap(tendangnhap, id);
        }

        public static bool CapNhat_MatKhau(string matkhaumoi, string matkhaucu, int id)
        {
            return TaiKhoanModel.CapNhat_MatKhau(matkhaumoi, matkhaucu, id);
        }

        public static bool CapNhat_TenDangNhap_MatKhau(string tendangnhap, string matkhaumoi, string matkhaucu, int id)
        {
            return TaiKhoanModel.CapNhat_TenDangNhap_MatKhau(tendangnhap, matkhaumoi, matkhaucu, id);
        }
    }
}
