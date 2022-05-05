using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class BUS_HoaDon
    {
        DAL_HoaDon dalHoaDon;
        public BUS_HoaDon()
        {
            dalHoaDon = new DAL_HoaDon();
        }
        public DataTable LayThongTinHoaDon(DTO_HoaDon hoaDon)
        {
            return dalHoaDon.LayThongTinHoaDon(hoaDon);
        }
        public bool TaoHoaDon (DTO_HoaDon hoaDon)
        {
            return dalHoaDon.Tao(hoaDon);
        }
    }
}
