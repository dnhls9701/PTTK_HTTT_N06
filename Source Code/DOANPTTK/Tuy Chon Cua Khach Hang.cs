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
        frmDangNhap frmDangNhap = new frmDangNhap();
        string tenTaiKhoan;
        public frmOptionsCustom(string tenTK)
        {
            //cur_frmDangNhap = frmDangNhap;
            InitializeComponent();
            this.tenTaiKhoan = tenTK;
        }

        private void btnDangKyTiemChung_Click(object sender, EventArgs e)
        {
            frmDangKyTiemChung frmDangKyTiemChung = new frmDangKyTiemChung(this.tenTaiKhoan);
            this.Hide();
            frmDangKyTiemChung.ShowDialog();
            this.Show();

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
    }
}
