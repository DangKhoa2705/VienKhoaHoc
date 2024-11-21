using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    public abstract class NhanVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string BangCap { get; set; }
        public NhanVien(string hoTen, int namSinh, string bangCap) { 
            HoTen = hoTen; 
            NamSinh = namSinh; 
            BangCap = bangCap; 
        }
        public abstract double TinhLuong();
        public override string ToString()
        {
            return $"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Bằng cấp: {BangCap}";
        }
    }
}
