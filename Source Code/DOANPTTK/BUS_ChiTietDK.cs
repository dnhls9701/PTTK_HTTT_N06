using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class BUS_ChiTietDK
    {
        DAL_ChiTietDK dalChiTietDK;

        public BUS_ChiTietDK()
        {
            dalChiTietDK = new DAL_ChiTietDK();
        }
        public bool TaoChiTietDKGoi(DTO_ChiTietDK ctdk)
        {
            return dalChiTietDK.TaoChiTietDKGoi(ctdk);
        }

        public bool TaoChiTietDKLe(DTO_ChiTietDK ctdk)
        {
            return dalChiTietDK.TaoChiTietDKLe(ctdk);
        }

    }
}
