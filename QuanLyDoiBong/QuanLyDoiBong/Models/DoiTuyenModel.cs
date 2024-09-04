using QuanLyDoiBong.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Models
{
    public class DoiTuyenModel
    {
        public static DataTable DanhSach()
        {
            return KetNoiDB.ExecuteQuery("SELECT dt.id, dt.MaDoiTuyen, dt.TenDoiTuyen, dt.MaNhaTaiTro, ntt.TenNhaTaiTro FROM DoiTuyen dt, NhaTaiTro ntt WHERE dt.MaNhaTaiTro = ntt.MaNhaTaiTro");
        }

        public static bool Them(string madoituyen, string tendoituyen, string manhataitro)
        {
            string sql = "INSERT INTO DoiTuyen(MaDoiTuyen,TenDoiTuyen,MaNhaTaiTro) VALUES( @MaDoiTuyen , @TenDoiTuyen , @MaNhaTaiTro )";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { madoituyen, tendoituyen, manhataitro }) > 0;
        }

        public static bool Sua(string madoituyen, string tendoituyen, string manhataitro, int id)
        {
            string sql = "UPDATE DoiTuyen SET MaDoiTuyen = @MaDoiTuyen , TenDoiTuyen = @TenDoiTuyen , MaNhaTaiTro = @MaNhaTaiTro WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { madoituyen, tendoituyen, manhataitro, id }) > 0;
        }

        public static bool Xoa(int id)
        {
            string sql = "DELETE FROM DoiTuyen WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { id }) > 0;
        }
    }
}
