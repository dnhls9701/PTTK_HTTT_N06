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
    public partial class frmDSPhanCong : Form
    {
        BUS_PhanCong BUS_phanCong;
        public frmDSPhanCong()
        {
            InitializeComponent();
            BUS_phanCong = new BUS_PhanCong();
        }

        private void frmDSPhanCong_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS_phanCong.DocPhanCong();
            dgv_dsphancong.DataSource = dt;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
