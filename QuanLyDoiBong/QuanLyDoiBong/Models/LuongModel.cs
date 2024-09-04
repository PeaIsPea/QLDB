using QuanLyDoiBong.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Models
{
    public class LuongModel
    {
        public static DataTable DanhSach()
        {
            return KetNoiDB.ExecuteQuery("SELECT * FROM Luong");
        }

        public static bool Them(string macauthu, int thangluong, float sotien)
        {
            string sql = "INSERT INTO Luong(MaCauThu,ThangLuong,SoTien) VALUES( @MaCauThu , @ThangLuong , @SoTien )";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { macauthu, thangluong, sotien }) > 0;
        }

        public static bool Sua(string macauthu, int thangluong, float sotien, int id)
        {
            string sql = "UPDATE Luong SET MaCauThu = @MaCauThu , ThangLuong = @ThangLuong , SoTien = @SoTien WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { macauthu, thangluong, sotien, id }) > 0;
        }

        public static bool Xoa(int id)
        {
            string sql = "DELETE FROM Luong WHERE id = @id";
            return KetNoiDB.ExecuteNonQuery(sql, new object[] { id }) > 0;
        }
    }
}
