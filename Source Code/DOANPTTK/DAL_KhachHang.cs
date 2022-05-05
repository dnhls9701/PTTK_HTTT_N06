using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_KhachHang
    {
        DataConnection dc;

        public DAL_KhachHang()
        {
            dc = new DataConnection();

        }
        public DataRow DocThongTinKhachHang(string MaKhachHang)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE MAKHACHHANG = @MaKhachHang", con);
                da.SelectCommand.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = MaKhachHang;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0];
            }
            catch
            {
                return null;
            }
        }
    }
}
