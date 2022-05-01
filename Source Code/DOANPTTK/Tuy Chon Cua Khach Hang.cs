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
        public frmOptionsCustom()
        {
            InitializeComponent();
        }

        private void btnDangKyTiemChung_Click(object sender, EventArgs e)
        {
            frmDangKyTiemChung frmDangKyTiemChung = new frmDangKyTiemChung();
            frmDangKyTiemChung.Show();
            this.Hide();
        }
    }
}
