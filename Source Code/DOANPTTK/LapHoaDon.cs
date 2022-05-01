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
    public partial class frmLapHoaDon : Form
    {
        BUS_HoaDon BUS_hoaDon;
        public frmLapHoaDon()
        {
            InitializeComponent();
            BUS_hoaDon = new BUS_HoaDon();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaTT.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã trung tâm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNhanvien.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhanvien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSotien.Text))
            {
                MessageBox.Show("Bạn chưa nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSotien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dtpNgayThanhToan.Value.ToShortDateString()))
            {
                MessageBox.Show("Bạn chưa chọn ngày thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgayThanhToan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbHinhthucTT.Text))
            {
                MessageBox.Show("Bạn chưa chọn hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbHinhthucTT.Focus();
                return false;
            }
            return true;
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.MaHoaDon = txtMaHD.Text;
                hd.MaKhachHang = txtMaKH.Text;
                hd.MaTrungTam = txtMaTT.Text;
                hd.NgayThanhToan = new DateTime(dtpNgayThanhToan.Value.Year, dtpNgayThanhToan.Value.Month, dtpNgayThanhToan.Value.Day);
                hd.NhanVienLapHoaDon = txtNhanvien.Text;
                hd.SoTien = float.Parse(txtSotien.Text);
                hd.NoiDung = txtNoidung.Text;
                hd.HinhThucThanhToan = cbHinhthucTT.Text;
                if (BUS_hoaDon.TaoHoaDon(hd))
                {
                    MessageBox.Show("Tạo Hóa Đơn Thành Công!");
                }
                else
                {
                    MessageBox.Show("Tạo hóa đơn không thành công!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnXemdanhsach_Click(object sender, EventArgs e)
        {
            frmDSHoaDon frmDSHoaDon = new frmDSHoaDon();
            frmDSHoaDon.Show();
            this.Hide();
        }

    }
}
