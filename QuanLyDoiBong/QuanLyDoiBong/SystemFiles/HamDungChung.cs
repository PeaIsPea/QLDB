using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiBong.SystemFiles
{
    public class HamDungChung
    {
        public static int _ID = 0;
        public static string _TENDANGNHAP = "";
        public static string _MATKHAU = "";
        public static string _LOAI_TK = "";
        public static string _NGAYTAO = "";

        public static string MD5(string s)
        {
            var provider = System.Security.Cryptography.MD5.Create();
            StringBuilder builder = new StringBuilder();

            foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                builder.Append(b.ToString("x2").ToLower());

            return builder.ToString();
        }
    }
}
