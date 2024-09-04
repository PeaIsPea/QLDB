using QuanLyDoiBong.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Controllers
{
    public class SucKhoeController
    {
        public static DataTable DanhSach()
        {
            return SucKhoeModel.DanhSach();
        }

        public static bool Them(string macauthu, string ngaykham, string tinhtrang)
        {
            return SucKhoeModel.Them(macauthu, ngaykham, tinhtrang);
        }

        public static bool Sua(string macauthu, string ngaykham, string tinhtrang, int id)
        {
            return SucKhoeModel.Sua(macauthu, ngaykham, tinhtrang, id);
        }

        public static bool Xoa(int id)
        {
            return SucKhoeModel.Xoa(id);
        }
    }
}
