using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_DatMuaVacXin
    {
        DataConnection dc;

        public DAL_DatMuaVacXin()
        {
            dc = new DataConnection();
        }
        public DataTable DocThongTinDatMua(string makh)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                string strSQL = "SELECT MADATMUA,NGAYDAT,MATRUNGTAM,TINHTRANG FROM DATMUAVACXIN WHERE MAKHACHHANG = '" + makh + "'";
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
        public string TaoMaDatMua()
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) AS SL FROM DATMUAVACXIN", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return "DM"+((int)dt.Rows[0]["SL"]+1).ToString();
            }
            catch
            {
                return null;
            }
        }

        public bool TaoDatMuaVacXin(DTO_DatMuaVacXin datmuavacxin)
        {
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO DATMUAVACXIN(MADATMUA,NGAYDAT,MAKHACHHANG,MATRUNGTAM,TINHTRANG,LOAI) VALUES (@MaDatMua, @NgayDat, @MaKhachHang, @MaTrungTam , N'Đang chờ duyệt' ,@Loai)", con);
                command.Parameters.Add("@MaDatMua", SqlDbType.VarChar).Value = datmuavacxin.MaDatMua;
                command.Parameters.Add("@NgayDat", SqlDbType.DateTime).Value = datmuavacxin.NgayDat;
                command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = datmuavacxin.MaKhachHang;
                command.Parameters.Add("@MaTrungTam", SqlDbType.VarChar).Value = datmuavacxin.MaTrungTam;
                command.Parameters.Add("@Loai", SqlDbType.Int).Value = datmuavacxin.Loai;
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
