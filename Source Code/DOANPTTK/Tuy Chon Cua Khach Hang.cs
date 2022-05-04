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
        frmDangNhap cur_frmDangNhap;
        public frmOptionsCustom(frmDangNhap frmDangNhap)
        {
            cur_frmDangNhap = frmDangNhap;
            InitializeComponent();
        }

        private void btnDangKyTiemChung_Click(object sender, EventArgs e)
        {
            frmDangKyTiemChung frmDangKyTiemChung = new frmDangKyTiemChung();
            frmDangKyTiemChung.Show();
            this.Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.Close();
                cur_frmDangNhap.Show();
            }
            else if (result == DialogResult.No)
            {
                //..
            }
        }
    }
}
