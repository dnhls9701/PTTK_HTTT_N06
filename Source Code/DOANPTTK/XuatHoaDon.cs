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
    public partial class frmDSHoaDon : Form
    {
        BUS_HoaDon BUS_hoaDon;
        string tenTaiKhoan;
        public frmDSHoaDon(string tenTK)
        {
            InitializeComponent();
            BUS_hoaDon = new BUS_HoaDon();
            this.tenTaiKhoan = tenTK;
        }

        private void frmDSHoaDon_Load(object sender, EventArgs e)
        {
            DTO_HoaDon hd = new DTO_HoaDon();
            hd.NhanVienLapHoaDon = this.tenTaiKhoan;
            DataTable dt = BUS_hoaDon.LayThongTinHoaDon(hd);
            dsHoaDon.DataSource = dt;
        }

        private void btnLaphoadon_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frmLapHoaDon = new frmLapHoaDon(this.tenTaiKhoan);
            this.Hide();
            frmLapHoaDon.ShowDialog();
            this.Show();
        }
    }
}
