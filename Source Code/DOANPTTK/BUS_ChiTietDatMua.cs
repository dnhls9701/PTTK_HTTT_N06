using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANPTTK
{
    class BUS_ChiTietDatMua
    {
        DAL_ChiTietDatMua dalChiTietDatMua;

        public BUS_ChiTietDatMua()
        {
            dalChiTietDatMua = new DAL_ChiTietDatMua();
        }
        public bool TaoChiTietDatMuaGOI(DTO_ChiTietDatMua ctdatmua)
        {
            return dalChiTietDatMua.TaoChiTietDatMuaGOI(ctdatmua);
        }

        public bool TaoChiTietDatMuaLE(DTO_ChiTietDatMua ctdatmua)
        {
            return dalChiTietDatMua.TaoChiTietDatMuaLE(ctdatmua);
        }


    }
}
