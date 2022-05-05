using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_PhanCong
    {
        DataConnection dc;

        public DAL_PhanCong()
        {
            dc = new DataConnection();
        }

        public DataTable DocPhanCong()
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHANCONG WHERE DATEDIFF(day,GETDATE(), NGAYPHANCONG) >0", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public bool TaoPhanCong(DTO_PhanCong phancong)
        {
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO PHANCONG(MANHANVIEN,NGAYPHANCONG,CALAM,PHONGLAMVIEC) VALUES (@MaNhanVien,CONVERT(date,@NgayPhanCong,103),@CaLam,@PhongLamViec)", con);
                command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phancong.MaNhanVien;
                command.Parameters.Add("@NgayPhanCong", SqlDbType.Date).Value = phancong.NgayPhanCong;
                command.Parameters.Add("@CaLam", SqlDbType.Int).Value = phancong.CaLam;
                command.Parameters.Add("@PhongLamViec", SqlDbType.Int).Value = phancong.PhongLamViec;
                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool XoaPhanCong(DTO_PhanCong phancong)
        {
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM PHANCONG WHERE MANHANVIEN = @MaNhanVien AND NGAYPHANCONG = CONVERT(date,@NgayPhanCong,103) AND CALAM=@CALAM", con);
                command.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = phancong.MaNhanVien;
                command.Parameters.Add("@NgayPhanCong", SqlDbType.Date).Value = phancong.NgayPhanCong;
                command.Parameters.Add("@CaLam", SqlDbType.Int).Value = phancong.CaLam;
                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
