using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOANPTTK
{
    class BUS_PhanCong
    {
        DAL_PhanCong dalPhanCong;

        public BUS_PhanCong()
        {
            dalPhanCong = new DAL_PhanCong();
        }

        public DataTable DocPhanCong()
        {
            return dalPhanCong.DocPhanCong();
        }

        public bool TaoPhanCong(DTO_PhanCong phancong)
        {
            return dalPhanCong.TaoPhanCong(phancong);
        }

        public bool XoaPhanCong(DTO_PhanCong phancong)
        {
            return dalPhanCong.XoaPhanCong(phancong);
        }
    }

   
}
