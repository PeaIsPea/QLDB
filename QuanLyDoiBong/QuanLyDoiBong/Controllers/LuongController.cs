using QuanLyDoiBong.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Controllers
{
    public class LuongController
    {
        public static DataTable DanhSach()
        {
            return LuongModel.DanhSach();
        }

        public static bool Them(string macauthu, int thangluong, float sotien)
        {
            return LuongModel.Them(macauthu, thangluong, sotien);
        }

        public static bool Sua(string macauthu, int thangluong, float sotien, int id)
        {
            return LuongModel.Sua(macauthu, thangluong, sotien, id);
        }

        public static bool Xoa(int id)
        {
            return LuongModel.Xoa(id);
        }
    }
}
