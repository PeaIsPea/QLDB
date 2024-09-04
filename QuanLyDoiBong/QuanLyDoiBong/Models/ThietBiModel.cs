using QuanLyDoiBong.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Models
{
    public class ThietBiModel
    {
        public static DataTable DanhSach()
        {
            return KetNoiDB.ExecuteQuery("SELECT * FROM ThietBi");
        }

        public static bool Them(string mathietbi, string tenthietbi, int soluong, string manhataitro)
        {
            string sql = "INSERT INTO ThietBi(MaThietBi,TenThietBi,SoLuong,MaNhaTaiTro) VALUES( @MaThietBi , @TenThietBi , @SoLuong , @MaNhaTaiTro )";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { mathietbi, tenthietbi, soluong, manhataitro }) > 0;
        }

        public static bool Sua(string mathietbi, string tenthietbi, int soluong, string manhataitro, int id)
        {
            string sql = "UPDATE ThietBi SET MaThietBi = @MaThietBi , TenThietBi = @TenThietBi , SoLuong = @SoLuong , MaNhaTaiTro = @MaNhaTaiTro WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { mathietbi, tenthietbi, soluong, manhataitro, id }) > 0;
        }

        public static bool Xoa(int id)
        {
            string sql = "DELETE FROM ThietBi WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { id }) > 0;
        }
    }
}
