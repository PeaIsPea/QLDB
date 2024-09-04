using QuanLyDoiBong.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.Controllers
{
    public class CauThuController
    {
        public static DataTable DanhSach()
        {
            return CauThuModel.DanhSach();
        }

        public static bool Them(string macauthu, string tencauthu, string ngaysinh, string diachi, string sdt, string vitri, int soao, string madoituyen)
        {
            return CauThuModel.Them(macauthu, tencauthu, ngaysinh, diachi, sdt, vitri, soao, madoituyen);
        }

        public static bool Sua(string macauthu, string tencauthu, string ngaysinh, string diachi, string sdt, string vitri, int soao, string madoituyen, int id)
        {
            return CauThuModel.Sua(macauthu, tencauthu, ngaysinh, diachi, sdt, vitri, soao, madoituyen, id);
        }

        public static bool Xoa(int id)
        {
            return CauThuModel.Xoa(id);
        }
    }
}
