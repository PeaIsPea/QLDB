using QuanLyDoiBong.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Models
{
    public class TaiKhoanModel
    {
        public static bool DangNhap(string tendangnhap, string matkhau)
        {
            string sql = "SELECT id FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            return KetNoiDB.ExecuteQuery(sql, new object[] { tendangnhap, matkhau }).Rows.Count > 0;
        }

        public static DataTable LayThongTin(string tendangnhap)
        {
            string sql = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            return KetNoiDB.ExecuteQuery(sql, new object[] { tendangnhap });
        }

        public static DataTable DanhSach()
        {
            return KetNoiDB.ExecuteQuery("select * from TaiKhoan order by NgayTao ASC");
        }

        public static bool Them(string tendangnhap, string matkhau, string loaitk)
        {
            string sql = "INSERT INTO TaiKhoan(TenDangNhap,MatKhau,LoaiTK) VALUES( @TenDangNhap , @MatKhau , @LoaiTK )";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { tendangnhap, matkhau, loaitk }) > 0;
        }

        public static bool Sua(string tendangnhap, string matkhau, string loaitk, int id)
        {
            string sql = "UPDATE TaiKhoan SET TenDangNhap = @TenDangNhap , MatKhau = @MatKhau , LoaiTK = @LoaiTK WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { tendangnhap, matkhau, loaitk, id }) > 0;
        }

        public static bool Xoa(int id)
        {
            string sql = "DELETE FROM TaiKhoan WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { id }) > 0;
        }

        public static bool CapNhat_TenDangNhap(string tendangnhap, int id)
        {
            string sql = "UPDATE TaiKhoan SET TenDangNhap = @TenDangNhap WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { tendangnhap, id }) > 0;
        }

        public static bool CapNhat_MatKhau(string matkhaumoi, string matkhaucu, int id)
        {
            string sql = "UPDATE TaiKhoan SET MatKhau = @MatKhauMoi WHERE MatKhau = @MatKhauCu AND id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { matkhaumoi, matkhaucu, id }) > 0;
        }

        public static bool CapNhat_TenDangNhap_MatKhau(string tendangnhap, string matkhaumoi, string matkhaucu, int id)
        {
            string sql = "UPDATE TaiKhoan SET TenDangNhap = @TenDangNhap , MatKhau = @MatKhauMoi WHERE MatKhau = @MatKhauCu AND id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { tendangnhap, matkhaumoi, matkhaucu, id }) > 0;
        }
    }
}
