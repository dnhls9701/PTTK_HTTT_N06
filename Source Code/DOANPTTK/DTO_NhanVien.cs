using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPTTK
{
    class DTO_NhanVien
    {
        public string MaNhanVien { set; get; }
        public string TenNhanVien { set; get; }
        public DateTime NgaySinh { set; get; }
        public string SoDienThoai { set; get; }
        public string Email { set; get; }
        public string DiaChi { set; get; }
        public string BangCap { set; get; }
        public float Luong { set; get; }
        public string TrungTamLamViec { set; get; }
        public int ViTri { set; get; }
    }
}
