using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class BUS_VacXin
    {
        DAL_VacXin dalVacXin;

        public BUS_VacXin()
        {
            dalVacXin = new DAL_VacXin();
        }

        public DataTable DocThongTinGoiTiem()
        {
            return dalVacXin.DocThongTinGoiTiem();
        }

        public DataTable DocThongTinTiemLe()
        {
            return dalVacXin.DocThongTinTiemLe();
        }
    }
}
