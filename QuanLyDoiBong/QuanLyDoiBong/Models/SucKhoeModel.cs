using QuanLyDoiBong.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Models
{
    public class SucKhoeModel
    {
        public static DataTable DanhSach()
        {
            return KetNoiDB.ExecuteQuery("SELECT * FROM SucKhoe");
        }

        public static bool Them(string macauthu, string ngaykham, string tinhtrang)
        {
            string sql = "INSERT INTO SucKhoe(MaCauThu,NgayKham,TinhTrang) VALUES( @MaCauThu , @NgayKham , @TinhTrang )";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { macauthu, ngaykham, tinhtrang }) > 0;
        }

        public static bool Sua(string macauthu, string ngaykham, string tinhtrang, int id)
        {
            string sql = "UPDATE SucKhoe SET MaCauThu = @MaCauThu , NgayKham = @NgayKham , TinhTrang = @TinhTrang WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { macauthu, ngaykham, tinhtrang, id }) > 0;
        }

        public static bool Xoa(int id)
        {
            string sql = "DELETE FROM SucKhoe WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { id }) > 0;
        }
    }
}
