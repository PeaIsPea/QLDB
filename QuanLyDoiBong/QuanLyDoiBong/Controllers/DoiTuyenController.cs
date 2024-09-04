using QuanLyDoiBong.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Controllers
{
    public class DoiTuyenController
    {
        public static DataTable DanhSach()
        {
            return DoiTuyenModel.DanhSach();
        }

        public static bool Them(string madoituyen, string tendoituyen, string manhataitro)
        {
            return DoiTuyenModel.Them(madoituyen, tendoituyen, manhataitro);
        }

        public static bool Sua(string madoituyen, string tendoituyen, string manhataitro, int id)
        {
            return DoiTuyenModel.Sua(madoituyen, tendoituyen, manhataitro, id);
        }

        public static bool Xoa(int id)
        {
            return DoiTuyenModel.Xoa(id);
        }
    }
}
