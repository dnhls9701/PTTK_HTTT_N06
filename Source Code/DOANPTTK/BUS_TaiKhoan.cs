using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTaiKhoan;
        public BUS_TaiKhoan()
        {
            dalTaiKhoan = new DAL_TaiKhoan();
        }
        public DataTable DocThongTinTaiKhoan()
        {
            return dalTaiKhoan.DocThongTinTaiKhoan();
        }

    }
}
