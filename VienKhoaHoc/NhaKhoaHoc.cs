using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    public class NhaKhoaHoc : NhanVien
    {
        public string ChucVu { get; set; }
        public int SoBaiBao { get; set; }
        public int SoNgayCong { get; set; }
        public double BacLuong { get; set; }
        public NhaKhoaHoc(string hoTen, int namSinh, string bangCap, string chucVu, int soBaiBao, int soNgayCong, double bacLuong) : base(hoTen, namSinh, bangCap) { 
            ChucVu = chucVu; 
            SoBaiBao = soBaiBao; 
            SoNgayCong = soNgayCong; 
            BacLuong = bacLuong; 
        }
        public override double TinhLuong() { 
            return SoNgayCong * BacLuong; 
        }
        public override string ToString()
        {
            return base.ToString() + $", Chức vụ: {ChucVu}, Số bài báo: {SoBaiBao}, Số ngày công: {SoNgayCong}, Bậc lương: {BacLuong}, Lương: {TinhLuong()}";
        }
    }
}
