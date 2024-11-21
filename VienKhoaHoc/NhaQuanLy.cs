﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VienKhoaHoc
{
    public class NhaQuanLy : NhanVien { 
        public string ChucVu { get; set; } 
        public int SoNgayCong { get; set; } 
        public double BacLuong { get; set; } 
        public NhaQuanLy(string hoTen, int namSinh, string bangCap, string chucVu, int soNgayCong, double bacLuong) : base(hoTen, namSinh, bangCap) { 
            ChucVu = chucVu; 
            SoNgayCong = soNgayCong; 
            BacLuong = bacLuong; 
        } 
        public override double TinhLuong() { 
            return SoNgayCong * BacLuong; 
        } 
        public override string ToString() { 
            return base.ToString() + $", Chức vụ: {ChucVu}, Số ngày công: {SoNgayCong}, Bậc lương: {BacLuong}, Lương: {TinhLuong()}"; 
        } 
    }
}
