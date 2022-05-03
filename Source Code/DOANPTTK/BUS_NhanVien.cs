using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien;
        public BUS_NhanVien()
        {
            dalNhanVien = new DAL_NhanVien();
        }
        public DataTable DocThongTinNhanVien(DTO_NhanVien nhanVien)
        {
            return dalNhanVien.DocThongTinNhanVien(nhanVien);
        }
    }
}
