using QuanLyDoiBong.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Controllers
{
    public class ThietBiController
    {
        public static DataTable DanhSach()
        {
            return ThietBiModel.DanhSach();
        }

        public static bool Them(string mathietbi, string tenthietbi, int soluong, string manhataitro)
        {
            return ThietBiModel.Them(mathietbi, tenthietbi, soluong, manhataitro);
        }

        public static bool Sua(string mathietbi, string tenthietbi, int soluong, string manhataitro, int id)
        {
            return ThietBiModel.Sua(mathietbi, tenthietbi, soluong, manhataitro, id);
        }

        public static bool Xoa(int id)
        {
            return ThietBiModel.Xoa(id);
        }
    }
}
