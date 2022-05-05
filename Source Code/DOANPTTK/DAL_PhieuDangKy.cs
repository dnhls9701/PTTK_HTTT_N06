using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_PhieuDangKy
    {
        DataConnection dc;
        public DAL_PhieuDangKy()
        {
            dc = new DataConnection();

        }
        public DataTable LayThongTinPhieuDangKy()
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUDANGKY", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable KiemTraThongTinPhieuDangKy(DTO_PhieuDangKy phieuDangKy)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUDANGKY WHERE MADANGKY = @MaDangKy AND LOAI = @Loai", con);
                da.SelectCommand.Parameters.Add("@MaDangKy", SqlDbType.VarChar).Value = phieuDangKy.MaDangKy;
                da.SelectCommand.Parameters.Add("@Loai", SqlDbType.Int).Value = phieuDangKy.Loai;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public bool Tao(DTO_PhieuDangKy phieuDangKy)
        {
            SqlConnection con = dc.getConnect();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT PHIEUDANGKY(MADANGKY,NGAYLAPPHIEU,MAKHACHHANG,MATRUNGTAM,NGAYTIEMDUKIEN,LOAI) VALUES (@MaDangKy, @NgayLapPhieu, @MaKhachHang, @MaTrungTam, @NgayTiemDuKien, @Loai)", con);
                command.Parameters.Add("@MaDangKy", SqlDbType.VarChar).Value = phieuDangKy.MaDangKy;
                command.Parameters.Add("@NgayLapPhieu", SqlDbType.DateTime).Value = phieuDangKy.NgayLapPhieu;
                command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = phieuDangKy.MaKhachHang;
                command.Parameters.Add("@MaTrungTam", SqlDbType.VarChar).Value = phieuDangKy.MaTrungTam;
                command.Parameters.Add("@NgayTiemDuKien", SqlDbType.DateTime).Value = phieuDangKy.NgayTiemDuKien;
                command.Parameters.Add("@Loai", SqlDbType.Int).Value = phieuDangKy.Loai;
                command.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public DataTable LayThongTinPhieuDangKyCuaKH(DTO_PhieuDangKy phieuDangKy)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUDANGKY WHERE MAKHACHHANG = @MaKhachHang", con);
                da.SelectCommand.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = phieuDangKy.MaKhachHang;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataRow LayThongTinMaDangKy(string maDangKy)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUDANGKY WHERE MADANGKY = @MaDangKy", con);
                da.SelectCommand.Parameters.Add("@MaDangKy", SqlDbType.VarChar).Value = maDangKy;
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
