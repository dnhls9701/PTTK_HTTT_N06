using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOANPTTK
{
    class BUS_LichRanh
    {
        DAL_LichRanh dalLichRanh;

        public BUS_LichRanh()
        {
            dalLichRanh = new DAL_LichRanh();
        }

        public DataTable DocMaNhanVien(int ViTri)
        {
            return dalLichRanh.DocMaNhanVien(ViTri);
        }

        public DataTable DocNgayRanh(string MaNhanVien)
        {
            return dalLichRanh.DocNgayRanh(MaNhanVien);
        }

        public DataTable DocCaRanh(string MaNhanVien, string Ngay)
        {
            return dalLichRanh.DocCaRanh(MaNhanVien, Ngay);
        }
    }


}
