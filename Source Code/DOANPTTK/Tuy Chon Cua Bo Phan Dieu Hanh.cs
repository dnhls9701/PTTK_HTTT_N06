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
    public partial class frmOptionsBPDH : Form
    {
        public frmOptionsBPDH()
        {
            InitializeComponent();
        }

        private void btnPhanCongCongViec_Click(object sender, EventArgs e)
        {
            frmPhanCongCongViec frmPhanCongCongViec = new frmPhanCongCongViec();
            frmPhanCongCongViec.ShowDialog();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
        }

        
    }
}
