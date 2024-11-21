using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            List <NhanVien> danhSachNhanVien = new List<NhanVien>
        {
            new NhaKhoaHoc("Nguyễn Đăng Khoa", 1999, "Tiến sĩ", "Giáo sư", 10, 20, 500000),
            new NhaQuanLy("Lê Vũ Minh Hoàng", 1990, "Thạc sĩ", "Trưởng phòng", 22, 300000),
            new NhanVienPhongThiNghiem("Nguyễn Hoàng Hiếu", 2024, "Kỹ sư", 10000000)
        };

            double tongLuongNhaKhoaHoc = 0;
            double tongLuongNhaQuanLy = 0;
            double tongLuongNhanVienPhongThiNghiem = 0;

            foreach (var nhanVien in danhSachNhanVien)
            {
                Console.WriteLine(nhanVien);
                if (nhanVien is NhaKhoaHoc)
                {
                    tongLuongNhaKhoaHoc += nhanVien.TinhLuong();
                }
                else if (nhanVien is NhaQuanLy)
                {
                    tongLuongNhaQuanLy += nhanVien.TinhLuong();
                }
                else if (nhanVien is NhanVienPhongThiNghiem)
                {
                    tongLuongNhanVienPhongThiNghiem += nhanVien.TinhLuong();
                }
            }

            Console.WriteLine("\nTổng lương nhà khoa học: " + tongLuongNhaKhoaHoc);
            Console.WriteLine("Tổng lương nhà quản lý: " + tongLuongNhaQuanLy);
            Console.WriteLine("Tổng lương nhân viên phòng thí nghiệm: " + tongLuongNhanVienPhongThiNghiem);
        }
    }

}
