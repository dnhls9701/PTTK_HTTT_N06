using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_ChiTietDatMua
    {
        DataConnection dc;

        public DAL_ChiTietDatMua()
        {
            dc = new DataConnection();
        }

        public bool TaoChiTietDatMuaGOI(DTO_ChiTietDatMua ctdatmua)
        {
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO CHITIETDATMUAGOI(MADATMUA,MAGOITIEM) VALUES (@MaDatMua, @MaGoiTiem)", con);
                command.Parameters.Add("@MaDatMua", SqlDbType.VarChar).Value = ctdatmua.MaDatMua;
                command.Parameters.Add("@MaGoiTiem", SqlDbType.VarChar).Value = ctdatmua.MaGoiTiem_VacXin;
                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool TaoChiTietDatMuaLE(DTO_ChiTietDatMua ctdatmua)
        {
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO CHITIETDATMUALE(MADATMUA,MAVACXIN) VALUES (@MaDatMua, @MaVacXin)", con);
                command.Parameters.Add("@MaDatMua", SqlDbType.VarChar).Value = ctdatmua.MaDatMua;
                command.Parameters.Add("@MaVacXin", SqlDbType.VarChar).Value = ctdatmua.MaGoiTiem_VacXin;
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
