using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_HoaDon
    {
        DataConnection dc;
        public DAL_HoaDon()
        {
            dc = new DataConnection();

        }
        public DataTable LayThongTinHoaDon(DTO_HoaDon hoaDon)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON WHERE NHANVIENLAPHOADON = @MaNhanVien", con);
                da.SelectCommand.Parameters.Add("@MaNhanVien", SqlDbType.VarChar).Value = hoaDon.NhanVienLapHoaDon;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public bool Tao(DTO_HoaDon hoaDon)
        {
            SqlConnection con = dc.getConnect();
            try
            {
                
                con.Open();
                SqlCommand command = new SqlCommand("INSERT HOADON(MAHOADON,MAKHACHHANG,MATRUNGTAM,NGAYTHANHTOAN,SOTIEN,NHANVIENLAPHOADON,HINHTHUCTHANHTOAN,NOIDUNG) VALUES (@MaHoaDon, @MaKhachHang, @MaTrungTam, @NgayThanhToan, @SoTien, @NhanVienLapHoaDon, @HinhThucThanhToan, @NoiDung)", con);
                command.Parameters.Add("@MaHoaDon", SqlDbType.VarChar).Value = hoaDon.MaHoaDon;
                command.Parameters.Add("@MaKhachHang", SqlDbType.VarChar).Value = hoaDon.MaKhachHang;
                command.Parameters.Add("@MaTrungTam", SqlDbType.VarChar).Value = hoaDon.MaTrungTam;
                command.Parameters.Add("@NgayThanhToan", SqlDbType.DateTime).Value = hoaDon.NgayThanhToan;
                command.Parameters.Add("@SoTien", SqlDbType.Float).Value = hoaDon.SoTien;
                command.Parameters.Add("@NhanVienLapHoaDon", SqlDbType.VarChar).Value = hoaDon.NhanVienLapHoaDon;
                command.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar).Value = hoaDon.HinhThucThanhToan;
                command.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = hoaDon.NoiDung;
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