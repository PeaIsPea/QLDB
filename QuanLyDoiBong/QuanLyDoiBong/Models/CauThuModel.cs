using QuanLyDoiBong.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Models
{
    public class CauThuModel
    {
        public static DataTable DanhSach()
        {
            return KetNoiDB.ExecuteQuery("SELECT * FROM CauThu");
        }

        public static bool Them(string macauthu, string tencauthu, string ngaysinh, string diachi, string sdt, string vitri, int soao, string madoituyen)
        {
            string sql = "INSERT INTO CauThu(MaCauThu,TenCauThu,NgaySinh,DiaChi,SDT,ViTri,SoAo,MaDoiTuyen) VALUES( @MaCauThu , @TenCauThu , @NgaySinh , @DiaChi , @SDT , @ViTri , @SoAo , @MaDoiTuyen )";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { macauthu, tencauthu, ngaysinh, diachi, sdt, vitri, soao, madoituyen }) > 0;
        }

        public static bool Sua(string macauthu, string tencauthu, string ngaysinh, string diachi, string sdt, string vitri, int soao, string madoituyen, int id)
        {
            string sql = "UPDATE CauThu SET MaCauThu = @MaCauThu , TenCauThu = @TenCauThu , NgaySinh = @NgaySinh , DiaChi = @DiaChi , SDT = @SDT , ViTri = @ViTri , SoAo = @SoAo , MaDoiTuyen = @MaDoiTuyen WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { macauthu, tencauthu, ngaysinh, diachi, sdt, vitri, soao, madoituyen, id }) > 0;
        }

        public static bool Xoa(int id)
        {
            string sql = "DELETE FROM CauThu WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { id }) > 0;
        }
    }
}
