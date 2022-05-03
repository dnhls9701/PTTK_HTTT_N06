using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_NhanVien
    {
        DataConnection dc;
        public DAL_NhanVien()
        {
            dc = new DataConnection();

        }
        public DataTable DocThongTinNhanVien(DTO_NhanVien nhanVien)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN WHERE MANHANVIEN = @MaNhanVien", con);
                da.SelectCommand.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = nhanVien.MaNhanVien;
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
