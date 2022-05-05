using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class BUS_GoiTiem
    {
        DAL_GoiTiem dalGoiTiem;
        public BUS_GoiTiem()
        {
            dalGoiTiem = new DAL_GoiTiem();
        }
        public DataTable DocThongTinGoiTiem()
        {
            return dalGoiTiem.DocThongTinGoiTiem();
        }
    }
}
