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
    public partial class frmTraCuu : Form
    {
        string MaKhachHang;
        BUS_DatMuaVacXin busdatmua = new BUS_DatMuaVacXin();
        public frmTraCuu(string makh)
        {
            InitializeComponent();
            MaKhachHang = makh;
            this.load_ttdatmua();
        }

        private void load_ttdatmua()
        {
            DataTable dt = busdatmua.DocThongTinDatMua(MaKhachHang);
            dgv_ttdatmua.DataSource = dt;
        }

        private void frmTraCuu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
