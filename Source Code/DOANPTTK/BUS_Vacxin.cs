using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class BUS_Vacxin
    {
        DAL_Vacxin dalVacxin;
        public BUS_Vacxin()
        {
            dalVacxin = new DAL_Vacxin();
        }
        public DataTable DocThongTinVacxin()
        {
            return dalVacxin.DocThongTinVacxin();
        }

        public DataTable DocThongTinGoiTiem()
        {
            return dalVacxin.DocThongTinGoiTiem();
        }

        public DataTable DocThongTinTiemLe()
        {
            return dalVacxin.DocThongTinTiemLe();
        }
    }
}
