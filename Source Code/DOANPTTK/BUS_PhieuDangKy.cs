using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class BUS_PhieuDangKy
    {
        DAL_PhieuDangKy dalPhieuDangKy;
        public BUS_PhieuDangKy()
        {
            dalPhieuDangKy = new DAL_PhieuDangKy();
        }
        public DataTable LayThongTinPhieuDangKy()
        {
            return dalPhieuDangKy.LayThongTinPhieuDangKy();
        }
        public DataTable KiemTraThongTinPhieuDangKy(DTO_PhieuDangKy phieuDangKy)
        {
            return dalPhieuDangKy.KiemTraThongTinPhieuDangKy(phieuDangKy);
        }

        public DataTable LayThongTinPhieuDangKyCuaKH(DTO_PhieuDangKy phieuDangKy)
        {
            return dalPhieuDangKy.LayThongTinPhieuDangKyCuaKH(phieuDangKy);
        }

        public bool TaoPhieuDangKy(DTO_PhieuDangKy phieuDangKy)
        {
            return dalPhieuDangKy.Tao(phieuDangKy);
        }

        public DataRow LayThongTinMaDangKy(string maDangKy)
        {
            return dalPhieuDangKy.LayThongTinMaDangKy(maDangKy);
        }
    }
}
