using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANPTTK
{
    public partial class frmOptionsCustom : Form
    {
        string MaKhachHang;
        public frmOptionsCustom(string makh)
        {
            InitializeComponent();
            this.MaKhachHang = makh;
        }

        private void btnDangKyTiemChung_Click(object sender, EventArgs e)
        {
            frmDangKyTiemChung frmDangKyTiemChung = new frmDangKyTiemChung();
            frmDangKyTiemChung.ShowDialog();
            //this.Hide();
        }

        private void btnDatMuaVacXin_Click(object sender, EventArgs e)
        {
            frmDatMuaVacXin frmDatMuaVacXin = new frmDatMuaVacXin(this.MaKhachHang);
            frmDatMuaVacXin.ShowDialog();
            //this.Hide();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            frmTraCuu frmTraCuu = new frmTraCuu(this.MaKhachHang);
            frmTraCuu.ShowDialog();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
        }
    }
}
