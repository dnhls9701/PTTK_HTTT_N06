using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DOANPTTK
{
    public partial class frmDangNhap : Form
    {
        BUS_TaiKhoan BUS_taiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
            BUS_taiKhoan = new BUS_TaiKhoan();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1ETUQ04I\SQLEXPRESS;Initial Catalog=QLTC;Persist Security Info=True;User ID=sa;Password=12345");

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            frmDangKy.Show();
            this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = BUS_taiKhoan.DocThongTinTaiKhoan();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                string tenTaiKhoan = row["TENTAIKHOAN"].ToString();
                string loaiND = row["LOAIND"].ToString();
                int type = int.Parse(loaiND);
                switch (type)
                {
                    case 0:

                        break;
                    case 1: 
                }
            } else
            {
                //Do not exist
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
