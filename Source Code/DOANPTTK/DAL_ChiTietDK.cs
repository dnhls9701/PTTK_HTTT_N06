using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_ChiTietDK
    {
        DataConnection dc;

        public DAL_ChiTietDK()
        {
            dc = new DataConnection();
        }

        public bool TaoChiTietDKGoi(DTO_ChiTietDK ctdk)
        {
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT CHITIETDKGOI(MADANGKY, MAGOITIEM) VALUES (@MaDangKy, @MaGoiTiem)", con);
                command.Parameters.Add("@MaDangKy", SqlDbType.VarChar).Value = ctdk.MaDangKy;
                command.Parameters.Add("@MaGoiTiem", SqlDbType.VarChar).Value = ctdk.MaGoiTiem_VacXin;
                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool TaoChiTietDKLe(DTO_ChiTietDK ctdk)
        {
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO CHITIETDKLE(MADANGKY,MAVACXIN) VALUES (@MaDangKy, @MaVacXin)", con);
                command.Parameters.Add("@MaDangKy", SqlDbType.VarChar).Value = ctdk.MaDangKy;
                command.Parameters.Add("@MaVacXin", SqlDbType.VarChar).Value = ctdk.MaGoiTiem_VacXin;
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
