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
        public frmDSHoaDon()
        {
            InitializeComponent();
            BUS_hoaDon = new BUS_HoaDon();
        }

        private void frmDSHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS_hoaDon.LayThongTinHoaDon();
            dsHoaDon.DataSource = dt;
        }

        private void btnLaphoadon_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frmLapHoaDon = new frmLapHoaDon();
            frmLapHoaDon.Show();
            this.Hide();
        }
    }
}
