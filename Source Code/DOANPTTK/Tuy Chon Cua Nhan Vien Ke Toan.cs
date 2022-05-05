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
    public partial class frmOptionsNVKT : Form
    {
        frmDangNhap frmDangNhap = new frmDangNhap();
        string tenTaiKhoan;
        public frmOptionsNVKT(string tenTK)
        {
            //cur_frmDangNhap = frmDangNhap;
            InitializeComponent();
            this.tenTaiKhoan = tenTK;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap.ShowDialog();
                this.Show();
            }
            else if (result == DialogResult.No)
            {
                //..
            }
        }

        private void btnXuLyThanhToan_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frmLapHoaDon = new frmLapHoaDon(this.tenTaiKhoan);
            //this.Hide();
            frmLapHoaDon.ShowDialog();
            //this.Show();
        }
    }
}
