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
    public partial class frmDSGoiTiem : Form
    {
        BUS_GoiTiem BUS_GoiTiem;
        BUS_ChiTietDK BUS_chiTietDK = new BUS_ChiTietDK();
        BUS_PhieuDangKy BUS_phieuDangKy = new BUS_PhieuDangKy();
        string maDangKy;
        public frmDSGoiTiem(string maDK)
        {
            InitializeComponent();
            BUS_GoiTiem = new BUS_GoiTiem();
            this.maDangKy = maDK;

            DataRow dr = BUS_phieuDangKy.LayThongTinMaDangKy(this.maDangKy);
        }

        private void frmDSGoiTiem_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS_GoiTiem.DocThongTinGoiTiem();
            dgDanhSachGoiTiem.DataSource = dt;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in dgDanhSachGoiTiem.Rows)
            {
                bool checkBoxSelected = Convert.ToBoolean(dr.Cells["colChon"].Value);
                if (checkBoxSelected)
                {
                    DTO_ChiTietDK ctdk = new DTO_ChiTietDK();
                    ctdk.MaDangKy = this.maDangKy;
                    ctdk.MaGoiTiem_VacXin = dr.Cells[1].Value.ToString();
                    if (BUS_chiTietDK.TaoChiTietDKGoi(ctdk))
                    {
                        MessageBox.Show("Thêm gói tiêm thành công!", "Thông báo thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Thêm gói tiêm không thành công!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
            }
        }
    }
}
