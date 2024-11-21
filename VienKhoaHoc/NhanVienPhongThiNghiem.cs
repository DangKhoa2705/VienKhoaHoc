using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    public class NhanVienPhongThiNghiem : NhanVien
    {
        public double LuongThang { get; set; }

        public NhanVienPhongThiNghiem(string hoTen, int namSinh, string bangCap, double luongThang)
            : base(hoTen, namSinh, bangCap)
        {
            LuongThang = luongThang;
        }

        public override double TinhLuong()
        {
            return LuongThang;
        }

        public override string ToString()
        {
            return base.ToString() + $", Lương tháng: {LuongThang}";
        }
    }

}
