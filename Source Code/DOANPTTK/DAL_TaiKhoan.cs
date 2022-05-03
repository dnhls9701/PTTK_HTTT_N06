﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANPTTK
{
    class DAL_TaiKhoan
    {
        DataConnection dc;
        public DAL_TaiKhoan()
        {
            dc = new DataConnection();

        }
        public DataTable DocThongTinTaiKhoan(DTO_TaiKhoan taiKhoan)
        {
            try
            {
                SqlConnection con = dc.getConnect();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAIKHOAN WHERE TENTAIKHOAN = @TenTaiKhoan", con);
                da.SelectCommand.Parameters.Add("@TenTaiKhoan", SqlDbType.VarChar).Value = taiKhoan.TenTaiKhoan;
                //da.SelectCommand.Parameters.AddWithValue("@TenTaiKhoan", "%" + txt + "%");
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
