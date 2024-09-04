using QuanLyDoiBong.Model;
using System.Data;

namespace QuanLyDoiBong.Models
{
    public class TaiTroModel
    {
        public static DataTable DanhSach()
        {
            return KetNoiDB.ExecuteQuery("SELECT * FROM NhaTaiTro ORDER BY NgayTaiTro DESC");
        }

        public static bool Them(string manhataitro, string tennhataitro, string ngaytaitro)
        {
            string sql = "INSERT INTO NhaTaiTro(MaNhaTaiTro,TenNhaTaiTro,NgayTaiTro) VALUES( @MaNhaTaiTro , @TenNhaTaiTro , @NgayTaiTro )";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { manhataitro, tennhataitro, ngaytaitro }) > 0;
        }

        public static bool Sua(string manhataitro, string tennhataitro, string ngaytaitro, int id)
        {
            string sql = "UPDATE NhaTaiTro SET MaNhaTaiTro = @MaNhaTaiTro , TenNhaTaiTro = @TenNhaTaiTro , NgayTaiTro = @NgayTaiTro WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { manhataitro, tennhataitro, ngaytaitro, id }) > 0;
        }

        public static bool Xoa(int id)
        {
            string sql = "DELETE FROM NhaTaiTro WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { id }) > 0;
        }
    }
}
