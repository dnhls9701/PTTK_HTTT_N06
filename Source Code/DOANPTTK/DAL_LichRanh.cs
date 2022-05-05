using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_LichRanh
    {
        DataConnection dc;

        public DAL_LichRanh()
        {
            dc = new DataConnection();
        }

        public DataTable DocMaNhanVien(int ViTri)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                string strSQL = "SELECT DISTINCT MANHANVIEN FROM LICHRANH WHERE DATEDIFF(day,GETDATE(), NGAYRANH) >0 AND VITRI=" + ViTri.ToString();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable DocNgayRanh(string MaNhanVien)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                string strSQL = "SELECT DISTINCT NGAYRANH FROM LICHRANH WHERE DATEDIFF(day,GETDATE(), NGAYRANH) >0 AND MANHANVIEN='" + MaNhanVien + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable DocCaRanh(string MaNhanVien, string Ngay)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                string strSQL = "SELECT CARANH FROM LICHRANH WHERE DATEDIFF(day, NGAYRANH, CONVERT(date,'" + Ngay + "',103)) = 0 AND MANHANVIEN='" + MaNhanVien + "'";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
