using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class BUS_KhachHang
    {
        DAL_KhachHang dalKhachHang;
        public BUS_KhachHang()
        {
            dalKhachHang = new DAL_KhachHang();
        }
        public DataRow DocThongTinKhachHang(string MaKhachHang)
        {
            return dalKhachHang.DocThongTinKhachHang(MaKhachHang);
        }
    }
}
