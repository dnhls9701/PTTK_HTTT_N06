using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOANPTTK
{
    class BUS_DatMuaVacXin
    {
        DAL_DatMuaVacXin dalDatMuaVacXin;

        public BUS_DatMuaVacXin()
        {
            dalDatMuaVacXin = new DAL_DatMuaVacXin();
        }

        public DataTable DocThongTinDatMua(string makh)
        {
            return dalDatMuaVacXin.DocThongTinDatMua(makh);
        }
        public string TaoMaDatMua()
        {
            return dalDatMuaVacXin.TaoMaDatMua();
        }

        public bool TaoDatMuaVacXin(DTO_DatMuaVacXin datmuavacxin)
        {
            return dalDatMuaVacXin.TaoDatMuaVacXin(datmuavacxin);
        }
    }


}
