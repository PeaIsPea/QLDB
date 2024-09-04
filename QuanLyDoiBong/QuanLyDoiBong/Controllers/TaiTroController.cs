using QuanLyDoiBong.Models;
using System.Data;

namespace QuanLyDoiBong.Controllers
{
    public class TaiTroController
    {
        public static DataTable DanhSach()
        {
            return TaiTroModel.DanhSach();
        }

        public static bool Them(string manhataitro, string tennhataitro, string ngaytaitro)
        {
            return TaiTroModel.Them(manhataitro, tennhataitro, ngaytaitro);
        }

        public static bool Sua(string manhataitro, string tennhataitro, string ngaytaitro, int id)
        {
            return TaiTroModel.Sua(manhataitro, tennhataitro, ngaytaitro, id);
        }

        public static bool Xoa(int id)
        {
            return TaiTroModel.Xoa(id);
        }
    }
}
