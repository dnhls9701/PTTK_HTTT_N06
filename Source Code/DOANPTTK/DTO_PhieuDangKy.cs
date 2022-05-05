using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPTTK
{
    class DTO_PhieuDangKy
    {
        public string MaDangKy { set; get; }
        public DateTime NgayLapPhieu { set; get; }
        public string MaKhachHang { set; get; }
        public string MaTrungTam { set; get; }
        public DateTime NgayTiemDuKien { set; get; }
        public int Loai { set; get; }
    }
}
